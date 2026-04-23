namespace Library_Management_System
{
    partial class EmanetVer
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
            cmb_Uye = new ComboBox();
            cmb_Kitap = new ComboBox();
            dtp_IadeTarihi = new DateTimePicker();
            btn_EmanetVer = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cmb_Uye
            // 
            cmb_Uye.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cmb_Uye.FormattingEnabled = true;
            cmb_Uye.Location = new Point(112, 75);
            cmb_Uye.Name = "cmb_Uye";
            cmb_Uye.Size = new Size(121, 29);
            cmb_Uye.TabIndex = 0;
            // 
            // cmb_Kitap
            // 
            cmb_Kitap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cmb_Kitap.FormattingEnabled = true;
            cmb_Kitap.Location = new Point(112, 124);
            cmb_Kitap.Name = "cmb_Kitap";
            cmb_Kitap.Size = new Size(121, 29);
            cmb_Kitap.TabIndex = 1;
            // 
            // dtp_IadeTarihi
            // 
            dtp_IadeTarihi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dtp_IadeTarihi.Location = new Point(114, 179);
            dtp_IadeTarihi.Name = "dtp_IadeTarihi";
            dtp_IadeTarihi.Size = new Size(240, 29);
            dtp_IadeTarihi.TabIndex = 2;
            // 
            // btn_EmanetVer
            // 
            btn_EmanetVer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_EmanetVer.Location = new Point(209, 265);
            btn_EmanetVer.Name = "btn_EmanetVer";
            btn_EmanetVer.Size = new Size(108, 40);
            btn_EmanetVer.TabIndex = 3;
            btn_EmanetVer.Text = "Ödünç Ver";
            btn_EmanetVer.UseVisualStyleBackColor = true;
            btn_EmanetVer.Click += btn_EmanetVer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(32, 78);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 4;
            label1.Text = "Alıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(25, 127);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 5;
            label2.Text = "Kitap Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(59, 185);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 6;
            label3.Text = "Tarih:";
            // 
            // EmanetVer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_EmanetVer);
            Controls.Add(dtp_IadeTarihi);
            Controls.Add(cmb_Kitap);
            Controls.Add(cmb_Uye);
            Name = "EmanetVer";
            Text = "EmanetVer";
            Load += EmanetVer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_Uye;
        private ComboBox cmb_Kitap;
        private DateTimePicker dtp_IadeTarihi;
        private Button btn_EmanetVer;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}