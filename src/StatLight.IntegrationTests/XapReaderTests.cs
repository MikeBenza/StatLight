using System;
using System.IO;
using Ionic.Zip;
using StatLight.Core.Common;
using StatLight.Core.Configuration;
using StatLight.IntegrationTests.ProviderTests;

namespace StatLight.IntegrationTests
{
	namespace XapReader
	{
		using NUnit.Framework;
		using StatLight.Core.Tests;
		using StatLight.Core.WebServer.XapInspection;
		using System.Collections.Generic;

		[TestFixture]
		public class when_XapReader_is_loading_an_MSTest_xap : FixtureBase
		{
			private XapReadItems _xapReadItems;

			protected override void Before_all_tests()
			{
				base.Before_all_tests();

				string fileName = ProviderTests.TestXapFileLocations.SilverlightIntegrationTests;

                _xapReadItems = new XapReader(new ConsoleLogger(LogChatterLevels.Full)).LoadXapUnderTest(fileName);
			}

			//[Test]
			//public void Should_find_XapManifest()
			//{
			//	_xapReadItems.AppManifest.ShouldNotBeNull();
			//	_xapReadItems.AppManifest.ShouldNotBeEmpty();
			//}

			//[Test]
			//public void Should_have_the_correct_assembly_specified_as_the_entry_assembly()
			//{
			//	_xapReadItems.AppManifest.Contains("EntryPointAssembly=\"StatLight.IntegrationTests.Silverlight\"");
			//}

			[Test]
			public void Should_load_the_test_assembly()
			{
				_xapReadItems.TestAssemblyFullName.ShouldNotBeNull();
			}

			[Test]
			public void Should_determine_the_UnitTestProvider()
			{
				_xapReadItems.UnitTestProvider.ShouldEqual(UnitTestProviderType.MSTest);
			}
		}

		[TestFixture]
		public class when_XapReader_is_loading_an_invalid_xap : FixtureBase
		{
			private XapReadItems _xapReadItems;
			private string _xapPath;

			private List<string> _filesToCleanup = new List<string>();

			protected override void Before_all_tests()
			{
				base.Before_all_tests();

				_xapPath = Path.GetTempFileName() + ".zip";

				_filesToCleanup.Add(_xapPath);

				Action<ZipFile> addTempFileToZip = (zipFile) =>
				{
					var pathToTempFileToPlaceInXap = Path.GetTempFileName();
					using (var writer = File.CreateText(pathToTempFileToPlaceInXap))
					{
						writer.Close();
					}
					zipFile.AddFile(pathToTempFileToPlaceInXap);
					_filesToCleanup.Add(pathToTempFileToPlaceInXap);
				};

				using (var zipFile = new ZipFile(_xapPath))
				{
					addTempFileToZip(zipFile);
					addTempFileToZip(zipFile);
					addTempFileToZip(zipFile);
					addTempFileToZip(zipFile);
					zipFile.Save();
				}

                _xapReadItems = new XapReader(new ConsoleLogger(LogChatterLevels.Full)).LoadXapUnderTest(_xapPath);
			}

			protected override void After_all_tests()
			{
				base.After_all_tests();

				foreach (var file in _filesToCleanup)
					if (File.Exists(file))
						File.Delete(file);
			}

			[Test]
			public void Should_not_fail_if_given_a_bad_xap()
			{
				_xapReadItems.ShouldNotBeNull();
			}

			[Test]
			public void Should_result_in_an_Unknown_UnitTestProviderType()
			{
				_xapReadItems.UnitTestProvider.ShouldEqual(UnitTestProviderType.Undefined);
			}

			[Test]
			public void Should_expose_the_TestAssembly_as_null()
			{
                _xapReadItems.TestAssemblyFullName.ShouldBeNull();
			}
		}

		[TestFixture]
		public class when_XapReader_is_determining_the_UnitTestProviderType
		{

			[Test]
			public void Should_detect_MSTest()
			{
				ShouldLoadCorrectType(TestXapFileLocations.MSTest, UnitTestProviderType.MSTest);
			}

			[Test]
			public void Should_detect_XUnit()
			{
				ShouldLoadCorrectType(TestXapFileLocations.XUnit, UnitTestProviderType.XUnit);
			}

			[Test]
			public void Should_detect_NUnit()
			{
				ShouldLoadCorrectType(TestXapFileLocations.NUnit, UnitTestProviderType.NUnit);
			}

			[Test]
			public void Should_detect_UnitDriven()
			{
				ShouldLoadCorrectType(TestXapFileLocations.UnitDriven, UnitTestProviderType.UnitDriven);
			}

			private void ShouldLoadCorrectType(string fileName, UnitTestProviderType unitTestProviderType)
			{
                var xapReadItems = new XapReader(new ConsoleLogger(LogChatterLevels.Full)).LoadXapUnderTest(fileName);
				xapReadItems.UnitTestProvider.ShouldEqual(unitTestProviderType);
			}
		}

	}
}