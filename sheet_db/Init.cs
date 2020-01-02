

#if TOOLS
using Godot;
using System;
using Sheets;


[Tool]
public class Init : EditorPlugin
{
	public override void _EnterTree()
	{
		
		GD.Print(SheetDB.apiUrl);
		GD.Print("if you see the api_url above database is configured successfully");
		if (SheetDB.apiUrl != "") GD.Print("To use the database just call Sheets.SheetDB from anywhere"); 
	}
}
#endif
