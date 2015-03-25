namespace IconCreator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.svgPreview1 = new System.Windows.Forms.PictureBox();
            this.scaleLabel1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scaleFactor1 = new System.Windows.Forms.TrackBar();
            this.bgColorInd = new System.Windows.Forms.Button();
            this.selectBgColorBtn = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBox = new System.Windows.Forms.TextBox();
            this.transparentBg = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.w81_checkbox = new System.Windows.Forms.CheckBox();
            this.wp81_checkbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selectTxtColorBtn = new System.Windows.Forms.Button();
            this.txtColorInd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.appName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.scaleLabel2 = new System.Windows.Forms.Label();
            this.svgPreview2 = new System.Windows.Forms.PictureBox();
            this.scaleFactor2 = new System.Windows.Forms.TrackBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.svgPreview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleFactor1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgPreview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleFactor2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filePathBox
            // 
            this.filePathBox.Location = new System.Drawing.Point(87, 37);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.ReadOnly = true;
            this.filePathBox.Size = new System.Drawing.Size(425, 20);
            this.filePathBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Load SVG";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onBrowseFileClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // svgPreview1
            // 
            this.svgPreview1.BackColor = System.Drawing.SystemColors.Control;
            this.svgPreview1.Location = new System.Drawing.Point(28, 19);
            this.svgPreview1.MaximumSize = new System.Drawing.Size(128, 128);
            this.svgPreview1.Name = "svgPreview1";
            this.svgPreview1.Size = new System.Drawing.Size(128, 128);
            this.svgPreview1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.svgPreview1.TabIndex = 3;
            this.svgPreview1.TabStop = false;
            // 
            // scaleLabel1
            // 
            this.scaleLabel1.AutoSize = true;
            this.scaleLabel1.Location = new System.Drawing.Point(3, 158);
            this.scaleLabel1.Name = "scaleLabel1";
            this.scaleLabel1.Size = new System.Drawing.Size(69, 13);
            this.scaleLabel1.TabIndex = 4;
            this.scaleLabel1.Text = "Scale object:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Background color:";
            // 
            // scaleFactor1
            // 
            this.scaleFactor1.Location = new System.Drawing.Point(6, 174);
            this.scaleFactor1.Maximum = 100;
            this.scaleFactor1.Minimum = 50;
            this.scaleFactor1.Name = "scaleFactor1";
            this.scaleFactor1.Size = new System.Drawing.Size(164, 45);
            this.scaleFactor1.SmallChange = 5;
            this.scaleFactor1.TabIndex = 10;
            this.scaleFactor1.TickFrequency = 5;
            this.scaleFactor1.Value = 50;
            this.scaleFactor1.ValueChanged += new System.EventHandler(this.scale1ValueChanged);
            // 
            // bgColorInd
            // 
            this.bgColorInd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bgColorInd.Enabled = false;
            this.bgColorInd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgColorInd.Location = new System.Drawing.Point(6, 238);
            this.bgColorInd.Name = "bgColorInd";
            this.bgColorInd.Size = new System.Drawing.Size(75, 23);
            this.bgColorInd.TabIndex = 7;
            this.bgColorInd.UseVisualStyleBackColor = false;
            // 
            // selectBgColorBtn
            // 
            this.selectBgColorBtn.Location = new System.Drawing.Point(87, 238);
            this.selectBgColorBtn.Name = "selectBgColorBtn";
            this.selectBgColorBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBgColorBtn.TabIndex = 8;
            this.selectBgColorBtn.Text = "Choose";
            this.selectBgColorBtn.UseVisualStyleBackColor = true;
            this.selectBgColorBtn.Click += new System.EventHandler(this.chooseBgColor);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.onBrowseFolderClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Output path";
            // 
            // folderBox
            // 
            this.folderBox.Location = new System.Drawing.Point(87, 67);
            this.folderBox.Name = "folderBox";
            this.folderBox.ReadOnly = true;
            this.folderBox.Size = new System.Drawing.Size(425, 20);
            this.folderBox.TabIndex = 11;
            // 
            // transparentBg
            // 
            this.transparentBg.AutoSize = true;
            this.transparentBg.Location = new System.Drawing.Point(6, 267);
            this.transparentBg.Name = "transparentBg";
            this.transparentBg.Size = new System.Drawing.Size(143, 17);
            this.transparentBg.TabIndex = 14;
            this.transparentBg.Text = "Transparent background";
            this.transparentBg.UseVisualStyleBackColor = true;
            this.transparentBg.CheckedChanged += new System.EventHandler(this.changeBgTransparency);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.w81_checkbox);
            this.groupBox1.Controls.Add(this.wp81_checkbox);
            this.groupBox1.Location = new System.Drawing.Point(437, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 112);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Create icons";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.onCreateClick);
            // 
            // w81_checkbox
            // 
            this.w81_checkbox.AutoSize = true;
            this.w81_checkbox.Location = new System.Drawing.Point(7, 50);
            this.w81_checkbox.Name = "w81_checkbox";
            this.w81_checkbox.Size = new System.Drawing.Size(88, 17);
            this.w81_checkbox.TabIndex = 1;
            this.w81_checkbox.Text = "Windows 8.1";
            this.w81_checkbox.UseVisualStyleBackColor = true;
            // 
            // wp81_checkbox
            // 
            this.wp81_checkbox.AutoSize = true;
            this.wp81_checkbox.Location = new System.Drawing.Point(7, 27);
            this.wp81_checkbox.Name = "wp81_checkbox";
            this.wp81_checkbox.Size = new System.Drawing.Size(122, 17);
            this.wp81_checkbox.TabIndex = 0;
            this.wp81_checkbox.Text = "Windows Phone 8.1";
            this.wp81_checkbox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Text color:";
            // 
            // selectTxtColorBtn
            // 
            this.selectTxtColorBtn.Location = new System.Drawing.Point(90, 237);
            this.selectTxtColorBtn.Name = "selectTxtColorBtn";
            this.selectTxtColorBtn.Size = new System.Drawing.Size(75, 23);
            this.selectTxtColorBtn.TabIndex = 18;
            this.selectTxtColorBtn.Text = "Choose";
            this.selectTxtColorBtn.UseVisualStyleBackColor = true;
            this.selectTxtColorBtn.Click += new System.EventHandler(this.chooseTextColor);
            // 
            // txtColorInd
            // 
            this.txtColorInd.BackColor = System.Drawing.Color.White;
            this.txtColorInd.Enabled = false;
            this.txtColorInd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtColorInd.Location = new System.Drawing.Point(9, 237);
            this.txtColorInd.Name = "txtColorInd";
            this.txtColorInd.Size = new System.Drawing.Size(75, 23);
            this.txtColorInd.TabIndex = 17;
            this.txtColorInd.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Application name:";
            // 
            // appName
            // 
            this.appName.Location = new System.Drawing.Point(9, 287);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(164, 20);
            this.appName.TabIndex = 20;
            this.appName.TextChanged += new System.EventHandler(this.AppNameChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.svgPreview1);
            this.groupBox2.Controls.Add(this.scaleLabel1);
            this.groupBox2.Controls.Add(this.bgColorInd);
            this.groupBox2.Controls.Add(this.scaleFactor1);
            this.groupBox2.Controls.Add(this.transparentBg);
            this.groupBox2.Controls.Add(this.selectBgColorBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(24, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 331);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simple tiles";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.scaleLabel2);
            this.groupBox3.Controls.Add(this.svgPreview2);
            this.groupBox3.Controls.Add(this.scaleFactor2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.appName);
            this.groupBox3.Controls.Add(this.txtColorInd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.selectTxtColorBtn);
            this.groupBox3.Location = new System.Drawing.Point(225, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 331);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tile settings";
            // 
            // scaleLabel2
            // 
            this.scaleLabel2.AutoSize = true;
            this.scaleLabel2.Location = new System.Drawing.Point(6, 157);
            this.scaleLabel2.Name = "scaleLabel2";
            this.scaleLabel2.Size = new System.Drawing.Size(69, 13);
            this.scaleLabel2.TabIndex = 15;
            this.scaleLabel2.Text = "Scale object:";
            // 
            // svgPreview2
            // 
            this.svgPreview2.BackColor = System.Drawing.SystemColors.Control;
            this.svgPreview2.Location = new System.Drawing.Point(28, 19);
            this.svgPreview2.MaximumSize = new System.Drawing.Size(128, 128);
            this.svgPreview2.Name = "svgPreview2";
            this.svgPreview2.Size = new System.Drawing.Size(128, 128);
            this.svgPreview2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.svgPreview2.TabIndex = 3;
            this.svgPreview2.TabStop = false;
            // 
            // scaleFactor2
            // 
            this.scaleFactor2.Location = new System.Drawing.Point(9, 173);
            this.scaleFactor2.Maximum = 100;
            this.scaleFactor2.Minimum = 50;
            this.scaleFactor2.Name = "scaleFactor2";
            this.scaleFactor2.Size = new System.Drawing.Size(164, 45);
            this.scaleFactor2.SmallChange = 5;
            this.scaleFactor2.TabIndex = 16;
            this.scaleFactor2.TickFrequency = 5;
            this.scaleFactor2.Value = 50;
            this.scaleFactor2.ValueChanged += new System.EventHandler(this.scale2ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutMenuItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 522);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.folderBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Windows (phone) Icon Creator";
            ((System.ComponentModel.ISupportInitialize)(this.svgPreview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleFactor1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgPreview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleFactor2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox svgPreview1;
        private System.Windows.Forms.Label scaleLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar scaleFactor1;
        private System.Windows.Forms.Button bgColorInd;
        private System.Windows.Forms.Button selectBgColorBtn;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox folderBox;
        private System.Windows.Forms.CheckBox transparentBg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox w81_checkbox;
        private System.Windows.Forms.CheckBox wp81_checkbox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button selectTxtColorBtn;
        private System.Windows.Forms.Button txtColorInd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox appName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox svgPreview2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label scaleLabel2;
        private System.Windows.Forms.TrackBar scaleFactor2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

