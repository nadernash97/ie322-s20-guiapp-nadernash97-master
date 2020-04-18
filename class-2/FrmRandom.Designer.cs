namespace class_2
{
    partial class FrmRandom
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
            this.btngrn = new System.Windows.Forms.Button();
            this.btngeneraterandom = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btngrn
            // 
            this.btngrn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btngrn.ForeColor = System.Drawing.Color.Black;
            this.btngrn.Location = new System.Drawing.Point(31, 61);
            this.btngrn.Name = "btngrn";
            this.btngrn.Size = new System.Drawing.Size(337, 141);
            this.btngrn.TabIndex = 0;
            this.btngrn.Text = "Generate Random Color";
            this.btngrn.UseVisualStyleBackColor = false;
            this.btngrn.Click += new System.EventHandler(this.btngrn_Click);
            // 
            // btngeneraterandom
            // 
            this.btngeneraterandom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btngeneraterandom.Location = new System.Drawing.Point(581, 61);
            this.btngeneraterandom.Name = "btngeneraterandom";
            this.btngeneraterandom.Size = new System.Drawing.Size(163, 129);
            this.btngeneraterandom.TabIndex = 1;
            this.btngeneraterandom.Text = "generate random";
            this.btngeneraterandom.UseVisualStyleBackColor = false;
            this.btngeneraterandom.Click += new System.EventHandler(this.btngeneraterandom_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Location = new System.Drawing.Point(581, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 129);
            this.button3.TabIndex = 2;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(169, 253);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(64, 27);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "r-g-b";
            // 
            // FrmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btngeneraterandom);
            this.Controls.Add(this.btngrn);
            this.Name = "FrmRandom";
            this.Text = "Form Random";
            this.Load += new System.EventHandler(this.FrmRandom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngrn;
        private System.Windows.Forms.Button btngeneraterandom;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl;
    }
}