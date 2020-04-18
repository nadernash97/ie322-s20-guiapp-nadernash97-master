namespace class_2
{
    partial class Frmpick01
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
            this.BtnLoadimg = new System.Windows.Forms.Button();
            this.Btnre = new System.Windows.Forms.Button();
            this.Pictry = new System.Windows.Forms.PictureBox();
            this.BtnimagefResource = new System.Windows.Forms.Button();
            this.Pictry1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pictry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pictry1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadimg
            // 
            this.BtnLoadimg.BackColor = System.Drawing.Color.Plum;
            this.BtnLoadimg.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadimg.Location = new System.Drawing.Point(12, 79);
            this.BtnLoadimg.Name = "BtnLoadimg";
            this.BtnLoadimg.Size = new System.Drawing.Size(102, 59);
            this.BtnLoadimg.TabIndex = 0;
            this.BtnLoadimg.Text = "LoadImage";
            this.BtnLoadimg.UseVisualStyleBackColor = false;
            this.BtnLoadimg.Click += new System.EventHandler(this.BtnLoadimg_Click);
            // 
            // Btnre
            // 
            this.Btnre.BackColor = System.Drawing.Color.LightGreen;
            this.Btnre.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnre.ForeColor = System.Drawing.Color.Red;
            this.Btnre.Location = new System.Drawing.Point(350, 379);
            this.Btnre.Name = "Btnre";
            this.Btnre.Size = new System.Drawing.Size(102, 59);
            this.Btnre.TabIndex = 2;
            this.Btnre.Text = "Back";
            this.Btnre.UseVisualStyleBackColor = false;
            this.Btnre.Click += new System.EventHandler(this.Btnre_Click);
            // 
            // Pictry
            // 
            this.Pictry.Location = new System.Drawing.Point(12, 144);
            this.Pictry.Name = "Pictry";
            this.Pictry.Size = new System.Drawing.Size(336, 201);
            this.Pictry.TabIndex = 3;
            this.Pictry.TabStop = false;
            // 
            // BtnimagefResource
            // 
            this.BtnimagefResource.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnimagefResource.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnimagefResource.Location = new System.Drawing.Point(686, 79);
            this.BtnimagefResource.Name = "BtnimagefResource";
            this.BtnimagefResource.Size = new System.Drawing.Size(102, 59);
            this.BtnimagefResource.TabIndex = 4;
            this.BtnimagefResource.Text = "IMage form resource";
            this.BtnimagefResource.UseVisualStyleBackColor = false;
            this.BtnimagefResource.Click += new System.EventHandler(this.BtnimagefResource_Click);
            // 
            // Pictry1
            // 
            this.Pictry1.Location = new System.Drawing.Point(452, 144);
            this.Pictry1.Name = "Pictry1";
            this.Pictry1.Size = new System.Drawing.Size(336, 201);
            this.Pictry1.TabIndex = 5;
            this.Pictry1.TabStop = false;
            // 
            // Frmpick01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pictry1);
            this.Controls.Add(this.BtnimagefResource);
            this.Controls.Add(this.Pictry);
            this.Controls.Add(this.Btnre);
            this.Controls.Add(this.BtnLoadimg);
            this.Name = "Frmpick01";
            this.Text = "Image";
            this.Load += new System.EventHandler(this.Frmpick01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pictry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pictry1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadimg;
        private System.Windows.Forms.Button Btnre;
        private System.Windows.Forms.PictureBox Pictry;
        private System.Windows.Forms.Button BtnimagefResource;
        private System.Windows.Forms.PictureBox Pictry1;
    }
}