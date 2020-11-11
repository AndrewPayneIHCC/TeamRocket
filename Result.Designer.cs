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
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Cyan;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(116, 182);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(99, 20);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Your Score";
            // 
            // lblHScore
            // 
            this.lblHScore.AutoSize = true;
            this.lblHScore.BackColor = System.Drawing.Color.Cyan;
            this.lblHScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHScore.Location = new System.Drawing.Point(116, 227);
            this.lblHScore.Name = "lblHScore";
            this.lblHScore.Size = new System.Drawing.Size(98, 20);
            this.lblHScore.TabIndex = 2;
            this.lblHScore.Text = "High Score";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Cyan;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(271, 381);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 36);
            this.button8.TabIndex = 13;
            this.button8.Text = "Return";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Cyan;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(449, 381);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 36);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lblScoreNum
            // 
            this.lblScoreNum.Location = new System.Drawing.Point(288, 176);
            this.lblScoreNum.Name = "lblScoreNum";
            this.lblScoreNum.Size = new System.Drawing.Size(100, 23);
            this.lblScoreNum.TabIndex = 15;
            // 
            // lblHighNum
            // 
            this.lblHighNum.Location = new System.Drawing.Point(280, 232);
            this.lblHighNum.Name = "lblHighNum";
            this.lblHighNum.Size = new System.Drawing.Size(100, 23);
            this.lblHighNum.TabIndex = 16;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(589, 450);
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
    }
}