namespace TeamRock
{
    partial class Final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Final));
            this.LblFinalCat = new System.Windows.Forms.Label();
            this.lblFinalPoint = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblFinalCat
            // 
            this.LblFinalCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFinalCat.Location = new System.Drawing.Point(232, 40);
            this.LblFinalCat.Name = "LblFinalCat";
            this.LblFinalCat.Size = new System.Drawing.Size(232, 96);
            this.LblFinalCat.TabIndex = 0;
            this.LblFinalCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinalPoint
            // 
            this.lblFinalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPoint.Location = new System.Drawing.Point(280, 152);
            this.lblFinalPoint.Name = "lblFinalPoint";
            this.lblFinalPoint.Size = new System.Drawing.Size(144, 72);
            this.lblFinalPoint.TabIndex = 1;
            this.lblFinalPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Let\'s Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(717, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFinalPoint);
            this.Controls.Add(this.LblFinalCat);
            this.Name = "Final";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final";
            this.Load += new System.EventHandler(this.Final_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblFinalCat;
        private System.Windows.Forms.Label lblFinalPoint;
        private System.Windows.Forms.Button button1;
    }
}