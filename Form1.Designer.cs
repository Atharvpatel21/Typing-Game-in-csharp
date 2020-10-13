namespace Typing_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblRight = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.BackColor = System.Drawing.Color.Transparent;
            this.lblRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRight.ForeColor = System.Drawing.Color.White;
            this.lblRight.Location = new System.Drawing.Point(7, 9);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(85, 17);
            this.lblRight.TabIndex = 0;
            this.lblRight.Text = "Correct ; 0";
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.BackColor = System.Drawing.Color.Transparent;
            this.lblWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong.ForeColor = System.Drawing.Color.White;
            this.lblWrong.Location = new System.Drawing.Point(579, 9);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(96, 17);
            this.lblWrong.TabIndex = 1;
            this.lblWrong.Text = "Incorrect ; 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(183, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Press Enter to check in text :";
            // 
            // lblword
            // 
            this.lblword.AutoSize = true;
            this.lblword.BackColor = System.Drawing.Color.Transparent;
            this.lblword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblword.ForeColor = System.Drawing.Color.Cyan;
            this.lblword.Location = new System.Drawing.Point(252, 125);
            this.lblword.Name = "lblword";
            this.lblword.Size = new System.Drawing.Size(112, 39);
            this.lblword.TabIndex = 4;
            this.lblword.Text = "Word ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Aquamarine;
            this.textBox1.Location = new System.Drawing.Point(137, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 45);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckGame);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 343);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.lblRight);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typing Game -Move";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblword;
        private System.Windows.Forms.TextBox textBox1;
    }
}

