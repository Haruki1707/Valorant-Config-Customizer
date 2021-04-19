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

        public static void ToDraw(Control.ControlCollection control, PaintEventArgs g)
        {
            var color = Color.White;
            Pen pen = new Pen(color, 3);
            foreach (Control current in control)
            {
                if (current is TextBox)
                {
                    ((TextBox)current).BorderStyle = BorderStyle.None;
                    var LX = current.Location.X;
                    var W = current.Width;
                    var Y = current.Location.Y + current.Height;

                    g.Graphics.DrawLine(pen, new PointF(LX, Y), new PointF(LX + W, Y));
                }
            }
            pen.Dispose();
        }
    }
}
