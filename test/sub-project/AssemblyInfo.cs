﻿using System.Reflection;

[assembly: AssemblyTitle("assemblyinfo-update")]
/* Expected result:
[assembly: AssemblyDescription("Test file for use with the `assemblyinfo-update` Github action for updating versions in the format 0.0.0.0")]
*/
[assembly: AssemblyDescription("Test file for use with the `assemblyinfo-update` Github action for updating versions in the format 0.0.0.0")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Second Bounce Ltd")]
[assembly: AssemblyProduct("assemblyinfo-update")]
[assembly: AssemblyCopyright("Copyright © 2022")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: AssemblyVersion("1.0.0.0")]                 /* Expected result: "8.8.##" */
[assembly: AssemblyFileVersion("1.0.0.0")]          /* Expected result: "8.8.##" */
[assembly: AssemblyInformationalVersion("3.3.3.33")]  /* Expected result: "8.8.##" */
