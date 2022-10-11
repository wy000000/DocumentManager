using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DocumentManager
{
	class folder_class
	{
		internal const string folderType = "d";
		internal const string fileType = "f";

		internal string name = "";
		string path = null;
		string parentPath = null;
		int dirLevel = 0;
		//int parentDirLevel = 0;
		string entryType = null;
		int selfIncrementalID = 0;
		lineScript_class LineScript = null;
		internal List<folder_class> subFolders = new List<folder_class>();
		internal List<folder_class> files = new List<folder_class>();
		folder_class parentFolder = null;

		//folder_class() { }
		internal folder_class(string parentPathStr, lineScript_class lScript, int selfIncrmtalID, folder_class parentDir)
		{
			LineScript = lScript;
			entryType = LineScript.entryType;
			dirLevel = LineScript.dirLevel;
			selfIncrementalID = selfIncrmtalID;
			//pointer++;
			LineScript.allArguments[LineScript.allArguments.Length - 1] = selfIncrementalID.ToString();
			LineScript.buildFormatedName();
			name = LineScript.FormattedNewName;
			parentPath = parentPathStr;
			path = Path.Combine(parentPath, name);
			parentFolder = parentDir;
			LineScript.path = path;
			checkSameName();
		}

		bool checkSameName()
		{
			if (parentFolder != null)
			{
				List<folder_class> parentFList = entryType == folderType ? parentFolder.subFolders : parentFolder.files;
				foreach (folder_class fld in parentFList)
				{
					if (name == fld.name)
					{
						throw new scriptException("重名: " + name);
					}
				}
			}
			return (true);
		}
		internal void createSubFolder(List<lineScript_class> scriptList, ref int pointer)
		{
			bool findSubEntry = true;
			while (findSubEntry && pointer < scriptList.Count)
			{
				findSubEntry = false;
				lineScript_class nextScript = scriptList[pointer];
				if (nextScript.entryType == folderType && dirLevel == nextScript.dirLevel - 1)
				{
					folder_class subFolder = new folder_class(path, nextScript, subFolders.Count + 1, this);
					subFolders.Add(subFolder);
					pointer++;
					subFolder.createSubFolder(scriptList, ref pointer);
					findSubEntry = true;
				}
				if (pointer < scriptList.Count
					&& nextScript.entryType == fileType && dirLevel == nextScript.dirLevel - 1)
				{
					folder_class file = new folder_class(path, nextScript, files.Count + 1, this);
					files.Add(file);
					//file.createSubFolder(scriptList, ref pointer);
					pointer++;
					findSubEntry = true;
				}
			}
		}

	}
}
