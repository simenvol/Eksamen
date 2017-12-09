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
    class Program
    {
        [DllImport("User32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("User32.dll")]
        public static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);

        static void Main(string[] args)
        {
            Form f = new CanvasForm();
            f.BackColor = Color.White;
            f.FormBorderStyle = FormBorderStyle.None;
            f.SetBounds(500, 500, 500, 500);
            f.TopMost = true;


            
            Application.EnableVisualStyles();
            Application.Run(f);
        }


    }
}
