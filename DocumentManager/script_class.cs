using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DocumentManager
{
	class script_class
	{
		internal string scripts = "";
		List<lineScript_class> scriptList = null;
		//internal script_class(string scriptsText)
		//{
		//	scripts= scriptsText;
		//}

		internal bool compile(string inputArgStr, int incrementalID, string rootPath, out string compileInfo)
		{
			scriptList = new List<lineScript_class>();
			int lineID = 0;
			compileInfo = "";
			folder_class folder = null;
			try
			{
				using (StringReader sr = new StringReader(scripts))
				{
					lineScript_class lineScript0 = new lineScript_class(null, "", 0, null);
					lineScript0.dirLevel = 0;
					lineScript0.allArguments = new string[2];// { "1", "1" };
															 //lineScript0.path = rootPath;
					scriptList.Add(lineScript0);
					string script = sr.ReadLine();
					while (script != null)
					{
						lineID++;
						script = script.Trim();
						if (script != "" && script[0] != '-')
						{
							lineScript_class LineScript = new lineScript_class(script, inputArgStr, lineID,
								scriptList.Last(), incrementalID);
							scriptList.Add(LineScript);
							int pointer = 1;
							folder = new folder_class(rootPath, scriptList[0], 1, null);
							folder.createSubFolder(scriptList, ref pointer);
							compileInfo += LineScript.showingFormattedName;
						}
						compileInfo += "\r\n";
						script = sr.ReadLine();
					}
				}
				return (true);
			}
			catch (System.FormatException e)
			{
				compileInfo += e.Message + "\r\n";
			}
			catch (scriptException e)
			{
				compileInfo += e.Message + "\r\n";
			}
			//catch (IndexOutOfRangeException e)
			//{
			//	compileInfo += e.Message + "\r\n";
			//}
			//catch(NullReferenceException e)
			//{
			//	compileInfo += e.Message + "\r\n";
			//}
			//catch (Exception e)
			//{
			//	compileInfo += e.Message + "\r\n";
			//	return (false);
			//}
			return (false);
		}

		internal int copyfile(string sourcePath, out string copyInfo, bool overWrite, SearchOption searchOption)
		{
			int copiedFileCount = 0;
			copyInfo = "";
			try
			{
				foreach (lineScript_class lineScript in scriptList)
				{
					copiedFileCount += lineScript.copyFiles(sourcePath, overWrite, searchOption);
				}
			}
			catch(NotSupportedException e)
			{
				copyInfo += e.Message + "\r\n";
			}
			catch(ArgumentException e)
			{
				copyInfo += e.Message + "\r\n";
			}
			return (copiedFileCount);
		}
	}

}
