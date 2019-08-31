﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Line
{
    public partial class Line : Form
    {
        readonly Color transparent = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
        double b, k;
        private Graphics gps;
        private readonly Pen pen = new Pen(Color.Black, 2f);
        Point p1, p2;

        public Line()
        {
            InitializeComponent();
            gps = CreateGraphics();
        }

        private void Line_MouseClick(object sender, MouseEventArgs e)
        {
            if (p1.X == 0)
            {
                p1 = new Point(e.X, e.Y);
            }
            else
            {
                p1.X = 0;
            }
        }

        private void Line_MouseMove(object sender, MouseEventArgs e)
        {
            if (p1.X > 0)
            {
                p2 = new Point(p1.X + (e.X - p1.X) * 10, p1.Y + (e.Y - p1.Y) * 10);
                gps.Clear(transparent);
                gps.DrawLine(pen, p1, p2);
                if (p2.X != p1.X)
                {
                    k = (double)(p2.Y - p1.Y) / (p2.X - p1.X);
                    b = p1.Y - k * p1.X;
                    if (p2.X < 0)
                    {
                        gps.DrawLine(pen, new Point(0, (int)b), new Point(0 + p1.X * 10, (int)(b + (b - p1.Y) * 10)));
                    }
                    else if (p2.X > Width)
                    {
                        gps.DrawLine(pen, new Point(Width, (int)(b + k * ClientRectangle.Width)), new Point(0 + -p1.X * 10, (int)(b + (p1.Y - b) * 10)));
                    }
                    if (p2.Y < 0)
                    {
                        gps.DrawLine(pen, new Point((int)(-b / k), 0), new Point((int)(p1.X + ((-b / k) - p1.X) * 10), (p1.Y + p1.Y * 10)));
                    }
                    else if (p2.Y > Height)
                    {
                        gps.DrawLine(pen, new Point((int)((ClientRectangle.Height - b) / k), ClientRectangle.Height), new Point((int)(p1.X + (((ClientRectangle.Height - b) / k) - p1.X) * 10), p1.Y + -p1.Y * 10));
                    }
                }
            }
        }

        private void Line_Resize(object sender, EventArgs e)
        {
            gps = CreateGraphics();
        }
    }
}