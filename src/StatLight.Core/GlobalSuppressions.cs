// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project. 
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc. 
//
// To add a suppression to this file, right-click the message in the 
// Error List, point to "Suppress Message(s)", and click 
// "In Project Suppression File". 
// You do not need to add suppressions to this file manually. 
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "StatLight.Extensions.#RaiseEventSafely`1(System.EventHandler,System.Object,!!0)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Error", Scope = "member", Target = "StatLight.Core.Common.ILogger.#Error(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "StatLight.Core.Common.StatLightException")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "buttonClickInvokePattern", Scope = "member", Target = "StatLight.Core.Monitoring.DebugAssertMonitor.#ExecuteDialogSlapDown(System.Action`1<System.String>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "okButton", Scope = "member", Target = "StatLight.Core.Monitoring.DebugAssertMonitor.#ExecuteDialogSlapDown(System.Action`1<System.String>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields", Scope = "member", Target = "StatLight.Core.Monitoring.DialogMonitorRunner.#_logger")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "MessageBox", Scope = "member", Target = "StatLight.Core.Monitoring.MessageBoxMonitor.#ExecuteDialogSlapDown(System.Action`1<System.String>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "buttonClicInvokePattern", Scope = "member", Target = "StatLight.Core.Monitoring.MessageBoxMonitor.#ExecuteDialogSlapDown(System.Action`1<System.String>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "okButton", Scope = "member", Target = "StatLight.Core.Monitoring.MessageBoxMonitor.#ExecuteDialogSlapDown(System.Action`1<System.String>)")]

//TODO: work on...
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "type", Target = "StatLight.Core.Reporting.TestResultAggregator")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly", Scope = "member", Target = "StatLight.Core.Reporting.TestResultAggregator.#Dispose()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "member", Target = "StatLight.Core.Reporting.TestResultAggregator.#Dispose()")]
//End TODO work on...
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2243:AttributeStringLiteralsShouldParseCorrectly")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Stop", Scope = "member", Target = "StatLight.Core.Common.Abstractions.Timing.ITimer.#Stop()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "StatLight.Core.Configuration.ClientTestRunConfiguration.#MethodsToTest")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "MessageBoxMonitor", Scope = "member", Target = "StatLight.Core.Monitoring.MessageBoxMonitor.#ExecuteDialogSlapDown(System.Action`1<System.String>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "processId", Scope = "member", Target = "StatLight.Core.Monitoring.MessageBoxMonitor.#ExecuteDialogSlapDown(System.Action`1<System.String>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields", Scope = "member", Target = "StatLight.Core.Reporting.TestResultAggregator+EventMatchMacker.#_logger")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runnable", Scope = "member", Target = "StatLight.Core.Reporting.Messages.TestOutcome.#NotRunnable")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "StatLight.Core.Reporting.Providers.NUnit.NUnitXmlReport.#GetXmlReport()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "1#", Scope = "member", Target = "StatLight.Core.Reporting.Providers.NUnit.NUnitXmlReport.#ValidateSchema(System.String,System.Collections.Generic.IList`1<System.String>&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "StatLight", Scope = "member", Target = "StatLight.Core.Reporting.Providers.TeamCity.TeamCityTestResultHandler.#Handle(StatLight.Core.Reporting.TestCaseResult)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "StatLight.Core.Reporting.Providers.TFS.TFS2010.XmlReport.#GetXmlReport()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "StatLight.Core.Reporting.Providers.Xml.XmlReport.#GetXmlReport()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "1#", Scope = "member", Target = "StatLight.Core.Reporting.Providers.Xml.XmlReport.#ValidateSchema(System.String,System.Collections.Generic.IList`1<System.String>&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "StatLight.Core.Reporting.Providers.Xml.XmlReport.#WriteXmlReport(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "2#", Scope = "member", Target = "StatLight.Core.Reporting.Providers.Xml.XmlSchemaValidatorHelper.#ValidateSchema(System.String,System.String,System.Collections.Generic.IList`1<System.String>&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "StatLight.Core.Reporting.Providers.Xml.XmlSchemaValidatorHelper.#ValidateSchema(System.String,System.String,System.Collections.Generic.IList`1<System.String>&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string", Scope = "member", Target = "StatLight.Core.Reporting.Providers.Xml.XmlSchemaValidatorHelper.#ValidateSchema(System.String,System.String,System.Collections.Generic.IList`1<System.String>&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ContinuousTestRunner", Scope = "member", Target = "StatLight.Core.Runners.ContinuousTestRunner.#Stop()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "StatLight.Core.Runners.StatLightRunnerFactory.#StartupBrowserCommunicationTimeoutMonitor()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ForceBrowserStart", Scope = "member", Target = "StatLight.Core.WebBrowser.OutOfProcessWebBrowserBase.#Start()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "StatLight", Scope = "member", Target = "StatLight.Core.WebBrowser.OutOfProcessWebBrowserBase.#Start()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "webBrowser", Scope = "member", Target = "StatLight.Core.WebBrowser.SelfHostedWebBrowser.#Finalize()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "StatLight.Core.WebBrowser.SelfHostedWebBrowser.#Start()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "StatLight", Scope = "member", Target = "StatLight.Core.WebBrowser.SelfHostedWebBrowser.#Start()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "webBrowser", Scope = "member", Target = "StatLight.Core.WebBrowser.SelfHostedWebBrowser.#Stop()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Postback", Scope = "member", Target = "StatLight.Core.WebServer.StatLightServiceRestApi.#StatLightResultPostbackUrl")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "StatLight.Core.WebServer.WebServerLocation.#.ctor(StatLight.Core.Common.ILogger,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "XapHost", Scope = "member", Target = "StatLight.Core.WebServer.XapHost.DiskXapHostFileLoader.#LoadXapHost()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Scope = "type", Target = "StatLight.Core.WebServer.XapHost.MicrosoftTestingFrameworkVersion")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "XapHost", Scope = "member", Target = "StatLight.Core.WebServer.XapHost.XapHostFileLoaderFactory.#LoadXapHostFor(StatLight.Core.WebServer.XapHost.XapHostType)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "StatLight.Core.WebServer.XapHost.XapHostFileLoaderFactory.#MapToXapHostType(StatLight.Core.Configuration.UnitTestProviderType,System.Nullable`1<StatLight.Core.WebServer.XapHost.MicrosoftTestingFrameworkVersion>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "hklm", Scope = "member", Target = "StatLight.Core.WebServer.XapInspection.AssemblyResolver.#SilverlightFolder()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "StatLight.Core.WebServer.XapInspection.ITestFile.#File")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "AppManifest", Scope = "member", Target = "StatLight.Core.WebServer.XapInspection.XapReader.#GetTestAssemblyNameFromAppManifest(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "EntryPointAssembly", Scope = "member", Target = "StatLight.Core.WebServer.XapInspection.XapReader.#GetTestAssemblyNameFromAppManifest(System.String)")]
