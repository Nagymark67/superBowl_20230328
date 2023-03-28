namespace superBowl
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
            this.btn_irany = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_romai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_arab = new System.Windows.Forms.TextBox();
            this.cmd_atvalt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_irany
            // 
            this.btn_irany.Location = new System.Drawing.Point(245, 46);
            this.btn_irany.Name = "btn_irany";
            this.btn_irany.Size = new System.Drawing.Size(75, 23);
            this.btn_irany.TabIndex = 0;
            this.btn_irany.Text = "--->";
            this.btn_irany.UseVisualStyleBackColor = true;
            this.btn_irany.Click += new System.EventHandler(this.btn_irany_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Római szám [I - X]:";
            // 
            // txt_romai
            // 
            this.txt_romai.Location = new System.Drawing.Point(47, 78);
            this.txt_romai.Name = "txt_romai";
            this.txt_romai.Size = new System.Drawing.Size(106, 23);
            this.txt_romai.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arab szám [1 - 10]:";
            // 
            // txt_arab
            // 
            this.txt_arab.Enabled = false;
            this.txt_arab.Location = new System.Drawing.Point(413, 79);
            this.txt_arab.Name = "txt_arab";
            this.txt_arab.Size = new System.Drawing.Size(105, 23);
            this.txt_arab.TabIndex = 4;
            // 
            // cmd_atvalt
            // 
            this.cmd_atvalt.Location = new System.Drawing.Point(245, 107);
            this.cmd_atvalt.Name = "cmd_atvalt";
            this.cmd_atvalt.Size = new System.Drawing.Size(75, 23);
            this.cmd_atvalt.TabIndex = 5;
            this.cmd_atvalt.Text = "Átvált";
            this.cmd_atvalt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 142);
            this.Controls.Add(this.cmd_atvalt);
            this.Controls.Add(this.txt_arab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_romai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_irany);
            this.Name = "Form1";
            this.Text = "Átváltó";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_irany;
        private Label label1;
        private TextBox txt_romai;
        private Label label2;
        private TextBox txt_arab;
        private Button cmd_atvalt;
    }
}