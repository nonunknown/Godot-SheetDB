# Godot-SheetDB
Google sheets as database for Godot 3.2 C#
- version: 0.1.0

### Wiki - https://github.com/nonunknown/Godot-SheetDB/wiki
### Notes:
    - At the Custom_Model.cs file you can see how to create your models
    - At the SheetDB.cs there is a comment section showing how to POST data
    - The Compressor.cs file is very **important** if you want to upload *.tscn,*.tres files to the sheets database
    - Any question/suggestion send to issues page
    - Any improvement is welcome
    
### TODO:
- [x] Base for public using
- [ ] POST,PUT,DELETE system (if you know c# well you can do this already, i mean for sake of simplicity)
- [ ] Complete Tutorials (Upload *tscn *tres / MD5 verification / showing the power of this ADDON)
- [ ] API Docs

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
* And in the compile section
```
    <Compile Include="addons\sheet_db\SheetDB.cs" />
    <Compile Include="addons\sheet_db\Compressor.cs" />
    <Compile Include="addons\sheet_db\Custom_Model.cs" />
    <Compile Include="addons\sheet_db\Init.cs" />
```

## Step 2
* Go to https://sheet.best/dashboard/sheets - if u dont have an account, create one using your google account where the sheet is located
* Click **New Sheet API**
* Type the Name and then place the **GOOGLE SHEET URL**
* Maybe you have to make the sheet public or share link

## Step 3
* If you take a look at the *addons/sheet_db/SheetDB.cs* folder you will see a variable called api_url
* go to Sheetbest dashboard and click view api and past this url there


## Step 4
* Go to Godot > Project > Project Settings > Plugin > Set SheetDB to Active
* if everything goes well the output will be this:
 ```
 Starting Sheets Db...
https://sheet.best/api/sheets/744ccc66/
if you see the api_url above database is configured successfully
To use the database just call Sheets.SheetDB from anywhere
  ```

# Getting Started

## Step 1
* Create a node
* Insert a csharp script
* on ready type:
 ```csharp
    using Sheets;
	public override void _Ready()
	{
		string result = "";
		System.Threading.Thread t = new System.Threading.Thread(async ()=> {
			result = await SheetDB.GetFullApi();
			GD.Print("done: "+result);
			

		});
		t.Start();
		
	}
```

