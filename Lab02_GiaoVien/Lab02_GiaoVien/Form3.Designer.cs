
namespace Lab02_GiaoVien
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdSDT = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdMaGV = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdSDT);
            this.groupBox1.Controls.Add(this.rdHoTen);
            this.groupBox1.Controls.Add(this.rdMaGV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(139, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo";
            // 
            // rdSDT
            // 
            this.rdSDT.AutoSize = true;
            this.rdSDT.Location = new System.Drawing.Point(329, 35);
            this.rdSDT.Name = "rdSDT";
            this.rdSDT.Size = new System.Drawing.Size(140, 24);
            this.rdSDT.TabIndex = 2;
            this.rdSDT.TabStop = true;
            this.rdSDT.Text = "Số điện thoại";
            this.rdSDT.UseVisualStyleBackColor = true;
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Location = new System.Drawing.Point(177, 35);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(91, 24);
            this.rdHoTen.TabIndex = 1;
            this.rdHoTen.TabStop = true;
            this.rdHoTen.Text = "Họ Tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            // 
            // rdMaGV
            // 
            this.rdMaGV.AutoSize = true;
            this.rdMaGV.Location = new System.Drawing.Point(31, 35);
            this.rdMaGV.Name = "rdMaGV";
            this.rdMaGV.Size = new System.Drawing.Size(87, 24);
            this.rdMaGV.TabIndex = 0;
            this.rdMaGV.TabStop = true;
            this.rdMaGV.Text = "Mã GV";
            this.rdMaGV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã GV";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(187, 172);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(421, 22);
            this.txtTim.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Red;
            this.btnOK.Location = new System.Drawing.Point(652, 159);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 46);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 240);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Tìm thông tin GV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdSDT;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdMaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnOK;
    }
}