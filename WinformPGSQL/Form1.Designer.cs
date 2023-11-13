namespace WinformPGSQL
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
            tabelMahasiswa = new DataGridView();
            label1 = new Label();
            tambahButton = new Button();
            ((System.ComponentModel.ISupportInitialize)tabelMahasiswa).BeginInit();
            SuspendLayout();
            // 
            // tabelMahasiswa
            // 
            tabelMahasiswa.AllowUserToAddRows = false;
            tabelMahasiswa.AllowUserToDeleteRows = false;
            tabelMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelMahasiswa.Location = new Point(107, 74);
            tabelMahasiswa.Name = "tabelMahasiswa";
            tabelMahasiswa.ReadOnly = true;
            tabelMahasiswa.RowTemplate.Height = 25;
            tabelMahasiswa.Size = new Size(594, 309);
            tabelMahasiswa.TabIndex = 0;
            tabelMahasiswa.CellContentClick += tabelMahasiswa_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(260, 9);
            label1.Name = "label1";
            label1.Size = new Size(302, 15);
            label1.TabIndex = 1;
            label1.Text = "SELAMAT DATANG DI PROGRAM CRUD MAHASISWA";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tambahButton
            // 
            tambahButton.BackColor = Color.Blue;
            tambahButton.ForeColor = SystemColors.ControlLightLight;
            tambahButton.Location = new Point(107, 40);
            tambahButton.Name = "tambahButton";
            tambahButton.Size = new Size(152, 28);
            tambahButton.TabIndex = 2;
            tambahButton.Text = "+ Tambah Mahasiswa";
            tambahButton.UseVisualStyleBackColor = false;
            tambahButton.Click += tambahButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tambahButton);
            Controls.Add(label1);
            Controls.Add(tabelMahasiswa);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tabelMahasiswa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabelMahasiswa;
        private Label label1;
        private Button tambahButton;
    }
}