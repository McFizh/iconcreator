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
            this.button3 = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.svgPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleFactor)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(23, 15);
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
            this.button1.Click += new System.EventHandler(this.onBrowseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // svgPreview
            // 
            this.svgPreview.BackColor = System.Drawing.Color.LightSeaGreen;
            this.svgPreview.Location = new System.Drawing.Point(26, 73);
            this.svgPreview.MaximumSize = new System.Drawing.Size(200, 200);
            this.svgPreview.Name = "svgPreview";
            this.svgPreview.Size = new System.Drawing.Size(200, 200);
            this.svgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.svgPreview.TabIndex = 3;
            this.svgPreview.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Scale object:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Background color:";
            // 
            // scaleFactor
            // 
            this.scaleFactor.Location = new System.Drawing.Point(265, 89);
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
            this.bgColorInd.Enabled = false;
            this.bgColorInd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgColorInd.Location = new System.Drawing.Point(265, 154);
            this.bgColorInd.Name = "bgColorInd";
            this.bgColorInd.Size = new System.Drawing.Size(75, 23);
            this.bgColorInd.TabIndex = 7;
            this.bgColorInd.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Choose";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.chooseColor);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(265, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Update preview";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 379);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bgColorInd);
            this.Controls.Add(this.scaleFactor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.svgPreview);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.svgPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleFactor)).EndInit();
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog colorPicker;
    }
}

