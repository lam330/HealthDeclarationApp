
namespace First_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckb_temp = new System.Windows.Forms.CheckBox();
            this.ckb_cough = new System.Windows.Forms.CheckBox();
            this.ckb_headache = new System.Windows.Forms.CheckBox();
            this.pb_QR = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_getData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(224, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health Declaration App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.AccessibleName = "submit_btn";
            this.btn_submit.AutoSize = true;
            this.btn_submit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_submit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Location = new System.Drawing.Point(134, 390);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(94, 31);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_name
            // 
            this.tb_name.AccessibleName = "name_tb";
            this.tb_name.Location = new System.Drawing.Point(104, 128);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(182, 32);
            this.tb_name.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address:";
            // 
            // tb_age
            // 
            this.tb_age.AccessibleName = "name_tb";
            this.tb_age.Location = new System.Drawing.Point(104, 182);
            this.tb_age.Multiline = true;
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(182, 32);
            this.tb_age.TabIndex = 7;
            // 
            // tb_address
            // 
            this.tb_address.AccessibleName = "name_tb";
            this.tb_address.Location = new System.Drawing.Point(104, 235);
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(182, 32);
            this.tb_address.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(60, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Do you have signs of illness below?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ckb_temp
            // 
            this.ckb_temp.AutoSize = true;
            this.ckb_temp.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ckb_temp.Location = new System.Drawing.Point(82, 321);
            this.ckb_temp.Name = "ckb_temp";
            this.ckb_temp.Size = new System.Drawing.Size(73, 38);
            this.ckb_temp.TabIndex = 10;
            this.ckb_temp.Text = "High temp";
            this.ckb_temp.UseVisualStyleBackColor = true;
            // 
            // ckb_cough
            // 
            this.ckb_cough.AutoSize = true;
            this.ckb_cough.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ckb_cough.Location = new System.Drawing.Point(159, 321);
            this.ckb_cough.Name = "ckb_cough";
            this.ckb_cough.Size = new System.Drawing.Size(50, 38);
            this.ckb_cough.TabIndex = 11;
            this.ckb_cough.Text = "Cough";
            this.ckb_cough.UseVisualStyleBackColor = true;
            // 
            // ckb_headache
            // 
            this.ckb_headache.AutoSize = true;
            this.ckb_headache.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ckb_headache.Location = new System.Drawing.Point(215, 321);
            this.ckb_headache.Name = "ckb_headache";
            this.ckb_headache.Size = new System.Drawing.Size(72, 38);
            this.ckb_headache.TabIndex = 12;
            this.ckb_headache.Text = "Headache";
            this.ckb_headache.UseVisualStyleBackColor = true;
            // 
            // pb_QR
            // 
            this.pb_QR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_QR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_QR.ErrorImage = null;
            this.pb_QR.InitialImage = global::First_GUI.Properties.Resources.websiteQRCode_noFrame;
            this.pb_QR.Location = new System.Drawing.Point(437, 76);
            this.pb_QR.Name = "pb_QR";
            this.pb_QR.Size = new System.Drawing.Size(283, 309);
            this.pb_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_QR.TabIndex = 13;
            this.pb_QR.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(116, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Personal information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(535, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "QR code";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_getData
            // 
            this.btn_getData.AutoSize = true;
            this.btn_getData.Location = new System.Drawing.Point(752, 391);
            this.btn_getData.Name = "btn_getData";
            this.btn_getData.Size = new System.Drawing.Size(151, 29);
            this.btn_getData.TabIndex = 17;
            this.btn_getData.Text = "get epidamic area data";
            this.btn_getData.UseVisualStyleBackColor = true;
            this.btn_getData.Click += new System.EventHandler(this.btn_getData_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_submit;
            this.AccessibleName = "content_lb";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 452);
            this.Controls.Add(this.btn_getData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pb_QR);
            this.Controls.Add(this.ckb_headache);
            this.Controls.Add(this.ckb_cough);
            this.Controls.Add(this.ckb_temp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Health Declaration App";
            ((System.ComponentModel.ISupportInitialize)(this.pb_QR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckb_temp;
        private System.Windows.Forms.CheckBox ckb_cough;
        private System.Windows.Forms.CheckBox ckb_headache;
        private System.Windows.Forms.PictureBox pb_QR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_getData;
    }
}

