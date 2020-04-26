namespace Lab1_arch
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
            this.tbN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btR = new System.Windows.Forms.Button();
            this.btT = new System.Windows.Forms.Button();
            this.tbR = new System.Windows.Forms.TextBox();
            this.tbT = new System.Windows.Forms.TextBox();
            this.btnp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(12, 25);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 20);
            this.tbN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите N";
            // 
            // btR
            // 
            this.btR.Location = new System.Drawing.Point(12, 51);
            this.btR.Name = "btR";
            this.btR.Size = new System.Drawing.Size(304, 23);
            this.btR.TabIndex = 2;
            this.btR.Text = "Посчитать интеграл методом прямоугольников";
            this.btR.UseVisualStyleBackColor = true;
            this.btR.Click += new System.EventHandler(this.btR_Click);
            // 
            // btT
            // 
            this.btT.Location = new System.Drawing.Point(12, 89);
            this.btT.Name = "btT";
            this.btT.Size = new System.Drawing.Size(304, 23);
            this.btT.TabIndex = 3;
            this.btT.Text = "Посчитать интеграл методом трапеций";
            this.btT.UseVisualStyleBackColor = true;
            this.btT.Click += new System.EventHandler(this.btT_Click);
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(334, 54);
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(275, 20);
            this.tbR.TabIndex = 4;
            // 
            // tbT
            // 
            this.tbT.Location = new System.Drawing.Point(334, 91);
            this.tbT.Name = "tbT";
            this.tbT.Size = new System.Drawing.Size(275, 20);
            this.tbT.TabIndex = 5;
            // 
            // btnp
            // 
            this.btnp.Location = new System.Drawing.Point(349, 23);
            this.btnp.Name = "btnp";
            this.btnp.Size = new System.Drawing.Size(75, 23);
            this.btnp.TabIndex = 6;
            this.btnp.Text = "Пепук";
            this.btnp.UseVisualStyleBackColor = true;
            this.btnp.Click += new System.EventHandler(this.btnp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 246);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(118, 25);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 8;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(224, 25);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Введите B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnp);
            this.Controls.Add(this.tbT);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.btT);
            this.Controls.Add(this.btR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbN);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btR;
        private System.Windows.Forms.Button btT;
        public System.Windows.Forms.TextBox tbN;
        public System.Windows.Forms.TextBox tbR;
        public System.Windows.Forms.TextBox tbT;
        private System.Windows.Forms.Button btnp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

