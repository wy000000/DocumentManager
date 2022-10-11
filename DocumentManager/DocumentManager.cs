using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace DocumentManager
{
    public partial class DocumentManager : Form
    {
        script_class scripts = new script_class();
        public DocumentManager()
        {
            InitializeComponent();
        }

        private void button_createFolders_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            int copiedFilesCount = 0;
            string copyInfo = "";
            if (!compileScript())
            {
                MessageBox.Show("编译错误！请查看编译信息。", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                copiedFilesCount = scripts.copyfile(textBox_sourceDocPath.Text, out copyInfo,
                    checkBox_overWrite.Checked,
                    checkBox_searchSubDir.Checked == true
                    ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                if (copyInfo != "")
                {
                    MessageBox.Show(copyInfo, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("文件复制完成", "提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numericUpDown_fileNo.Value++;
                }
            }
			//MessageBox.Show(copiedFilesCount + "个文件被复制", "提示",
			//    MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.Enabled = true;
        }

        private void button_browser_sourceDic_Click(object sender, EventArgs e)
        {
            folderBrowserDialog_sourceDocDic.SelectedPath = textBox_sourceDocPath.Text;
            folderBrowserDialog_sourceDocDic.ShowDialog();
            textBox_sourceDocPath.Text = folderBrowserDialog_sourceDocDic.SelectedPath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			textBox_configPath.Text
				= Path.Combine(System.Environment.CurrentDirectory, "config.json");
            if (checkBox_compile.Checked)
            {
                compileScript();
            }
        }

        private void button_browser_DestDic_Click(object sender, EventArgs e)
        {
            folderBrowserDialog_DestRootDic.SelectedPath = textBox_DestDicPath.Text;
            folderBrowserDialog_DestRootDic.ShowDialog();
            textBox_DestDicPath.Text = folderBrowserDialog_DestRootDic.SelectedPath;
        }

        private void textBox_courseName_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_compile.Checked)
            {
                compileScript();
            }
        }
        private void numericUpDown_fileNo_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox_compile.Checked)
            {
                compileScript();
            }
        }


        private void textBox_DestDicPath_TextChanged(object sender, EventArgs e)
        {
            //course_class.rootPath = textBox_DestDicPath.Text;
            textBox_directories.Text = "";
            //numericUpDown_fileNo.Value = findMaxNo() + 1;
        }
        //int findMaxNo()
        //{
        //    //try
        //    //{
        //    //    if (course_class.rootPath != "")
        //    //    {
        //    //        string[] Dts = Directory.GetDirectories(course_class.rootPath);
        //    //        int maxNo = 0;
        //    //        foreach (string dt in Dts)
        //    //        {
        //    //            string name = Path.GetFileName(dt);
        //    //            name = name.Remove(0, name.IndexOf(".") + 1);
        //    //            int fileNo = int.Parse(name.Remove(name.IndexOf("."), name.Length - name.IndexOf(".")));
        //    //            if (fileNo > maxNo)
        //    //                maxNo = fileNo;
        //    //        }
        //    //        return (maxNo);
        //    //    }
        //    //    return (1);
        //    //}
        //    //catch (Exception e)
        //    //{
        //    //    processinfo_class.printinfo("failed! cannot find course number! " + e.ToString(), false);
        //    //}
        //    //return (1);
        //}

        private void button_outDirectories_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                textBox_directories.Text = "";
                outputDirectory(textBox_DestDicPath.Text, 1);
                this.Enabled = true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Enabled = true;
            }
        }

        void outputDirectory(string directoryPath, int directoryDeep)
        {
            if (directoryDeep <= numericUpDown_DirectoryMaxDeep.Value)
            {
				//int dirDeep = directoryDeep++;
				string[] dcts = Directory.GetDirectories(directoryPath);
                foreach (string Dpath in dcts)
                {
                    string filename = Path.GetFileName(Dpath);
                    string t = "";
                    for (int i = 1; i < directoryDeep; i++)
                    { t += "\t"; }
                    textBox_directories.Text += t + filename + "\r\n";
                    outputDirectory(Dpath, directoryDeep+1);
                }
                if (checkBox_IncludeFile.Checked)
                {
                    string[] files = Directory.GetFiles(directoryPath);
                    foreach (string fPath in files)
                    {
                        string filename = Path.GetFileName(fPath);
                        string t = "";
                        for (int i = 1; i < directoryDeep; i++)
                        { t += "\t"; }
                        textBox_directories.Text += t + filename + "\r\n";
                    }
                }
            }
        }

        //private void button_standardCopy_Click(object sender, EventArgs e)
        //{
        //    this.Enabled = false;
        //    try
        //    {
        //        this.Enabled = false;
        //        string[] sourceDircs = Directory.GetDirectories(textBox_sourceDocPath.Text);
        //        foreach (string sourceDirc in sourceDircs)
        //        {
        //            string foldername = Path.GetFileName(sourceDirc);
        //            string courseName = foldername.Remove(0, foldername.LastIndexOf(".") + 1);
        //            textBox_courseName.Text = courseName;
        //            //course_class course = createFoldersForACourse();
        //            course.standardCopyFile(sourceDirc);
        //            numericUpDown_fileNo.Value++;
        //        }
        //        this.Enabled = true;
        //    }
        //    catch (Exception er)
        //    {
        //        processinfo_class.printinfo("failed standard copy! " + er.ToString(), true);
        //        this.Enabled = true;
        //    }
        //    this.Enabled = true;
        //}

        private void button_saveConf_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                config_class configClass = new config_class(
                    textBox_sourceDocPath.Text,
                    textBox_DestDicPath.Text,
                    textBox_inputArguments.Text,
                    //checkBox_regex.Checked,
                    checkBox_IncludeFile.Checked,
                    (int)numericUpDown_DirectoryMaxDeep.Value,
                    textBox_script.Text,
                    checkBox_overWrite.Checked,
                    checkBox_compile.Checked,
                    checkBox_searchSubDir.Checked,
                    (int)numericUpDown_fileNo.Value);
                using (StreamWriter sw = new StreamWriter(textBox_configPath.Text))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    new JsonSerializer().Serialize(writer, configClass);
                }
                this.Enabled = true;
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
            }
        }

        private void button_readConf_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                //JsonTextReader reader = new JsonTextReader(new StringReader(json));

                using (StreamReader sr = File.OpenText(textBox_configPath.Text))
                {
                    //string configStr = sr.ReadToEnd();
                    //config_class configClass = JsonConvert.DeserializeObject<config_class>(configStr);
                    JsonSerializer serializer = new JsonSerializer();
                    config_class configClass = (config_class)serializer.Deserialize(sr, typeof(config_class));
                    textBox_sourceDocPath.Text = configClass.sourcePath;
                    textBox_DestDicPath.Text = configClass.destPath;
                    textBox_inputArguments.Text = configClass.inputArguments;
                    checkBox_IncludeFile.Checked = configClass.checkBox_IncludeFile;
                    numericUpDown_DirectoryMaxDeep.Value = configClass.numericUpDown_DirectoryMaxDeep;
                    //checkBox_regex.Checked = configClass.checkBox_regex;
                    textBox_script.Text = configClass.textBox_script;
                    checkBox_overWrite.Checked = configClass.checkBox_overWrite;
                    checkBox_compile.Checked = configClass.checkBox_compile;
                    checkBox_searchSubDir.Checked = configClass.checkBox_searchSubDir;
                    numericUpDown_fileNo.Value = configClass.numericUpDown_fileNo;
                }
                this.Enabled = true;
            }
            catch(Exception ep)
			{
                MessageBox.Show(ep.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
			}
        }

        private void textBox_script_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_compile.Checked)
            {
                compileScript();
            }
        }
        bool compileScript()
        {
            scripts.scripts = textBox_script.Text;
            string compileInfo = null;
            bool compiled = scripts.compile(textBox_inputArguments.Text,
                (int)numericUpDown_fileNo.Value, textBox_DestDicPath.Text, out compileInfo);
            textBox_result.Text = compileInfo;
            return (compiled);
        }
	}
}
