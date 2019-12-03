namespace YilanOyunu
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
            this.components = new System.ComponentModel.Container();
            this.yilan1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.yilan2 = new System.Windows.Forms.Label();
            this.yilan3 = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yilan1
            // 
            this.yilan1.BackColor = System.Drawing.Color.White;
            this.yilan1.Location = new System.Drawing.Point(320, 320);
            this.yilan1.Name = "yilan1";
            this.yilan1.Size = new System.Drawing.Size(19, 19);
            this.yilan1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(667, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // yilan2
            // 
            this.yilan2.BackColor = System.Drawing.Color.White;
            this.yilan2.Location = new System.Drawing.Point(300, 320);
            this.yilan2.Name = "yilan2";
            this.yilan2.Size = new System.Drawing.Size(19, 19);
            this.yilan2.TabIndex = 2;
            // 
            // yilan3
            // 
            this.yilan3.BackColor = System.Drawing.Color.White;
            this.yilan3.Location = new System.Drawing.Point(280, 320);
            this.yilan3.Name = "yilan3";
            this.yilan3.Size = new System.Drawing.Size(19, 19);
            this.yilan3.TabIndex = 3;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.ForeColor = System.Drawing.Color.White;
            this.lblSkor.Location = new System.Drawing.Point(12, 9);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(13, 13);
            this.lblSkor.TabIndex = 4;
            this.lblSkor.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.yilan3);
            this.Controls.Add(this.yilan2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yilan1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yilan1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label yilan2;
        private System.Windows.Forms.Label yilan3;
        private System.Windows.Forms.Label lblSkor;
    }
}

