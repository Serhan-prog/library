namespace Library_Management_System
{
    partial class IadeAl
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
            dgv_Emanetler = new DataGridView();
            btn_IadeAl = new Button();
            txt_Arama = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Emanetler).BeginInit();
            SuspendLayout();
            // 
            // dgv_Emanetler
            // 
            dgv_Emanetler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Emanetler.Location = new Point(12, 188);
            dgv_Emanetler.Name = "dgv_Emanetler";
            dgv_Emanetler.Size = new Size(776, 250);
            dgv_Emanetler.TabIndex = 0;
            // 
            // btn_IadeAl
            // 
            btn_IadeAl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_IadeAl.Location = new Point(280, 107);
            btn_IadeAl.Name = "btn_IadeAl";
            btn_IadeAl.Size = new Size(88, 37);
            btn_IadeAl.TabIndex = 1;
            btn_IadeAl.Text = "İade Al";
            btn_IadeAl.UseVisualStyleBackColor = true;
            btn_IadeAl.Click += btn_IadeAl_Click;
            // 
            // txt_Arama
            // 
            txt_Arama.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_Arama.Location = new Point(131, 51);
            txt_Arama.Name = "txt_Arama";
            txt_Arama.Size = new Size(100, 29);
            txt_Arama.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(90, 54);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 3;
            label1.Text = "Ara";
            // 
            // IadeAl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txt_Arama);
            Controls.Add(btn_IadeAl);
            Controls.Add(dgv_Emanetler);
            Name = "IadeAl";
            Text = "IadeAl";
            Load += IadeAl_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Emanetler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Emanetler;
        private Button btn_IadeAl;
        private TextBox txt_Arama;
        private Label label1;
    }
}