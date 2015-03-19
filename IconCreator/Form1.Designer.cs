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
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.svgPreview = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scaleFactor = new System.Windows.Forms.TrackBar();
            this.bgColorInd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wp81_checkbox = new System.Windows.Forms.CheckBox();
            this.w81_checkbox = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtColorInd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.svgPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleFactor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // filePathBox
            // 
            this.filePathBox.Location = new System.Drawing.Point(85, 12);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.ReadOnly = true;
            this.filePathBox.Size = new System.Drawing.Size(344, 20);
            this.filePathBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Load SVG";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 10);
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
            // svgPreview
            // 
            this.svgPreview.BackColor = System.Drawing.Color.LightSeaGreen;
            this.svgPreview.Location = new System.Drawing.Point(24, 19);
            this.svgPreview.MaximumSize = new System.Drawing.Size(128, 128);
            this.svgPreview.Name = "svgPreview";
            this.svgPreview.Size = new System.Drawing.Size(128, 128);
            this.svgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.svgPreview.TabIndex = 3;
            this.svgPreview.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Scale object:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Background color:";
            // 
            // scaleFactor
            // 
            this.scaleFactor.Location = new System.Drawing.Point(9, 184);
            this.scaleFactor.Maximum = 100;
            this.scaleFactor.Minimum = 50;
            this.scaleFactor.Name = "scaleFactor";
            this.scaleFactor.Size = new System.Drawing.Size(164, 45);
            this.scaleFactor.SmallChange = 5;
            this.scaleFactor.TabIndex = 10;
            this.scaleFactor.TickFrequency = 5;
            this.scaleFactor.Value = 50;
            this.scaleFactor.ValueChanged += new System.EventHandler(this.scaleValueChanged);
            // 
            // bgColorInd
            // 
            this.bgColorInd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bgColorInd.Enabled = false;
            this.bgColorInd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgColorInd.Location = new System.Drawing.Point(9, 248);
            this.bgColorInd.Name = "bgColorInd";
            this.bgColorInd.Size = new System.Drawing.Size(75, 23);
            this.bgColorInd.TabIndex = 7;
            this.bgColorInd.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Choose";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.chooseBgColor);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(435, 40);
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
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Output path";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(344, 20);
            this.textBox1.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 277);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(143, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Transparent background";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.w81_checkbox);
            this.groupBox1.Controls.Add(this.wp81_checkbox);
            this.groupBox1.Location = new System.Drawing.Point(435, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 112);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Text color:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(90, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Choose";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.chooseTextColor);
            // 
            // txtColorInd
            // 
            this.txtColorInd.BackColor = System.Drawing.Color.White;
            this.txtColorInd.Enabled = false;
            this.txtColorInd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtColorInd.Location = new System.Drawing.Point(9, 184);
            this.txtColorInd.Name = "txtColorInd";
            this.txtColorInd.Size = new System.Drawing.Size(75, 23);
            this.txtColorInd.TabIndex = 17;
            this.txtColorInd.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Application name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 251);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.svgPreview);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.scaleFactor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bgColorInd);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(15, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 331);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic settings";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.txtColorInd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Location = new System.Drawing.Point(223, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 331);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tile settings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(37, 19);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(128, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 442);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathBox);
            this.Name = "Form1";
            this.Text = "Windows (phone) Icon Creator";
            ((System.ComponentModel.ISupportInitialize)(this.svgPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleFactor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox svgPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar scaleFactor;
        private System.Windows.Forms.Button bgColorInd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox w81_checkbox;
        private System.Windows.Forms.CheckBox wp81_checkbox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button txtColorInd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

