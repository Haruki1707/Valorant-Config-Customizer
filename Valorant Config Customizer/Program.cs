using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valorant_Config_Customizer
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void ToDraw(TextBox txtbox, Graphics g, int LineWidth = 3, Color? color = null, int Ymove = 0, int Xmove = 0)
        {
            if (color == null)
                color = Color.White;
            if (LineWidth == 1)
                Xmove = -1;
            Pen pen = new Pen((Color)color, LineWidth);
            txtbox.BorderStyle = BorderStyle.None;
            var LX = txtbox.Location.X;
            var W = txtbox.Width + Xmove;
            var Y = txtbox.Location.Y + txtbox.Height + Ymove;

            g.DrawLine(pen, new PointF(LX, Y), new PointF(LX + W, Y));
            g.Dispose();
            pen.Dispose();
        }
    }
}
