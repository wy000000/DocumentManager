using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace DocumentManager
{
    class config_class
	{
        public  string sourcePath = "";
        public  string destPath = "";
        public  string inputArguments = "";
        //public  bool checkBox_regex = false;
        public  bool checkBox_IncludeFile = false;
        public  int numericUpDown_DirectoryMaxDeep = 2;
        public  string textBox_script = "";
        public bool checkBox_overWrite = false;
        public bool checkBox_compile = false;
        public bool checkBox_searchSubDir = true;
        public int numericUpDown_fileNo = 1;

        [JsonConstructor]
        public config_class(string sPath, string dPath, string inArgs, bool checkIncludeFile,
            int numUpDownDirMaxDeep, string script, bool overWrite, bool dynamicCompile,
            bool searchSubDir, int fileNo)
		{
            sourcePath = sPath;
            destPath = dPath;
            inputArguments = inArgs;
            checkBox_IncludeFile = checkIncludeFile;
            //checkBox_regex = checkReg;
            numericUpDown_DirectoryMaxDeep = numUpDownDirMaxDeep;
            textBox_script = script;
            checkBox_overWrite = overWrite;
            checkBox_compile = dynamicCompile;
            checkBox_searchSubDir = searchSubDir;
            numericUpDown_fileNo = fileNo;
		}


    }
}
