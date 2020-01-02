# Godot-SheetDB
Google sheets as database for Godot 3.2 C#

# Installation

* The addon uses two dlls:
    - Newtonsoft.Json
    - System.Net.Http
* To get them working in the project:
    - search for **{project-name}.csproj**
        - inside the <ItemGroup> tag where there are some dlls reference insert:
```
    <Reference Include="Newtonsoft.Json">
      <HintPath>$(ProjectDir)/addons/sheet_db/DLL/Newtonsoft.Json.dll</HintPath>
      <Private>False</Private>
    </Reference>
     <Reference Include="System.Net.Http">
      <HintPath>$(ProjectDir)/addons/sheet_db/DLL/System.Net.Http.dll</HintPath>
      <Private>False</Private>
    </Reference>
```
* Go to Godot > Project > Project Settings > Plugin > Set SheetDB to Active
