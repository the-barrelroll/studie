﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moving_Smiley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.Paint += this.SmileyDraw;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DrawSmiley(object sender, EventArgs e)
        {
            this.pictureBox1.Location = getMouseLocation();
        }

        private void SmileyDraw(object obj, PaintEventArgs pea)
        {
            
            

            int size = 100;
            int x = 250;
            int y = 250;
            float startAngle = -180.0F;
            float sweepAngle = -180.0F;
            Brush smiley = new SolidBrush(Color.Yellow);
            Brush eyes = new SolidBrush(Color.Black);
            Pen smile = new Pen(Color.Black, 5);
            Rectangle smileyRect = new Rectangle(x + 0, y + 0, size, size);
            Rectangle eyesRectLeft = new Rectangle(x + (size / 24) * 7, y + size / 3, size / 8, size / 8);
            Rectangle eyesRectRight = new Rectangle(x + ((size / 24) * 15), y + size / 3, size / 8, size / 8);
            Rectangle smileBox = new Rectangle(x + size / 4, y + size / 2, size / 2, size / 4);
            pea.Graphics.FillEllipse(smiley, smileyRect);
            pea.Graphics.FillEllipse(eyes, eyesRectLeft);
            pea.Graphics.FillEllipse(eyes, eyesRectRight);
            pea.Graphics.DrawArc(smile, smileBox, startAngle, sweepAngle);

            //Bitmap bmp = new Bitmap(500, 500);

            //using (Graphics g = Graphics.FromImage(bmp))

            //{

            //    int size = 100;
            //    //Point location = new Point(this.pictureBox1.Location.X + 46, this.pictureBox1.Location.Y + 66);
            //    Point location = new Point(60, 80);
            //    int x = location.X;
            //    int y = location.Y;
            //    Brush smiley = new SolidBrush(Color.Yellow);
            //    Brush eyes = new SolidBrush(Color.Black);
            //    Pen smile = new Pen(Color.Black, 5);
            //    Rectangle smileyRect = new Rectangle((x + 100) - size / 2 - 10, (y + 100) - (size / 2) - 30, size, size);
            //    Rectangle eyesRectLeft = new Rectangle((x + 100) - size / 3, (y + 100) - size / 2, size / 8, size / 8);
            //    Rectangle eyesRectRight = new Rectangle((x + 100), (y + 100) - size / 2, size / 8, size / 8);
            //    Rectangle smileBox = new Rectangle((x + 100) - size / 2 + 13, (y + 100) - size / 3, size / 2, size / 4);
            //    float startAngle = -180.0F;
            //    float sweepAngle = -180.0F;
            //    g.FillEllipse(smiley, smileyRect);
            //    g.FillEllipse(eyes, eyesRectLeft);
            //    g.FillEllipse(eyes, eyesRectRight);
            //    g.DrawArc(smile, smileBox, startAngle, sweepAngle);
            //}

            //pictureBox1.Image = bmp;

            //pea.Graphics.DrawRectangle(smile, smileBox);
        }

        private Point getMouseLocation()
        {
            Point location = this.PointToClient(MousePosition);
            location.X += -300;
            location.Y += -305;
            return location;
        }
    }
}
