// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Web.Abstractions.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Web.Abstractions.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.1")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.1")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Web.Abstractions.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.SecurityRulesAttribute((System.Security.SecurityRuleSet)(2), SkipVerificationInFullTrust=true)]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpApplicationStateBase))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpApplicationStateWrapper))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpBrowserCapabilitiesBase))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpBrowserCapabilitiesWrapper))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpCachePolicyBase))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpCachePolicyWrapper))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpContextBase))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpContextWrapper))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpFileCollectionBase))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpFileCollectionWrapper))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpPostedFileBase))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpPostedFileWrapper))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpRequestBase))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpRequestWrapper))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpResponseBase))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpResponseWrapper))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpServerUtilityBase))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpServerUtilityWrapper))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpSessionStateBase))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpSessionStateWrapper))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpStaticObjectsCollectionBase))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.HttpStaticObjectsCollectionWrapper))]
namespace System
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoDocumentationNoteAttribute : System.MonoTODOAttribute
    {
        public MonoDocumentationNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoExtensionAttribute : System.MonoTODOAttribute
    {
        public MonoExtensionAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoInternalNoteAttribute : System.MonoTODOAttribute
    {
        public MonoInternalNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoLimitationAttribute : System.MonoTODOAttribute
    {
        public MonoLimitationAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoNotSupportedAttribute : System.MonoTODOAttribute
    {
        public MonoNotSupportedAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoTODOAttribute : System.Attribute
    {
        public MonoTODOAttribute() { }
        public MonoTODOAttribute(string comment) { }
        public string Comment { get { throw null; } }
    }
}
