using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AWSSDK.CodePipeline")]
#if BCL35
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (3.5) - CodePipeline Service. CodePipeline Service")]
#elif BCL45
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (4.5) - CodePipeline Service. CodePipeline Service")]
#elif (WIN_RT && WINDOWS_PHONE)
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (Portable)- CodePipeline Service. CodePipeline Service")]
#elif WIN_RT
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (Windows RT) - CodePipeline Service. CodePipeline Service")]
#elif WINDOWS_PHONE
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (Windows Phone 8)- CodePipeline Service. CodePipeline Service")]
#else
#error Unknown platform constant - unable to set correct AssemblyDescription
#endif

[assembly: AssemblyConfiguration("")]
[assembly: AssemblyProduct("Amazon Web Services SDK for .NET")]
[assembly: AssemblyCompany("Amazon.com, Inc")]
[assembly: AssemblyCopyright("Copyright 2009-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("3.0")]
[assembly: AssemblyFileVersion("3.0.0.0")]

#if WINDOWS_PHONE
[assembly: System.CLSCompliant(false)]
# else
[assembly: System.CLSCompliant(true)]
#endif

#if BCL
[assembly: System.Security.AllowPartiallyTrustedCallers]
#endif