using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections;

namespace PixelFruitGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Rectangle[] fruitBody = new Rectangle[5];      
        private void Form1_Load(object sender, EventArgs e)
        {
            colorDialog1.Color = Color.Red;
            colorDialog2.Color = Color.Green;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ColorDisp.BackColor = colorDialog1.Color;
            ColorDisp2.BackColor = colorDialog2.Color;
            Preview.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
        }
        Bitmap bmp;
        private void Preview_Paint(object sender, PaintEventArgs e)
        {            
            // Create a Bitmap image in memory and set its CompositingMode
            bmp = new Bitmap(200, 200, PixelFormat.Format32bppArgb);
            Graphics gBmp = Graphics.FromImage(bmp);
            gBmp.CompositingMode = CompositingMode.SourceCopy;

            // draw the fruits based on control            

            #region Fruit Body                 
            Brush baseBrush = new SolidBrush(colorDialog1.Color);
            Brush shadowBrush = new SolidBrush(ControlPaint.Dark(colorDialog1.Color, 90));

            if (Gradient.Checked)
            {
                gBmp.FillRectangle(shadowBrush, 100 + 12, Sharpnes.Value * 4 + 100, 6 + FruitSize.Value * 2, 6 + FruitSize.Value * 2);
                gBmp.FillRectangle(shadowBrush, 100 + 6, Sharpnes.Value * 3 + 100, 12 + FruitSize.Value * 2, 12 + FruitSize.Value * 2);
                gBmp.FillRectangle(baseBrush, 100 + 3, Sharpnes.Value * 2 + 100, 16 + FruitSize.Value * 2, 16 + FruitSize.Value * 2);
                gBmp.FillRectangle(baseBrush, 100, 100, 20 + FruitSize.Value * 2, 20 + FruitSize.Value * 2);
            }
            else if (!Gradient.Checked)
            {
                gBmp.FillRectangle(baseBrush, 100 + 12, Sharpnes.Value * 4 + 100, 6 + FruitSize.Value * 2, 6 + FruitSize.Value * 2);
                gBmp.FillRectangle(baseBrush, 100 + 3, Sharpnes.Value * 2 + 100, 16 + FruitSize.Value * 2, 16 + FruitSize.Value * 2);
                gBmp.FillRectangle(baseBrush, 100 + 6, Sharpnes.Value * 3 + 100, 12 + FruitSize.Value * 2, 12 + FruitSize.Value * 2);
                gBmp.FillRectangle(baseBrush, 100, 100, 20 + FruitSize.Value * 2, 20 + FruitSize.Value * 2);
            }
            #endregion
            #region Leaf
            Brush leafBrush = new SolidBrush(colorDialog2.Color);
            if(Sharpnes.Value >= 0)
            {
                gBmp.FillRectangle(leafBrush, 110, 100 - 2, 5 + LeafSize.Value * 2, 5 + LeafSize.Value * 2);
                gBmp.FillRectangle(leafBrush, 108, 100 - 2, 8 + LeafSize.Value * 2, 3 + LeafSize.Value * 2);
            }
            else
            {
                gBmp.FillRectangle(leafBrush, 110, Sharpnes.Value * 4 + 100 - 2, 5 + LeafSize.Value * 2, 5 + LeafSize.Value * 2);
                gBmp.FillRectangle(leafBrush, 108, Sharpnes.Value * 4 + 100 - 2, 8 + LeafSize.Value * 2, 3 + LeafSize.Value * 2);
            }
            #endregion

            //preview the bitmap in a picturebox
            e.Graphics.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);            
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if(FormatBox.Text == "PNG")
            {
                bmp.Save(@DirectoryBox.Text + ".png", ImageFormat.Png);
            }
            if (FormatBox.Text == "Jpeg")
            {
                bmp.Save(@DirectoryBox.Text + ".jpg", ImageFormat.Jpeg);
            }
            if (FormatBox.Text == "Bitmap")
            {
                bmp.Save(@DirectoryBox.Text + ".bmp", ImageFormat.Bmp);
            }
        }
    }
}
