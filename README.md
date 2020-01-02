# Godot-SheetDB
Google sheets as database for Godot 3.2 C#

# Installation

## Step 1
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

## Step 2
* Go to https://sheet.best/dashboard/sheets - if u dont have an account, create one using your google account where the sheet is located
* Click **New Sheet API**
* Type the Name and then the **SHEET URL**
* Now click on the gear icon above the view api button
* Go to security > enable api key > copy your api key
* click save

## Step 3
* If you take a look at the *addons/sheet_db* folder you will see a file called **database.cfg**
* api_key = "YOUR_API_KEY_HERE"
* api_url =
    * go to https://sheet.best/dashboard/sheets click buton view api and copy the url from there
* tabs = 
    * here you'll place the tab names from the bottom of your google sheets
    * for issue avoiding use snake_case i.e(leaderboard,level_data,user_data)

## Step 4
* Go to Godot > Project > Project Settings > Plugin > Set SheetDB to Active
