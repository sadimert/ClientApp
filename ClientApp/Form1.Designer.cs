
namespace ClientApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.btnKes = new System.Windows.Forms.Button();
            this.txtEkran = new System.Windows.Forms.TextBox();
            this.txtGonder = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(279, 50);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(94, 29);
            this.btnBaglan.TabIndex = 2;
            this.btnBaglan.Text = "baglan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // btnKes
            // 
            this.btnKes.Location = new System.Drawing.Point(391, 50);
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(94, 29);
            this.btnKes.TabIndex = 3;
            this.btnKes.Text = "durdur";
            this.btnKes.UseVisualStyleBackColor = true;
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // txtEkran
            // 
            this.txtEkran.Location = new System.Drawing.Point(27, 109);
            this.txtEkran.Multiline = true;
            this.txtEkran.Name = "txtEkran";
            this.txtEkran.Size = new System.Drawing.Size(304, 95);
            this.txtEkran.TabIndex = 4;
            // 
            // txtGonder
            // 
            this.txtGonder.Location = new System.Drawing.Point(21, 253);
            this.txtGonder.Name = "txtGonder";
            this.txtGonder.Size = new System.Drawing.Size(332, 27);
            this.txtGonder.TabIndex = 5;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(130, 355);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(94, 29);
            this.btnGonder.TabIndex = 6;
            this.btnGonder.Text = "gonder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Client";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtGonder);
            this.Controls.Add(this.txtEkran);
            this.Controls.Add(this.btnKes);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Button btnKes;
        private System.Windows.Forms.TextBox txtEkran;
        private System.Windows.Forms.TextBox txtGonder;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label label2;
    }
}

