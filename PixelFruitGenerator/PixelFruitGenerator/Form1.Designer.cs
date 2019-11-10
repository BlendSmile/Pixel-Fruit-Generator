namespace PixelFruitGenerator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Preview = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ColorDisp = new System.Windows.Forms.PictureBox();
            this.Sharpnes = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorDisp2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.FruitSize = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.LeafSize = new System.Windows.Forms.TrackBar();
            this.Gradient = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DirectoryBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FormatBox = new System.Windows.Forms.DomainUpDown();
            this.ExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sharpnes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorDisp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FruitSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeafSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Preview
            // 
            this.Preview.BackColor = System.Drawing.Color.White;
            this.Preview.Location = new System.Drawing.Point(13, 13);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(200, 200);
            this.Preview.TabIndex = 0;
            this.Preview.TabStop = false;
            this.Preview.Paint += new System.Windows.Forms.PaintEventHandler(this.Preview_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(219, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 201);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(345, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 201);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // ColorDisp
            // 
            this.ColorDisp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorDisp.Location = new System.Drawing.Point(353, 36);
            this.ColorDisp.Name = "ColorDisp";
            this.ColorDisp.Size = new System.Drawing.Size(20, 20);
            this.ColorDisp.TabIndex = 10;
            this.ColorDisp.TabStop = false;
            // 
            // Sharpnes
            // 
            this.Sharpnes.Location = new System.Drawing.Point(225, 34);
            this.Sharpnes.Minimum = -5;
            this.Sharpnes.Name = "Sharpnes";
            this.Sharpnes.Size = new System.Drawing.Size(104, 45);
            this.Sharpnes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sharpness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fruit Body";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Leaf";
            // 
            // ColorDisp2
            // 
            this.ColorDisp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorDisp2.Location = new System.Drawing.Point(353, 80);
            this.ColorDisp2.Name = "ColorDisp2";
            this.ColorDisp2.Size = new System.Drawing.Size(20, 20);
            this.ColorDisp2.TabIndex = 13;
            this.ColorDisp2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fruit Size";
            // 
            // FruitSize
            // 
            this.FruitSize.Location = new System.Drawing.Point(225, 85);
            this.FruitSize.Minimum = -5;
            this.FruitSize.Name = "FruitSize";
            this.FruitSize.Size = new System.Drawing.Size(104, 45);
            this.FruitSize.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Leaf Size";
            // 
            // LeafSize
            // 
            this.LeafSize.Location = new System.Drawing.Point(225, 145);
            this.LeafSize.Minimum = -5;
            this.LeafSize.Name = "LeafSize";
            this.LeafSize.Size = new System.Drawing.Size(104, 45);
            this.LeafSize.TabIndex = 17;
            // 
            // Gradient
            // 
            this.Gradient.AutoSize = true;
            this.Gradient.Location = new System.Drawing.Point(353, 107);
            this.Gradient.Name = "Gradient";
            this.Gradient.Size = new System.Drawing.Size(66, 17);
            this.Gradient.TabIndex = 19;
            this.Gradient.Text = "Gradient";
            this.Gradient.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(471, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 201);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Export";
            // 
            // DirectoryBox
            // 
            this.DirectoryBox.Location = new System.Drawing.Point(477, 56);
            this.DirectoryBox.Name = "DirectoryBox";
            this.DirectoryBox.Size = new System.Drawing.Size(298, 20);
            this.DirectoryBox.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Directory";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Format";
            // 
            // FormatBox
            // 
            this.FormatBox.Items.Add("PNG");
            this.FormatBox.Items.Add("Jpeg");
            this.FormatBox.Items.Add("Bitmap");
            this.FormatBox.Location = new System.Drawing.Point(477, 104);
            this.FormatBox.Name = "FormatBox";
            this.FormatBox.Size = new System.Drawing.Size(67, 20);
            this.FormatBox.TabIndex = 28;
            this.FormatBox.Text = "PNG";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(707, 183);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 29;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 234);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.FormatBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DirectoryBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Gradient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LeafSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FruitSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ColorDisp2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ColorDisp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sharpnes);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pixel Fruit Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sharpnes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorDisp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FruitSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeafSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Preview;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox ColorDisp;
        private System.Windows.Forms.TrackBar Sharpnes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ColorDisp2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar FruitSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar LeafSize;
        private System.Windows.Forms.CheckBox Gradient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DirectoryBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DomainUpDown FormatBox;
        private System.Windows.Forms.Button ExportButton;
    }
}

