using Godot;
using System;

namespace Models
{

	// MODELS EXAMPLE

	public struct UserData {
		UserData(string ID,int[] levels) {
			this.ID = ID;
			this.levels = levels;
		}

		string ID {get; set;}
		int[] levels {get; set;}
	}

	// public struct LevelData {
	// 	 LevelData(string authorID,string hash,string md5,string ID=null) {
	// 		this.ID = (ID==null)?defaultID:ID;
	// 		this.authorID = authorID;
	// 		this.hash = hash;
	// 		this.md5 = md5;
	// 	}

	// 	string ID {get; set;}
	// 	string authorID {get; set;}
	// 	string hash {get; set;}
	// 	string md5 {get; set;}

	// 	private const string defaultID = "INDIRECT(ADDRESS(ROW()-1,COLUMN()))+1";
	// }


	// //RELIC IDS: 0 - platinum / 1 - gold / 2 - saphire
	// public struct TrialData {
	// 	TrialData(int levelID,byte relic,string authorID, float time,string ID=null) {
	// 		this.levelID = levelID;
	// 		this.relic = relic;
	// 		this.authorID = authorID;
	// 		this.time = time;
	// 		this.ID = (ID==null)?defaultID:ID;

	// 	}

	// 	int levelID {get;set;}
	// 	byte relic {get;set;}
	// 	string authorID {get;set;}
	// 	float time {get;set;}
	// 	string ID {get;set;}
	// 	private const string defaultID = "INDIRECT(ADDRESS(ROW()-1,COLUMN()))+1";

	// }


}
