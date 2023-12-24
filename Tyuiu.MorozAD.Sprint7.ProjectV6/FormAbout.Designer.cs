
namespace Tyuiu.MorozAD.Sprint7.ProjectV6
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.panelPict = new System.Windows.Forms.Panel();
            this.panelAnother = new System.Windows.Forms.Panel();
            this.labelAbout = new System.Windows.Forms.Label();
            this.buttonOk_MAD = new System.Windows.Forms.Button();
            this.panelAnother.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPict
            // 
            this.panelPict.BackgroundImage = global::Tyuiu.MorozAD.Sprint7.ProjectV6.Properties.Resources._123;
            this.panelPict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPict.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPict.Location = new System.Drawing.Point(0, 0);
            this.panelPict.Name = "panelPict";
            this.panelPict.Size = new System.Drawing.Size(388, 450);
            this.panelPict.TabIndex = 0;
            // 
            // panelAnother
            // 
            this.panelAnother.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelAnother.Controls.Add(this.buttonOk_MAD);
            this.panelAnother.Controls.Add(this.labelAbout);
            this.panelAnother.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnother.Location = new System.Drawing.Point(388, 0);
            this.panelAnother.Name = "panelAnother";
            this.panelAnother.Size = new System.Drawing.Size(412, 450);
            this.panelAnother.TabIndex = 1;
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAbout.Location = new System.Drawing.Point(0, 0);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(284, 182);
            this.labelAbout.TabIndex = 2;
            this.labelAbout.Text = resources.GetString("labelAbout.Text");
            // 
            // buttonOk_MAD
            // 
            this.buttonOk_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonOk_MAD.Location = new System.Drawing.Point(302, 405);
            this.buttonOk_MAD.Name = "buttonOk_MAD";
            this.buttonOk_MAD.Size = new System.Drawing.Size(110, 42);
            this.buttonOk_MAD.TabIndex = 3;
            this.buttonOk_MAD.Text = "OK";
            this.buttonOk_MAD.UseVisualStyleBackColor = false;
            this.buttonOk_MAD.Click += new System.EventHandler(this.buttonOk_MAD_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAnother);
            this.Controls.Add(this.panelPict);
            this.Name = "FormAbout";
            this.Text = "О программе";
            this.panelAnother.ResumeLayout(false);
            this.panelAnother.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPict;
        private System.Windows.Forms.Panel panelAnother;
        private System.Windows.Forms.Button buttonOk_MAD;
        private System.Windows.Forms.Label labelAbout;
    }
}