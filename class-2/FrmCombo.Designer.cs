namespace class_2
{
    partial class FrmCombo
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
            this.btnssm1 = new System.Windows.Forms.Button();
            this.btnssm2 = new System.Windows.Forms.Button();
            this.btnrbn = new System.Windows.Forms.Button();
            this.btnrbi = new System.Windows.Forms.Button();
            this.btnrli = new System.Windows.Forms.Button();
            this.btnr2li = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnssm1
            // 
            this.btnssm1.BackColor = System.Drawing.Color.SeaShell;
            this.btnssm1.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnssm1.Location = new System.Drawing.Point(36, 100);
            this.btnssm1.Name = "btnssm1";
            this.btnssm1.Size = new System.Drawing.Size(122, 68);
            this.btnssm1.TabIndex = 0;
            this.btnssm1.Text = "Show Selcted Method 1";
            this.btnssm1.UseVisualStyleBackColor = false;
            this.btnssm1.Click += new System.EventHandler(this.btnssm1_Click);
            // 
            // btnssm2
            // 
            this.btnssm2.BackColor = System.Drawing.Color.SeaShell;
            this.btnssm2.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnssm2.Location = new System.Drawing.Point(201, 100);
            this.btnssm2.Name = "btnssm2";
            this.btnssm2.Size = new System.Drawing.Size(122, 68);
            this.btnssm2.TabIndex = 1;
            this.btnssm2.Text = "Show Selected Method 2";
            this.btnssm2.UseVisualStyleBackColor = false;
            this.btnssm2.Click += new System.EventHandler(this.btnssm2_Click);
            // 
            // btnrbn
            // 
            this.btnrbn.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnrbn.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrbn.ForeColor = System.Drawing.Color.Red;
            this.btnrbn.Location = new System.Drawing.Point(446, 139);
            this.btnrbn.Name = "btnrbn";
            this.btnrbn.Size = new System.Drawing.Size(130, 44);
            this.btnrbn.TabIndex = 2;
            this.btnrbn.Text = "Remove by Name";
            this.btnrbn.UseVisualStyleBackColor = false;
            this.btnrbn.Click += new System.EventHandler(this.btnrbn_Click);
            // 
            // btnrbi
            // 
            this.btnrbi.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnrbi.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrbi.ForeColor = System.Drawing.Color.Red;
            this.btnrbi.Location = new System.Drawing.Point(610, 139);
            this.btnrbi.Name = "btnrbi";
            this.btnrbi.Size = new System.Drawing.Size(130, 44);
            this.btnrbi.TabIndex = 3;
            this.btnrbi.Text = "Remove By index";
            this.btnrbi.UseVisualStyleBackColor = false;
            this.btnrbi.Click += new System.EventHandler(this.btnrbi_Click);
            // 
            // btnrli
            // 
            this.btnrli.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnrli.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrli.ForeColor = System.Drawing.Color.Red;
            this.btnrli.Location = new System.Drawing.Point(446, 59);
            this.btnrli.Name = "btnrli";
            this.btnrli.Size = new System.Drawing.Size(130, 44);
            this.btnrli.TabIndex = 4;
            this.btnrli.Text = "Remove last item";
            this.btnrli.UseVisualStyleBackColor = false;
            this.btnrli.Click += new System.EventHandler(this.btnrli_Click);
            // 
            // btnr2li
            // 
            this.btnr2li.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnr2li.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnr2li.ForeColor = System.Drawing.Color.Red;
            this.btnr2li.Location = new System.Drawing.Point(610, 59);
            this.btnr2li.Name = "btnr2li";
            this.btnr2li.Size = new System.Drawing.Size(130, 44);
            this.btnr2li.TabIndex = 5;
            this.btnr2li.Text = "Remove 2nd last item";
            this.btnr2li.UseVisualStyleBackColor = false;
            this.btnr2li.Click += new System.EventHandler(this.btnr2li_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(36, 59);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(329, 24);
            this.CmbDays.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SeaShell;
            this.btnBack.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBack.Location = new System.Drawing.Point(314, 296);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(169, 77);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.btnr2li);
            this.Controls.Add(this.btnrli);
            this.Controls.Add(this.btnrbi);
            this.Controls.Add(this.btnrbn);
            this.Controls.Add(this.btnssm2);
            this.Controls.Add(this.btnssm1);
            this.Name = "FrmCombo";
            this.Text = "Form Combo";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnssm1;
        private System.Windows.Forms.Button btnssm2;
        private System.Windows.Forms.Button btnrbn;
        private System.Windows.Forms.Button btnrbi;
        private System.Windows.Forms.Button btnrli;
        private System.Windows.Forms.Button btnr2li;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button btnBack;
    }
}