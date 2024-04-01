namespace Window_Form
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
            FileName = new Label();
            textFileName = new TextBox();
            buttonSubmit = new Button();
            textDestination = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            button4 = new Button();
            buttonpdf = new Button();
            buttonExcel = new Button();
            buttonWord = new Button();
            SuspendLayout();
            // 
            // FileName
            // 
            FileName.AutoSize = true;
            FileName.Location = new Point(48, 82);
            FileName.Name = "FileName";
            FileName.Size = new Size(67, 15);
            FileName.TabIndex = 0;
            FileName.Text = "Copy from:";
            // 
            // textFileName
            // 
            textFileName.Location = new Point(120, 78);
            textFileName.Name = "textFileName";
            textFileName.Size = new Size(432, 23);
            textFileName.TabIndex = 5;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.FromArgb(0, 62, 0);
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubmit.ForeColor = Color.White;
            buttonSubmit.Location = new Point(147, 124);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(376, 38);
            buttonSubmit.TabIndex = 13;
            buttonSubmit.Text = "Select Folder to be Copied";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += button1_Click;
            // 
            // textDestination
            // 
            textDestination.Location = new Point(120, 186);
            textDestination.Name = "textDestination";
            textDestination.Size = new Size(432, 23);
            textDestination.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 189);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 14;
            label1.Text = "Copy To:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 62, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(147, 232);
            button1.Name = "button1";
            button1.Size = new Size(376, 38);
            button1.TabIndex = 16;
            button1.Text = "Select Path to copy folder into ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 62, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(147, 318);
            button2.Name = "button2";
            button2.Size = new Size(376, 38);
            button2.TabIndex = 17;
            button2.Text = "Initiate Copy ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.FromArgb(0, 62, 0);
            progressBar1.Location = new Point(62, 289);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(490, 23);
            progressBar1.TabIndex = 18;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 62, 0);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(120, 35);
            button4.Name = "button4";
            button4.Size = new Size(100, 25);
            button4.TabIndex = 20;
            button4.Text = "All Files";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // buttonpdf
            // 
            buttonpdf.BackColor = Color.Lavender;
            buttonpdf.FlatStyle = FlatStyle.Flat;
            buttonpdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonpdf.ForeColor = Color.FromArgb(0, 62, 0);
            buttonpdf.Location = new Point(234, 35);
            buttonpdf.Name = "buttonpdf";
            buttonpdf.Size = new Size(100, 25);
            buttonpdf.TabIndex = 21;
            buttonpdf.Text = "Pdf Files";
            buttonpdf.UseVisualStyleBackColor = false;
            buttonpdf.Click += buttonpdf_Click;
            // 
            // buttonExcel
            // 
            buttonExcel.BackColor = Color.Lavender;
            buttonExcel.FlatStyle = FlatStyle.Flat;
            buttonExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExcel.ForeColor = Color.FromArgb(0, 62, 0);
            buttonExcel.Location = new Point(343, 35);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(100, 25);
            buttonExcel.TabIndex = 22;
            buttonExcel.Text = "Excel Files";
            buttonExcel.UseVisualStyleBackColor = false;
            buttonExcel.Click += buttonExcel_Click;
            // 
            // buttonWord
            // 
            buttonWord.BackColor = Color.Lavender;
            buttonWord.FlatStyle = FlatStyle.Flat;
            buttonWord.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonWord.ForeColor = Color.FromArgb(0, 62, 0);
            buttonWord.Location = new Point(456, 35);
            buttonWord.Name = "buttonWord";
            buttonWord.Size = new Size(100, 25);
            buttonWord.TabIndex = 23;
            buttonWord.Text = "Word Files";
            buttonWord.UseVisualStyleBackColor = false;
            buttonWord.Click += buttonWord_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(603, 450);
            Controls.Add(buttonWord);
            Controls.Add(buttonExcel);
            Controls.Add(buttonpdf);
            Controls.Add(button4);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textDestination);
            Controls.Add(label1);
            Controls.Add(buttonSubmit);
            Controls.Add(textFileName);
            Controls.Add(FileName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FileName;
        private TextBox textFileName;
        private Button buttonSubmit;
        private TextBox textDestination;
        private Label label1;
        private Button button1;
        private Button button2;
        private ProgressBar progressBar1;
        private Button button4;
        private Button buttonpdf;
        private Button buttonExcel;
        private Button buttonWord;
    }
}
