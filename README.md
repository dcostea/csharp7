New Cool Features In C# 7.0

Out Variables
Tuples
Local Functions
Pattern Matching
Ref Returns and Locals

Issues:

If you plan to use C# 7.0 features in a MVC application there are some setting that must be done.
Follow these steps:

Step 1. Open NuGet console and install next packages:

Install-Package Microsoft.Net.Compilers

Step 2. Set up the Properties->Build->Advanced->Language version to C# 7.0 

Step 3. Open web.config file and locate compiler language section and update the attribute compileOptions from /langversion:6 to /langversion:7  

<system.codedom>
<compilers>
<compiler language="c#;cs;csharp" extension=".cs" type="..." warningLevel="4" compilerOptions="/langversion:7 /nowarn:1659;1699;1701" />
...
</compilers>
</system.codedom>
