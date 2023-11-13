namespace WinformPGSQL
{
    partial class TambahMahasiswa
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Nama = new TextBox();
            Nim = new TextBox();
            tambahSimpanButton = new Button();
            Prodi = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
            label1.TabIndex = 0;
            label1.Text = "Tambah Mahasiswa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "NIM : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 130);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Prodi : ";
            // 
            // Nama
            // 
            Nama.Location = new Point(57, 51);
            Nama.Name = "Nama";
            Nama.Size = new Size(208, 23);
            Nama.TabIndex = 4;
            // 
            // Nim
            // 
            Nim.Location = new Point(57, 89);
            Nim.Name = "Nim";
            Nim.Size = new Size(208, 23);
            Nim.TabIndex = 5;
            // 
            // tambahSimpanButton
            // 
            tambahSimpanButton.BackColor = Color.Blue;
            tambahSimpanButton.ForeColor = SystemColors.ControlLightLight;
            tambahSimpanButton.Location = new Point(190, 167);
            tambahSimpanButton.Name = "tambahSimpanButton";
            tambahSimpanButton.Size = new Size(75, 23);
            tambahSimpanButton.TabIndex = 7;
            tambahSimpanButton.Text = "Simpan";
            tambahSimpanButton.UseVisualStyleBackColor = false;
            tambahSimpanButton.Click += tambahSimpanButton_Click;
            // 
            // Prodi
            // 
            Prodi.FormattingEnabled = true;
            Prodi.Location = new Point(57, 129);
            Prodi.Name = "Prodi";
            Prodi.Size = new Size(208, 23);
            Prodi.TabIndex = 8;
            // 
            // TambahMahasiswa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 358);
            Controls.Add(Prodi);
            Controls.Add(tambahSimpanButton);
            Controls.Add(Nim);
            Controls.Add(Nama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TambahMahasiswa";
            Text = "TambahMahasiswa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Nama;
        private TextBox Nim;
        private Button tambahSimpanButton;
        private ComboBox Prodi;
    }
}