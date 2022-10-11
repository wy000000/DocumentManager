using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DocumentManager
{
	class lineScript_class
	{
		string script = null;
		int lineID = 0;
		internal int dirLevel = 0;
		internal string entryType = folder_class.folderType;
		//string newName = "";
		//string soureName = "";
		internal string FormattedNewName = "";
		internal string showingFormattedName = "";
		//string inputArgumentString = "";
		string[] inputArguments = null;
		string[] scriptMeta = null;
		internal string[] allArguments = null;
		internal string path = null;
		//string parentPath = null;

		internal lineScript_class(string scriptStr, string inputArgStr, int lineId, lineScript_class lastLineScript,
			int incrementalID = 1)
		{
			script = scriptStr;
			if (script != null && script[0] != '-')
			{
				lineID = lineId;
				scriptMeta = scriptStr.Split(':');
				if (scriptMeta.Length != 4)
					throw new scriptException("line " + lineID + ", 一行语句必须有四个域");
				dirLevel = int.Parse(scriptMeta[0]);
				if (dirLevel < 1)
					throw new scriptException("line " + lineID + ", 目录级别必须大于等于1");
				if (!(scriptMeta[1] == folder_class.folderType | scriptMeta[1] == folder_class.fileType))
					throw new scriptException("line " + lineID + ", 第二个域只能是d或f");
				entryType = scriptMeta[1];
				if (lastLineScript != null)
				{
					if (entryType == folder_class.folderType && dirLevel > lastLineScript.dirLevel + 1)
						throw new scriptException("line " + lineID + ", 目录级别不对，无父目录");
					if (entryType == folder_class.fileType && dirLevel > lastLineScript.dirLevel)
						throw new scriptException("line " + lineID + ", 目录级别不对，无父目录");
				}
				//inputArgumentString = inputArgStr;
				inputArguments = inputArgStr.Split('|');
				allArguments = new string[inputArguments.Length + 2];
				allArguments[0] = incrementalID.ToString();
				Array.Copy(inputArguments, 0, allArguments, 1, inputArguments.Length);
				//allArguments[inputArguments.Length + 1] = selfID.ToString();
				buildFormatedName();
			}
		}
		internal string buildFormatedName()
		{
			if (scriptMeta != null)
			{
				FormattedNewName = string.Format(scriptMeta[2], allArguments);
				string s = "";
				for (int j = 1; j < dirLevel; j++)
					s += "\t";
				showingFormattedName = s + FormattedNewName;
			}
			return (FormattedNewName);
		}

		List<string> getSourceFiles(string sourcePath, SearchOption searchOption = SearchOption.AllDirectories)
		{
			List<string> filePaths = null;
			if (sourcePath == null || sourcePath == "" || !Directory.Exists(sourcePath))
			{
				throw new ArgumentException("源路径错误！");
			}
			if (scriptMeta != null)
			{
				string searchPattern = scriptMeta[3];
				filePaths = new List<string>();
				if (searchPattern != null)
				{
					string[] subPatterns = scriptMeta[3].Split('|');
					foreach (string subPattern in subPatterns)
					{
						string[] files = Directory.GetFiles(sourcePath, subPattern, searchOption);
						List<string> subList = files.ToList();
						filePaths.AddRange(subList);
						//filePaths.Concat(files);
					}
				}
			}

			return filePaths;
		}
		internal int copyFiles(string sourcePath,
			bool overWrite = true, SearchOption searchOption = SearchOption.AllDirectories)
		{
			if (path == null || path == "")
			{
				throw new ArgumentException("目标路径错误");
			}
			if (entryType == folder_class.folderType)
			{
				Directory.CreateDirectory(path);
			}
			List<string> sourceFiles = getSourceFiles(sourcePath, searchOption);
			int copiedFileCount = 0;
			if (sourceFiles != null)
			{
				foreach (string sourceFile in sourceFiles)
				{
					string dp = path;
					if (entryType == folder_class.folderType)
					{
						dp = Path.Combine(path, Path.GetFileName(sourceFile));
					}
					if (overWrite || (!overWrite && !File.Exists(dp)))
					{
						File.Copy(sourceFile, dp, overWrite);
						copiedFileCount++;
					}
				}
			}
			return (copiedFileCount);
		}

	}

	class scriptException : System.Exception
	{
		internal scriptException(string message) : base(message) { }
	}

}
