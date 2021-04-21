
namespace Valorant_Config_Customizer
{
    partial class MessageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iconPB = new System.Windows.Forms.PictureBox();
            this.Messagelbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NObtn = new System.Windows.Forms.Button();
            this.YESbtn = new System.Windows.Forms.Button();
            this.OKbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconPB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPB
            // 
            this.iconPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.iconPB.Location = new System.Drawing.Point(11, 57);
            this.iconPB.Name = "iconPB";
            this.iconPB.Size = new System.Drawing.Size(45, 45);
            this.iconPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPB.TabIndex = 31;
            this.iconPB.TabStop = false;
            // 
            // Messagelbl
            // 
            this.Messagelbl.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messagelbl.ForeColor = System.Drawing.Color.White;
            this.Messagelbl.Location = new System.Drawing.Point(61, 15);
            this.Messagelbl.Name = "Messagelbl";
            this.Messagelbl.Size = new System.Drawing.Size(348, 131);
            this.Messagelbl.TabIndex = 30;
            this.Messagelbl.Text = "Here will be displayed the message...";
            this.Messagelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.NObtn);
            this.panel1.Controls.Add(this.YESbtn);
            this.panel1.Controls.Add(this.OKbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 40);
            this.panel1.TabIndex = 32;
            // 
            // NObtn
            // 
            this.NObtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.NObtn.FlatAppearance.BorderSize = 0;
            this.NObtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(116)))), ((int)(((byte)(128)))));
            this.NObtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NObtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NObtn.ForeColor = System.Drawing.Color.White;
            this.NObtn.Location = new System.Drawing.Point(219, 7);
            this.NObtn.Name = "NObtn";
            this.NObtn.Size = new System.Drawing.Size(93, 27);
            this.NObtn.TabIndex = 5;
            this.NObtn.Text = "No";
            this.NObtn.UseVisualStyleBackColor = false;
            this.NObtn.Click += new System.EventHandler(this.NObtn_Click);
            // 
            // YESbtn
            // 
            this.YESbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.YESbtn.FlatAppearance.BorderSize = 0;
            this.YESbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(116)))), ((int)(((byte)(128)))));
            this.YESbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YESbtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YESbtn.ForeColor = System.Drawing.Color.White;
            this.YESbtn.Location = new System.Drawing.Point(108, 7);
            this.YESbtn.Name = "YESbtn";
            this.YESbtn.Size = new System.Drawing.Size(93, 27);
            this.YESbtn.TabIndex = 4;
            this.YESbtn.Text = "Yes";
            this.YESbtn.UseVisualStyleBackColor = false;
            this.YESbtn.Click += new System.EventHandler(this.YESbtn_Click);
            // 
            // OKbtn
            // 
            this.OKbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.OKbtn.FlatAppearance.BorderSize = 0;
            this.OKbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(116)))), ((int)(((byte)(128)))));
            this.OKbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKbtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKbtn.ForeColor = System.Drawing.Color.White;
            this.OKbtn.Location = new System.Drawing.Point(318, 7);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(93, 27);
            this.OKbtn.TabIndex = 3;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = false;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(420, 200);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconPB);
            this.Controls.Add(this.Messagelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageForm";
            ((System.ComponentModel.ISupportInitialize)(this.iconPB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iconPB;
        private System.Windows.Forms.Label Messagelbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NObtn;
        private System.Windows.Forms.Button YESbtn;
        private System.Windows.Forms.Button OKbtn;
    }
}