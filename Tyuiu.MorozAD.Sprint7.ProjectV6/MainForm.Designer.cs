
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonPat_MAD = new System.Windows.Forms.Button();
            this.panelMain_MAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain_MAD
            // 
            this.panelMain_MAD.BackColor = System.Drawing.Color.White;
            this.panelMain_MAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain_MAD.Controls.Add(this.button3);
            this.panelMain_MAD.Controls.Add(this.button2);
            this.panelMain_MAD.Controls.Add(this.buttonPat_MAD);
            this.panelMain_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain_MAD.Location = new System.Drawing.Point(0, 0);
            this.panelMain_MAD.Name = "panelMain_MAD";
            this.panelMain_MAD.Size = new System.Drawing.Size(800, 450);
            this.panelMain_MAD.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonPat_MAD
            // 
            this.buttonPat_MAD.BackColor = System.Drawing.SystemColors.MenuHighlight;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonPat_MAD;
    }
}

