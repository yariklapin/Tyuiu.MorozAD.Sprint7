
namespace Tyuiu.MorozAD.Sprint7.ProjectV6
{
    partial class MainForm
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
            this.panelMain_MAD = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonDoctor = new System.Windows.Forms.Button();
            this.buttonPat_MAD = new System.Windows.Forms.Button();
            this.panelMain_MAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain_MAD
            // 
            this.panelMain_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelMain_MAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain_MAD.Controls.Add(this.buttonAbout);
            this.panelMain_MAD.Controls.Add(this.buttonDoctor);
            this.panelMain_MAD.Controls.Add(this.buttonPat_MAD);
            this.panelMain_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain_MAD.Location = new System.Drawing.Point(0, 0);
            this.panelMain_MAD.Name = "panelMain_MAD";
            this.panelMain_MAD.Size = new System.Drawing.Size(800, 450);
            this.panelMain_MAD.TabIndex = 0;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.Firebrick;
            this.buttonAbout.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbout.Location = new System.Drawing.Point(260, 217);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(240, 65);
            this.buttonAbout.TabIndex = 2;
            this.buttonAbout.Text = "О программе";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonDoctor
            // 
            this.buttonDoctor.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDoctor.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDoctor.Location = new System.Drawing.Point(260, 146);
            this.buttonDoctor.Name = "buttonDoctor";
            this.buttonDoctor.Size = new System.Drawing.Size(240, 65);
            this.buttonDoctor.TabIndex = 1;
            this.buttonDoctor.Text = "Доктора";
            this.buttonDoctor.UseVisualStyleBackColor = false;
            this.buttonDoctor.Click += new System.EventHandler(this.buttonDoctor_Click);
            // 
            // buttonPat_MAD
            // 
            this.buttonPat_MAD.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonPat_MAD.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPat_MAD.Location = new System.Drawing.Point(260, 75);
            this.buttonPat_MAD.Name = "buttonPat_MAD";
            this.buttonPat_MAD.Size = new System.Drawing.Size(240, 65);
            this.buttonPat_MAD.TabIndex = 0;
            this.buttonPat_MAD.Text = "Пациенты";
            this.buttonPat_MAD.UseVisualStyleBackColor = false;
            this.buttonPat_MAD.Click += new System.EventHandler(this.buttonPatients_MAD_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain_MAD);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.panelMain_MAD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain_MAD;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonDoctor;
        private System.Windows.Forms.Button buttonPat_MAD;
    }
}

