using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZ_Updater;

namespace Valorant_Config_Customizer
{
    public partial class MessageForm : Form
    {
        public MessageForm(string Message, int Type)
        {
            InitializeComponent();

            if(Message.Length > 325)
            {
                this.Height = 550;
                Messagelbl.Height = 481;
                iconPB.Location = new Point(iconPB.Location.X, iconPB.Location.Y + 175);
            }

            switch (Type)
            {
                //Info message
                case 0:
                    YESbtn.Hide();
                    NObtn.Hide();
                    iconPB.Image = System.Drawing.SystemIcons.Exclamation.ToBitmap();
                    break;
                //Error message
                case 1:
                    YESbtn.Hide();
                    NObtn.Hide();
                    iconPB.Image = System.Drawing.SystemIcons.Error.ToBitmap();
                    break;
                //Succes message
                case 2:
                    OKbtn.Hide();
                    iconPB.Image = System.Drawing.SystemIcons.Information.ToBitmap();
                    break;
                case 3:
                    YESbtn.Hide();
                    NObtn.Hide();
                    iconPB.Image = System.Drawing.SystemIcons.Information.ToBitmap();
                    break;
                case 4:
                    YESbtn.Hide();
                    NObtn.Hide();
                    OKbtn.Hide();
                    iconPB.Hide();
                    Messagelbl.Hide();
                    progressBar1.Show();
                    label1.Show();
                    Updater.Update(UIChange);
                    break;
                default:
                    break;
            }

            Messagelbl.Text = Message;
        }

        private void UIChange(object sender, EventArgs e)
        {
            label1.Text = Updater.Message;
            progressBar1.Value = Updater.ProgressPercentage;

            switch (Updater.ShortState)
            {
                case UpdaterShortState.Canceled:
                    OKbtn.Visible = true;
                    break;
                case UpdaterShortState.Installed:
                    Application.Restart();
                    break;
            }
        }

        public DialogResult dialogResult = DialogResult.No;

        private void OKbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NObtn_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.No;
            OKbtn_Click(sender, e);
        }

        private void YESbtn_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.Yes;
            OKbtn_Click(sender, e);
        }

        protected override void OnPaint(PaintEventArgs pea)
        {
            Pen pen = new Pen(Color.FromArgb(13, 17, 23), 10);

            PointF pt1 = new PointF(0, 0);
            PointF pt2 = new PointF(0, Height);
            PointF pt3 = new PointF(Width, 0);
            PointF pt4 = new PointF(Width, Height);

            // Draws the line 
            pea.Graphics.DrawLine(pen, pt1, pt2);
            pea.Graphics.DrawLine(pen, pt1, pt3);
            pea.Graphics.DrawLine(pen, pt3, pt4);
        }
    }
}
