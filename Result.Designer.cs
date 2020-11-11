namespace NotJeopardy
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHScore = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblScoreNum = new System.Windows.Forms.Label();
            this.lblHighNum = new System.Windows.Forms.Label();
            this.btnAgain = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.White;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(64, 112);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 20);
            this.lblScore.TabIndex = 0;
            // 
            // lblHScore
            // 
            this.lblHScore.AutoSize = true;
            this.lblHScore.BackColor = System.Drawing.Color.White;
            this.lblHScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHScore.Location = new System.Drawing.Point(64, 152);
            this.lblHScore.Name = "lblHScore";
            this.lblHScore.Size = new System.Drawing.Size(0, 20);
            this.lblHScore.TabIndex = 2;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(9, 405);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 36);
            this.button8.TabIndex = 13;
            this.button8.Text = "Return";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(477, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 36);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lblScoreNum
            // 
            this.lblScoreNum.Location = new System.Drawing.Point(192, 114);
            this.lblScoreNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScoreNum.Name = "lblScoreNum";
            this.lblScoreNum.Size = new System.Drawing.Size(67, 15);
            this.lblScoreNum.TabIndex = 15;
            // 
            // lblHighNum
            // 
            this.lblHighNum.Location = new System.Drawing.Point(187, 151);
            this.lblHighNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHighNum.Name = "lblHighNum";
            this.lblHighNum.Size = new System.Drawing.Size(67, 15);
            this.lblHighNum.TabIndex = 16;
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(72, 232);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(75, 23);
            this.btnAgain.TabIndex = 17;
            this.btnAgain.Text = "Play Again?";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(240, 240);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(393, 292);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.lblHighNum);
            this.Controls.Add(this.lblScoreNum);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.lblHScore);
            this.Controls.Add(this.lblScore);
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHScore;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblScoreNum;
        private System.Windows.Forms.Label lblHighNum;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Button btnClose;
    }
}