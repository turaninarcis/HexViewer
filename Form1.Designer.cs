namespace HexViewer
{
    partial class HexViewer
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
            this.button1 = new System.Windows.Forms.Button();
            this.HexViewerTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HexViewerTextBox
            // 
            this.HexViewerTextBox.Font = new System.Drawing.Font("Courier New", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HexViewerTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.HexViewerTextBox.Location = new System.Drawing.Point(12, 54);
            this.HexViewerTextBox.Multiline = true;
            this.HexViewerTextBox.Name = "HexViewerTextBox";
            this.HexViewerTextBox.ReadOnly = true;
            this.HexViewerTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HexViewerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HexViewerTextBox.Size = new System.Drawing.Size(1186, 571);
            this.HexViewerTextBox.TabIndex = 1;
            this.HexViewerTextBox.TextChanged += new System.EventHandler(this.HexViewerTextBox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(181, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1017, 36);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0  1  2  3  4  5  6  7  8  9  A  B  C  D  E  F  |0123456789ABCDEF\r\n";
            // 
            // HexViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 637);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.HexViewerTextBox);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HexViewer";
            this.Text = "Hex Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox HexViewerTextBox;
        private TextBox textBox1;
    }
}