using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

namespace PaintMe
{
    class CanvasForm : Form
    {

        public CanvasForm()
        {
            base.KeyPreview = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g;

            g = e.Graphics;

            Pen redPen = new Pen(Color.DarkRed);
            Pen whitePen = new Pen(Color.White);


            g.FillRectangle(new SolidBrush(Color.DarkBlue), new Rectangle(0, 0, 500, 500));


            whitePen.Width = 60;
            g.DrawLine(whitePen, -1, -1, 500, 500);
            g.DrawLine(whitePen, 0, 500, 500, 0);
            
            redPen.Width = 30;
            g.DrawLine(redPen, -1, -1, 500, 500);
            g.DrawLine(redPen, 0, 500, 500, 0);
            g.DrawString("Hello Simen!", new Font("Arial", 24), new SolidBrush(Color.Black), new Point(150, 50));
        }

    }



}
