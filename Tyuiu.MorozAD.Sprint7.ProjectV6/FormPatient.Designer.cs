
namespace Tyuiu.MorozAD.Sprint7.ProjectV6
{
    partial class FormPatient
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
            this.panelPHead_MAD = new System.Windows.Forms.Panel();
            this.buttonInfoLayer_MAD = new System.Windows.Forms.Button();
            this.textBoxPat_MAD = new System.Windows.Forms.TextBox();
            this.buttonOpen_MAD = new System.Windows.Forms.Button();
            this.panelHavePat = new System.Windows.Forms.Panel();
            this.dataGridViewPat_MAD = new System.Windows.Forms.DataGridView();
            this.buttonLoad_MAD = new System.Windows.Forms.Button();
            this.panelPHead_MAD.SuspendLayout();
            this.panelHavePat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPat_MAD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPHead_MAD
            // 
            this.panelPHead_MAD.Controls.Add(this.buttonLoad_MAD);
            this.panelPHead_MAD.Controls.Add(this.buttonInfoLayer_MAD);
            this.panelPHead_MAD.Controls.Add(this.buttonOpen_MAD);
            this.panelPHead_MAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPHead_MAD.Location = new System.Drawing.Point(0, 0);
            this.panelPHead_MAD.Name = "panelPHead_MAD";
            this.panelPHead_MAD.Size = new System.Drawing.Size(800, 66);
            this.panelPHead_MAD.TabIndex = 0;
            // 
            // buttonInfoLayer_MAD
            // 
            this.buttonInfoLayer_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfoLayer_MAD.BackgroundImage = global::Tyuiu.MorozAD.Sprint7.ProjectV6.Properties.Resources.kartinki_znak_voprosa_31;
            this.buttonInfoLayer_MAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInfoLayer_MAD.Location = new System.Drawing.Point(722, 9);
            this.buttonInfoLayer_MAD.Name = "buttonInfoLayer_MAD";
            this.buttonInfoLayer_MAD.Size = new System.Drawing.Size(75, 41);
            this.buttonInfoLayer_MAD.TabIndex = 2;
            this.buttonInfoLayer_MAD.UseVisualStyleBackColor = true;
            // 
            // textBoxPat_MAD
            // 
            this.textBoxPat_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPat_MAD.Location = new System.Drawing.Point(790, 351);
            this.textBoxPat_MAD.Multiline = true;
            this.textBoxPat_MAD.Name = "textBoxPat_MAD";
            this.textBoxPat_MAD.Size = new System.Drawing.Size(10, 33);
            this.textBoxPat_MAD.TabIndex = 1;
            // 
            // buttonOpen_MAD
            // 
            this.buttonOpen_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonOpen_MAD.Location = new System.Drawing.Point(120, 7);
            this.buttonOpen_MAD.Name = "buttonOpen_MAD";
            this.buttonOpen_MAD.Size = new System.Drawing.Size(102, 44);
            this.buttonOpen_MAD.TabIndex = 0;
            this.buttonOpen_MAD.Text = "Пациенты";
            this.buttonOpen_MAD.UseVisualStyleBackColor = false;
            this.buttonOpen_MAD.Click += new System.EventHandler(this.buttonOpen_MAD_Click);
            // 
            // panelHavePat
            // 
            this.panelHavePat.Controls.Add(this.dataGridViewPat_MAD);
            this.panelHavePat.Controls.Add(this.textBoxPat_MAD);
            this.panelHavePat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHavePat.Location = new System.Drawing.Point(0, 66);
            this.panelHavePat.Name = "panelHavePat";
            this.panelHavePat.Size = new System.Drawing.Size(800, 384);
            this.panelHavePat.TabIndex = 1;
            // 
            // dataGridViewPat_MAD
            // 
            this.dataGridViewPat_MAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPat_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPat_MAD.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPat_MAD.Name = "dataGridViewPat_MAD";
            this.dataGridViewPat_MAD.Size = new System.Drawing.Size(800, 384);
            this.dataGridViewPat_MAD.TabIndex = 0;
            // 
            // buttonLoad_MAD
            // 
            this.buttonLoad_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonLoad_MAD.Location = new System.Drawing.Point(12, 7);
            this.buttonLoad_MAD.Name = "buttonLoad_MAD";
            this.buttonLoad_MAD.Size = new System.Drawing.Size(102, 44);
            this.buttonLoad_MAD.TabIndex = 3;
            this.buttonLoad_MAD.Text = "Открыть";
            this.buttonLoad_MAD.UseVisualStyleBackColor = false;
            this.buttonLoad_MAD.Click += new System.EventHandler(this.buttonLoad_MAD_Click);
            // 
            // FormPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelHavePat);
            this.Controls.Add(this.panelPHead_MAD);
            this.Name = "FormPatient";
            this.Text = "Пациенты";
            this.panelPHead_MAD.ResumeLayout(false);
            this.panelHavePat.ResumeLayout(false);
            this.panelHavePat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPat_MAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPHead_MAD;
        private System.Windows.Forms.Button buttonInfoLayer_MAD;
        private System.Windows.Forms.TextBox textBoxPat_MAD;
        private System.Windows.Forms.Button buttonOpen_MAD;
        private System.Windows.Forms.Panel panelHavePat;
        private System.Windows.Forms.DataGridView dataGridViewPat_MAD;
        private System.Windows.Forms.Button buttonLoad_MAD;
    }
}