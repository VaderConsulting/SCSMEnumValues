# SCSMEnumValues

WinForms tool that queries System Center Service Manager enum types from the `ServiceManager` SQL database. `frmMain` builds a Trusted_Connection string using the SQL server name typed in a text box at run time (not stored), then reads `EnumType`/`LocalizedText` into a list and grid. The `.csproj` references sibling projects `..\VaderConsulting.Database` and `..\VaderConsulting.SystemCenter` that are not in this folder (hint paths only), so the app will not build until those libraries sit beside it.

**Source last updated:** 2015-09-29  
**Language:** C#  
**Target:** .NET 4.0  
**Output:** WinExe

## How to open

Open `SCSMEnumValues.csproj` in Visual Studio.

## Attribution and provenance

Dave Robinson / VaderConsulting. This is Dave's code. `Properties/AssemblyInfo.cs` still has Visual Studio template leftovers (`AssemblyCompany` Microsoft and `AssemblyCopyright` Copyright © Microsoft 2015); those attributes are not third-party authorship of the app. NuGet: AsyncBridge 0.1.1.

## License

MIT License. Copyright (c) 2026 VaderConsulting. See `LICENSE`.
