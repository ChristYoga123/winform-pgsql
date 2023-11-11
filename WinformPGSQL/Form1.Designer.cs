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
            tabelProdi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelProdi).BeginInit();
            SuspendLayout();
            // 
            // tabelProdi
            // 
            tabelProdi.AllowUserToAddRows = false;
            tabelProdi.AllowUserToDeleteRows = false;
            tabelProdi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelProdi.Location = new Point(242, 98);
            tabelProdi.Name = "tabelProdi";
            tabelProdi.ReadOnly = true;
            tabelProdi.RowTemplate.Height = 25;
            tabelProdi.Size = new Size(240, 150);
            tabelProdi.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabelProdi);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tabelProdi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelProdi;
    }
}