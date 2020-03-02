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
            this.btCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(68, 58);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 20);
            this.tbN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите N";
            // 
            // btCalc
            // 
            this.btCalc.Location = new System.Drawing.Point(68, 84);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(119, 23);
            this.btCalc.TabIndex = 2;
            this.btCalc.Text = "Посчитать интеграл";
            this.btCalc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 172);
            this.Controls.Add(this.btCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbN);
            this.Name = "Form1";
            this.Text = "Щукин и Деточенко 3-46";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCalc;
    }
}

