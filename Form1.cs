using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoordinatesExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Show();

            Graphics g = this.CreateGraphics();

            SolidBrush b1 = new SolidBrush(Color.Black);
            SolidBrush b2 = new SolidBrush(Color.Red);

            Rectangle[] arr = new Rectangle[]
            {
                new Rectangle(0,0,150,90),
                new Rectangle(300, 0,150,90),
                new Rectangle(150,90,150,90),
                new Rectangle(450,90,150,90),
                new Rectangle(0,180,150,90),
                new Rectangle(300,180,150,90),
                new Rectangle(150,270,150,90),

            };
            Rectangle[] arr2 = new Rectangle[]{
                 new Rectangle(150,0,150,90),
                 new Rectangle(450,0,150,90),
                 new Rectangle(0,90,150,90),
                 new Rectangle(300,90,150,90),
                 new Rectangle(150,180,150,90),
                 new Rectangle(450,180,150,90),
                 new Rectangle(0,270,150,90),
                 new Rectangle(300,270,150,90)
            };
            foreach (var i in arr)
            {
                Graphics.FillRectangle(b1, i);
            }
            foreach (var i in arr2)
            {
                Graphics.FillRectangle(b2, i);
            }
            b1.Dispose();
            b2.Dispose();
        }
     }

    }
