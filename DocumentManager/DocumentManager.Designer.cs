
namespace DocumentManager
{
	partial class DocumentManager
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentManager));
			this.button_createFolders = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_inputArguments = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_sourceDocPath = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog_sourceDocDic = new System.Windows.Forms.FolderBrowserDialog();
			this.button_browser_sourceDic = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_DestDicPath = new System.Windows.Forms.TextBox();
			this.button_browser_DestDic = new System.Windows.Forms.Button();
			this.folderBrowserDialog_DestRootDic = new System.Windows.Forms.FolderBrowserDialog();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.numericUpDown_fileNo = new System.Windows.Forms.NumericUpDown();
			this.button_outDirectories = new System.Windows.Forms.Button();
			this.textBox_directories = new System.Windows.Forms.TextBox();
			this.button_saveConf = new System.Windows.Forms.Button();
			this.button_readConf = new System.Windows.Forms.Button();
			this.textBox_script = new System.Windows.Forms.TextBox();
			this.textBox_result = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.checkBox_IncludeFile = new System.Windows.Forms.CheckBox();
			this.numericUpDown_DirectoryMaxDeep = new System.Windows.Forms.NumericUpDown();
			this.textBox_configPath = new System.Windows.Forms.TextBox();
			this.checkBox_overWrite = new System.Windows.Forms.CheckBox();
			this.checkBox_compile = new System.Windows.Forms.CheckBox();
			this.checkBox_searchSubDir = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_fileNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DirectoryMaxDeep)).BeginInit();
			this.SuspendLayout();
			// 
			// button_createFolders
			// 
			this.button_createFolders.Location = new System.Drawing.Point(12, 682);
			this.button_createFolders.Name = "button_createFolders";
			this.button_createFolders.Size = new System.Drawing.Size(164, 27);
			this.button_createFolders.TabIndex = 0;
			this.button_createFolders.Text = "执行分类复制";
			this.button_createFolders.UseVisualStyleBackColor = true;
			this.button_createFolders.Click += new System.EventHandler(this.button_createFolders_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 178);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 33);
			this.label1.TabIndex = 1;
			this.label1.Text = "输入参数组\r\n以\"|\"分隔";
			// 
			// textBox_inputArguments
			// 
			this.textBox_inputArguments.Location = new System.Drawing.Point(92, 178);
			this.textBox_inputArguments.Multiline = true;
			this.textBox_inputArguments.Name = "textBox_inputArguments";
			this.textBox_inputArguments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox_inputArguments.Size = new System.Drawing.Size(533, 74);
			this.textBox_inputArguments.TabIndex = 2;
			this.textBox_inputArguments.Text = "参数1|参数2";
			this.textBox_inputArguments.TextChanged += new System.EventHandler(this.textBox_courseName_TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 33);
			this.label2.TabIndex = 3;
			this.label2.Text = "源材料文件夹";
			// 
			// textBox_sourceDocPath
			// 
			this.textBox_sourceDocPath.Location = new System.Drawing.Point(92, 114);
			this.textBox_sourceDocPath.Multiline = true;
			this.textBox_sourceDocPath.Name = "textBox_sourceDocPath";
			this.textBox_sourceDocPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox_sourceDocPath.Size = new System.Drawing.Size(533, 58);
			this.textBox_sourceDocPath.TabIndex = 4;
			// 
			// button_browser_sourceDic
			// 
			this.button_browser_sourceDic.Location = new System.Drawing.Point(631, 114);
			this.button_browser_sourceDic.Name = "button_browser_sourceDic";
			this.button_browser_sourceDic.Size = new System.Drawing.Size(75, 33);
			this.button_browser_sourceDic.TabIndex = 5;
			this.button_browser_sourceDic.Text = "浏览";
			this.button_browser_sourceDic.UseVisualStyleBackColor = true;
			this.button_browser_sourceDic.Click += new System.EventHandler(this.button_browser_sourceDic_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.ForeColor = System.Drawing.Color.ForestGreen;
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(634, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "源文件命名不规范，程序不能准确分类文件，请手动确认。";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(10, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 48);
			this.label4.TabIndex = 9;
			this.label4.Text = "归档分类材料根文件夹";
			// 
			// textBox_DestDicPath
			// 
			this.textBox_DestDicPath.Location = new System.Drawing.Point(92, 49);
			this.textBox_DestDicPath.Multiline = true;
			this.textBox_DestDicPath.Name = "textBox_DestDicPath";
			this.textBox_DestDicPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox_DestDicPath.Size = new System.Drawing.Size(533, 59);
			this.textBox_DestDicPath.TabIndex = 10;
			this.textBox_DestDicPath.TextChanged += new System.EventHandler(this.textBox_DestDicPath_TextChanged);
			// 
			// button_browser_DestDic
			// 
			this.button_browser_DestDic.Location = new System.Drawing.Point(631, 49);
			this.button_browser_DestDic.Name = "button_browser_DestDic";
			this.button_browser_DestDic.Size = new System.Drawing.Size(75, 34);
			this.button_browser_DestDic.TabIndex = 11;
			this.button_browser_DestDic.Text = "浏览";
			this.button_browser_DestDic.UseVisualStyleBackColor = true;
			this.button_browser_DestDic.Click += new System.EventHandler(this.button_browser_DestDic_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 262);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(592, 15);
			this.label5.TabIndex = 12;
			this.label5.Text = "目录文件名称脚本    {0}为自增编号，{i}为上述各参数。{m+1}为各级目录自增参数。";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(479, 285);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 15);
			this.label8.TabIndex = 14;
			this.label8.Text = "编号";
			// 
			// numericUpDown_fileNo
			// 
			this.numericUpDown_fileNo.Location = new System.Drawing.Point(522, 279);
			this.numericUpDown_fileNo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numericUpDown_fileNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_fileNo.Name = "numericUpDown_fileNo";
			this.numericUpDown_fileNo.Size = new System.Drawing.Size(50, 25);
			this.numericUpDown_fileNo.TabIndex = 15;
			this.numericUpDown_fileNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_fileNo.ValueChanged += new System.EventHandler(this.numericUpDown_fileNo_ValueChanged);
			// 
			// button_outDirectories
			// 
			this.button_outDirectories.Location = new System.Drawing.Point(712, 16);
			this.button_outDirectories.Name = "button_outDirectories";
			this.button_outDirectories.Size = new System.Drawing.Size(87, 27);
			this.button_outDirectories.TabIndex = 0;
			this.button_outDirectories.Text = "输出目录";
			this.button_outDirectories.UseVisualStyleBackColor = true;
			this.button_outDirectories.Click += new System.EventHandler(this.button_outDirectories_Click);
			// 
			// textBox_directories
			// 
			this.textBox_directories.Location = new System.Drawing.Point(712, 46);
			this.textBox_directories.Multiline = true;
			this.textBox_directories.Name = "textBox_directories";
			this.textBox_directories.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox_directories.Size = new System.Drawing.Size(403, 206);
			this.textBox_directories.TabIndex = 18;
			this.textBox_directories.Text = "输出目录";
			this.textBox_directories.WordWrap = false;
			// 
			// button_saveConf
			// 
			this.button_saveConf.Location = new System.Drawing.Point(191, 679);
			this.button_saveConf.Name = "button_saveConf";
			this.button_saveConf.Size = new System.Drawing.Size(75, 27);
			this.button_saveConf.TabIndex = 21;
			this.button_saveConf.Text = "存储配置";
			this.button_saveConf.UseVisualStyleBackColor = true;
			this.button_saveConf.Click += new System.EventHandler(this.button_saveConf_Click);
			// 
			// button_readConf
			// 
			this.button_readConf.Location = new System.Drawing.Point(191, 707);
			this.button_readConf.Name = "button_readConf";
			this.button_readConf.Size = new System.Drawing.Size(75, 27);
			this.button_readConf.TabIndex = 21;
			this.button_readConf.Text = "读取配置";
			this.button_readConf.UseVisualStyleBackColor = true;
			this.button_readConf.Click += new System.EventHandler(this.button_readConf_Click);
			// 
			// textBox_script
			// 
			this.textBox_script.Location = new System.Drawing.Point(3, 307);
			this.textBox_script.Multiline = true;
			this.textBox_script.Name = "textBox_script";
			this.textBox_script.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox_script.Size = new System.Drawing.Size(703, 369);
			this.textBox_script.TabIndex = 22;
			this.textBox_script.Text = resources.GetString("textBox_script.Text");
			this.textBox_script.WordWrap = false;
			this.textBox_script.TextChanged += new System.EventHandler(this.textBox_script_TextChanged);
			// 
			// textBox_result
			// 
			this.textBox_result.BackColor = System.Drawing.SystemColors.Control;
			this.textBox_result.Location = new System.Drawing.Point(712, 307);
			this.textBox_result.Multiline = true;
			this.textBox_result.Name = "textBox_result";
			this.textBox_result.ReadOnly = true;
			this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox_result.Size = new System.Drawing.Size(403, 369);
			this.textBox_result.TabIndex = 23;
			this.textBox_result.WordWrap = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 289);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(175, 15);
			this.label7.TabIndex = 25;
			this.label7.Text = "目录级别:f/d:新名:源名";
			// 
			// checkBox_IncludeFile
			// 
			this.checkBox_IncludeFile.AutoSize = true;
			this.checkBox_IncludeFile.Location = new System.Drawing.Point(805, 24);
			this.checkBox_IncludeFile.Name = "checkBox_IncludeFile";
			this.checkBox_IncludeFile.Size = new System.Drawing.Size(165, 19);
			this.checkBox_IncludeFile.TabIndex = 26;
			this.checkBox_IncludeFile.Text = "包含文件  目录层数";
			this.checkBox_IncludeFile.UseVisualStyleBackColor = true;
			// 
			// numericUpDown_DirectoryMaxDeep
			// 
			this.numericUpDown_DirectoryMaxDeep.Location = new System.Drawing.Point(976, 16);
			this.numericUpDown_DirectoryMaxDeep.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown_DirectoryMaxDeep.Name = "numericUpDown_DirectoryMaxDeep";
			this.numericUpDown_DirectoryMaxDeep.Size = new System.Drawing.Size(64, 25);
			this.numericUpDown_DirectoryMaxDeep.TabIndex = 27;
			this.numericUpDown_DirectoryMaxDeep.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// textBox_configPath
			// 
			this.textBox_configPath.Location = new System.Drawing.Point(272, 682);
			this.textBox_configPath.Multiline = true;
			this.textBox_configPath.Name = "textBox_configPath";
			this.textBox_configPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBox_configPath.Size = new System.Drawing.Size(843, 52);
			this.textBox_configPath.TabIndex = 28;
			this.textBox_configPath.WordWrap = false;
			// 
			// checkBox_overWrite
			// 
			this.checkBox_overWrite.AutoSize = true;
			this.checkBox_overWrite.Location = new System.Drawing.Point(33, 715);
			this.checkBox_overWrite.Name = "checkBox_overWrite";
			this.checkBox_overWrite.Size = new System.Drawing.Size(119, 19);
			this.checkBox_overWrite.TabIndex = 29;
			this.checkBox_overWrite.Text = "覆盖同名文件";
			this.checkBox_overWrite.UseVisualStyleBackColor = true;
			// 
			// checkBox_compile
			// 
			this.checkBox_compile.AutoSize = true;
			this.checkBox_compile.Checked = true;
			this.checkBox_compile.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_compile.Location = new System.Drawing.Point(617, 285);
			this.checkBox_compile.Name = "checkBox_compile";
			this.checkBox_compile.Size = new System.Drawing.Size(165, 19);
			this.checkBox_compile.TabIndex = 30;
			this.checkBox_compile.Text = "动态编译  编译信息";
			this.checkBox_compile.UseVisualStyleBackColor = true;
			// 
			// checkBox_searchSubDir
			// 
			this.checkBox_searchSubDir.AutoSize = true;
			this.checkBox_searchSubDir.Checked = true;
			this.checkBox_searchSubDir.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_searchSubDir.Location = new System.Drawing.Point(203, 285);
			this.checkBox_searchSubDir.Name = "checkBox_searchSubDir";
			this.checkBox_searchSubDir.Size = new System.Drawing.Size(119, 19);
			this.checkBox_searchSubDir.TabIndex = 31;
			this.checkBox_searchSubDir.Text = "搜索子文件夹";
			this.checkBox_searchSubDir.UseVisualStyleBackColor = true;
			// 
			// DocumentManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1127, 736);
			this.Controls.Add(this.checkBox_searchSubDir);
			this.Controls.Add(this.checkBox_compile);
			this.Controls.Add(this.checkBox_overWrite);
			this.Controls.Add(this.textBox_configPath);
			this.Controls.Add(this.numericUpDown_DirectoryMaxDeep);
			this.Controls.Add(this.checkBox_IncludeFile);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox_result);
			this.Controls.Add(this.textBox_script);
			this.Controls.Add(this.button_readConf);
			this.Controls.Add(this.button_saveConf);
			this.Controls.Add(this.textBox_directories);
			this.Controls.Add(this.numericUpDown_fileNo);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button_browser_DestDic);
			this.Controls.Add(this.textBox_DestDicPath);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button_browser_sourceDic);
			this.Controls.Add(this.textBox_sourceDocPath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_inputArguments);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_outDirectories);
			this.Controls.Add(this.button_createFolders);
			this.MaximizeBox = false;
			this.Name = "DocumentManager";
			this.Text = "DocumentManager";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_fileNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DirectoryMaxDeep)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_createFolders;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_inputArguments;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_sourceDocPath;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_sourceDocDic;
		private System.Windows.Forms.Button button_browser_sourceDic;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_DestDicPath;
		private System.Windows.Forms.Button button_browser_DestDic;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_DestRootDic;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown numericUpDown_fileNo;
		private System.Windows.Forms.Button button_outDirectories;
		private System.Windows.Forms.TextBox textBox_directories;
		private System.Windows.Forms.Button button_saveConf;
		private System.Windows.Forms.Button button_readConf;
		private System.Windows.Forms.TextBox textBox_script;
		private System.Windows.Forms.TextBox textBox_result;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox checkBox_IncludeFile;
		private System.Windows.Forms.NumericUpDown numericUpDown_DirectoryMaxDeep;
		private System.Windows.Forms.TextBox textBox_configPath;
		private System.Windows.Forms.CheckBox checkBox_overWrite;
		private System.Windows.Forms.CheckBox checkBox_compile;
		private System.Windows.Forms.CheckBox checkBox_searchSubDir;
	}
}