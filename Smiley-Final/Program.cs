﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Smiley_Final
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    /*public class SmileyForm : Form
    {
        public SmileyForm(int size, int happiness, Color smiley, Color eyes, Color mouth);
        {
            this.Text = "Hallo";
            this.BackColor = Color.Black;
            this.Size = new Size(size + 16, size + 39);
            this.Paint += this.tekenScherm;

        }

        void tekenScherm(object obj, PaintEventArgs pea)
        {
            int size = this.Size.Width - 16;
            Brush smiley = new SolidBrush(Color.Yellow);
            Rectangle smileyRect = new Rectangle(size / 8, size / 8, size / 4 * 3, size / 4 * 3);
            Brush eyes = new SolidBrush(Color.Black);
            Pen smile = new Pen(Color.Black, 5);
            float startAngle = -180.0F;
            float sweepAngle = -180.0F;
            Rectangle smileBox = new Rectangle(size / 4, size - size / 2, size / 2, size / 4);
            Rectangle eyesRectLeft = new Rectangle(size / 4, size / 4, size / 8, size / 8);
            Rectangle eyesRectRight = new Rectangle(size - (size / 2 - size / 8), size / 4, size / 8, size / 8);
            //Rectangle smileyRect = new Rectangle(50, 50, 300, 300);
            pea.Graphics.FillEllipse(smiley, smileyRect);
            pea.Graphics.FillEllipse(eyes, eyesRectLeft);
            pea.Graphics.FillEllipse(eyes, eyesRectRight);
            pea.Graphics.DrawArc(smile, smileBox, startAngle, sweepAngle);
            //pea.Graphics.DrawRectangle(smile, smileBox);

        }
    }*/
}
