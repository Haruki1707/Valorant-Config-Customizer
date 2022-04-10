using EZ_Updater;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valorant_Config_Customizer
{
    public partial class Form1 : Form
    {
        string ConfigPath = null;
        static List<string> GUSlines = new List<string>();

        ScalabilityGroups ResQua = new ScalabilityGroups();
        ScalabilityGroups ViewQua = new ScalabilityGroups();
        ScalabilityGroups AAQua = new ScalabilityGroups();
        ScalabilityGroups ShadowQua = new ScalabilityGroups();
        ScalabilityGroups PPQua = new ScalabilityGroups();
        ScalabilityGroups TexQua = new ScalabilityGroups();
        ScalabilityGroups EffectsQua = new ScalabilityGroups();
        ScalabilityGroups FoliQua = new ScalabilityGroups();
        ScalabilityGroups ShadingQua = new ScalabilityGroups();

        public Form1()
        {
            InitializeComponent();

            //Gets Valorant Config Directory
            var path = Environment.ExpandEnvironmentVariables(@"%LOCALAPPDATA%\VALORANT\Saved\Config");
            try
            {
                string LastUser = null;
                foreach (var line in File.ReadAllLines(path + @"\Windows\RiotLocalMachine.ini"))
                {
                    if (line.Contains("LastKnownUser"))
                    {
                        LastUser = line.Replace("LastKnownUser=", "");
                        foreach (var dir in Directory.GetDirectories(path))
                            if (dir.Contains(LastUser))
                                ConfigPath = path + @"\" + new DirectoryInfo(dir).Name + @"\Windows\";
                    }
                }

                GUSlines.Clear();
                foreach (var line in File.ReadAllLines(ConfigPath + @"GameUserSettings.ini"))
                    GUSlines.Add(line);

                ResQuaTxtbox.Text = ResQua.GetValue("Resolution Quality", GUSlines);
                VDQuaTxtbox.Text = ViewQua.GetValue("View Distance Quality", GUSlines);
                AAQuaTxtbox.Text = AAQua.GetValue("Anti Aliasing Quality", GUSlines);
                ShadowQuaTxtbtn.Text = ShadowQua.GetValue("Shadow Quality", GUSlines);
                PPQuaTxtbtn.Text = PPQua.GetValue("Post Process Quality", GUSlines);
                TexQuaTxtbtn.Text = TexQua.GetValue("Texture Quality", GUSlines);
                EffectsQuaTxtbtn.Text = EffectsQua.GetValue("Effects Quality", GUSlines);
                FoliQuaTxtbtn.Text = FoliQua.GetValue("Foliage Quality", GUSlines);
                ShadingQuaTxtbtn.Text = ShadingQua.GetValue("Shading Quality", GUSlines);
            }
            catch (Exception e)
            {
                var result = Error(e + "\n\nClosing program");
                if (result == DialogResult.OK)
                    Environment.Exit(0);
            }
        }

        private void SCbtn_Click(object sender, EventArgs e)
        {
            string GUSini = ConfigPath + @"GameUserSettings.ini";
            foreach (var control in this.Controls)
            {
                if(control is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)control).Text))
                        ((TextBox)control).Text = "0";
                }
            }
            try
            {
                File.SetAttributes(GUSini, File.GetAttributes(GUSini) & ~FileAttributes.ReadOnly);
                File.WriteAllLines(GUSini, GUSlines);
                Success("GameUserConfig.ini successfully modified", true);
            }
            catch (Exception)
            {
                Error("Error modifying GameUserConfig.ini");
            }
            try
            {
                if (ROTxtbox.Checked == true)
                    File.SetAttributes(GUSini, File.GetAttributes(GUSini) | FileAttributes.ReadOnly);
            }
            catch (Exception)
            {
                Error("Error making file ReadOnly");
            }
        }

        private void ResQuaTxtbox_TextChanged(object sender, EventArgs e)
        {

            if(ResQuaTxtbox.Text.Length > 3)
                ResQuaTxtbox.Text = ResQuaTxtbox.Text.Remove(ResQuaTxtbox.Text.Length - 7);

            int value = 0;
            int.TryParse(ResQuaTxtbox.Text, out value);
            if (value < 1 && ResQuaTxtbox.Text != "")
                ResQuaTxtbox.Text = "1";
            if (value > 100)
                ResQuaTxtbox.Text = "100";

            ResQuaTxtbox.Select(ResQuaTxtbox.Text.Length, 0);
            ResQua.SetValue(ResQuaTxtbox.Text + ".000000");
        }

        private void VDQuaTxtbox_TextChanged(object sender, EventArgs e)
        {
            ViewQua.SetValue(VDQuaTxtbox.Text);
        }

        private void AAQuaTxtbox_TextChanged(object sender, EventArgs e)
        {
            AAQua.SetValue(AAQuaTxtbox.Text);
        }

        private void ShadowQuaTxtbtn_TextChanged(object sender, EventArgs e)
        {
            ShadowQua.SetValue(ShadowQuaTxtbtn.Text);
        }

        private void PPQuaTxtbtn_TextChanged(object sender, EventArgs e)
        {
            PPQua.SetValue(PPQuaTxtbtn.Text);
        }

        private void TexQuaTxtbtn_TextChanged(object sender, EventArgs e)
        {
            TexQua.SetValue(TexQuaTxtbtn.Text);
        }

        private void EffectsQuaTxtbtn_TextChanged(object sender, EventArgs e)
        {
            EffectsQua.SetValue(EffectsQuaTxtbtn.Text);
        }

        private void FoliQuaTxtbtn_TextChanged(object sender, EventArgs e)
        {
            FoliQua.SetValue(FoliQuaTxtbtn.Text);
        }

        private void ShadingQuaTxtbtn_TextChanged(object sender, EventArgs e)
        {
            ShadingQua.SetValue(FoliQuaTxtbtn.Text);
        }

        private void ResQuaTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
                e.Handled = false;
        }

        private void ZeroToThree_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar == Convert.ToChar(Keys.Back))
                e.Handled = false;
            else if (char.IsDigit(e.KeyChar) && char.GetNumericValue(e.KeyChar) < 4)
                e.Handled = false;
        }

        private void ZeroToTwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar == Convert.ToChar(Keys.Back))
                e.Handled = false;
            else if (char.IsDigit(e.KeyChar) && char.GetNumericValue(e.KeyChar) < 3)
                e.Handled = false;
        }

        private void FocusedTxtBox_Enter(object sender, EventArgs e)
        {
            Program.ToDraw((TextBox)sender, CreateGraphics(), 5);
        }

        private void LeavedTxtBox_Leave(object sender, EventArgs e)
        {
            Program.ToDraw((TextBox)sender, CreateGraphics(), 3, Color.FromArgb(22, 28, 38), 2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            foreach (Control current in Controls)
                if (current is TextBox)
                    Program.ToDraw((TextBox)current, CreateGraphics(), 1);
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Info(string message)
        {
            var info = new MessageForm(message, 0);
            info.ShowDialog();
        }

        private DialogResult Error(string message)
        {
            var error = new MessageForm(message, 1);
            error.ShowDialog();
            return DialogResult.OK;
        }

        private DialogResult Success(string message, bool OK = false)
        {
            MessageForm success;
            if (!OK)
                success = new MessageForm(message, 2);
            else
                success = new MessageForm(message, 3);
            success.ShowDialog();

            return success.dialogResult;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Haruki1707/Valorant-Config-Customizer/wiki/Resolution-Quality-1%25---100%25");
        }

        //Permite arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FormDisp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            Success("Tested on: Valorant  V2.07\n\nDeveloped by: Haruki1707\nGitHub: github.com/Haruki1707", true);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            linkLabel1.Focus();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            Updater.GitHub_User = "Haruki1707";
            Updater.GitHub_Repository = "Valorant-Config-Customizer";

            if (await Updater.CheckUpdateAsync())
                if (Updater.CannotWriteOnDir)
                    MessageBox.Show("Application cannot update in current directory, consider moving it to another folder or executing with Admin rights", "Alert");
                else
                {
                    new MessageForm("", 4)
                    {
                        Owner = this
                    }.ShowDialog();
                }
        }
    }
}
