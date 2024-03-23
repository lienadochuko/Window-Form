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
            Location = new Label();
            New_Location = new Label();
            Alert = new Label();
            Admin_Access = new Label();
            textFileName = new TextBox();
            textLocation = new TextBox();
            textNewLocation = new TextBox();
            True = new RadioButton();
            False = new RadioButton();
            checkAdmin_Access = new CheckBox();
            checkRestricted_Access = new CheckBox();
            Display = new Label();
            buttonSubmit = new Button();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // FileName
            // 
            FileName.AutoSize = true;
            FileName.Location = new Point(40, 32);
            FileName.Name = "FileName";
            FileName.Size = new Size(57, 15);
            FileName.TabIndex = 0;
            FileName.Text = "FileName";
            // 
            // Location
            // 
            Location.AutoSize = true;
            Location.Location = new Point(40, 63);
            Location.Name = "Location";
            Location.Size = new Size(53, 15);
            Location.TabIndex = 1;
            Location.Text = "Location";
            // 
            // New_Location
            // 
            New_Location.AutoSize = true;
            New_Location.Location = new Point(40, 94);
            New_Location.Name = "New_Location";
            New_Location.Size = new Size(80, 15);
            New_Location.TabIndex = 2;
            New_Location.Text = "New Location";
            // 
            // Alert
            // 
            Alert.AutoSize = true;
            Alert.Location = new Point(40, 125);
            Alert.Name = "Alert";
            Alert.Size = new Size(32, 15);
            Alert.TabIndex = 3;
            Alert.Text = "Alert";
            // 
            // Admin_Access
            // 
            Admin_Access.AutoSize = true;
            Admin_Access.Location = new Point(40, 155);
            Admin_Access.Name = "Admin_Access";
            Admin_Access.Size = new Size(82, 15);
            Admin_Access.TabIndex = 4;
            Admin_Access.Text = "Admin Access";
            // 
            // textFileName
            // 
            textFileName.Location = new Point(136, 29);
            textFileName.Name = "textFileName";
            textFileName.Size = new Size(432, 23);
            textFileName.TabIndex = 5;
            // 
            // textLocation
            // 
            textLocation.Location = new Point(136, 58);
            textLocation.Name = "textLocation";
            textLocation.Size = new Size(432, 23);
            textLocation.TabIndex = 6;
            // 
            // textNewLocation
            // 
            textNewLocation.Location = new Point(137, 89);
            textNewLocation.Name = "textNewLocation";
            textNewLocation.Size = new Size(432, 23);
            textNewLocation.TabIndex = 7;
            // 
            // True
            // 
            True.AutoSize = true;
            True.Location = new Point(140, 121);
            True.Name = "True";
            True.Size = new Size(47, 19);
            True.TabIndex = 8;
            True.TabStop = true;
            True.Text = "True";
            True.UseVisualStyleBackColor = true;
            // 
            // False
            // 
            False.AutoSize = true;
            False.Location = new Point(212, 121);
            False.Name = "False";
            False.Size = new Size(51, 19);
            False.TabIndex = 9;
            False.TabStop = true;
            False.Text = "False";
            False.UseVisualStyleBackColor = true;
            // 
            // checkAdmin_Access
            // 
            checkAdmin_Access.AutoSize = true;
            checkAdmin_Access.Location = new Point(141, 151);
            checkAdmin_Access.Name = "checkAdmin_Access";
            checkAdmin_Access.Size = new Size(101, 19);
            checkAdmin_Access.TabIndex = 10;
            checkAdmin_Access.Text = "Admin Access";
            checkAdmin_Access.UseVisualStyleBackColor = true;
            // 
            // checkRestricted_Access
            // 
            checkRestricted_Access.AutoSize = true;
            checkRestricted_Access.Location = new Point(258, 151);
            checkRestricted_Access.Name = "checkRestricted_Access";
            checkRestricted_Access.Size = new Size(117, 19);
            checkRestricted_Access.TabIndex = 11;
            checkRestricted_Access.Text = "Restricted Access";
            checkRestricted_Access.UseVisualStyleBackColor = true;
            // 
            // Display
            // 
            Display.AutoSize = true;
            Display.Location = new Point(40, 193);
            Display.Name = "Display";
            Display.Size = new Size(45, 15);
            Display.TabIndex = 12;
            Display.Text = "Display";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(176, 225);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(376, 38);
            buttonSubmit.TabIndex = 13;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += button1_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(37, 301);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(531, 136);
            dataGridView.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 450);
            Controls.Add(dataGridView);
            Controls.Add(buttonSubmit);
            Controls.Add(Display);
            Controls.Add(checkRestricted_Access);
            Controls.Add(checkAdmin_Access);
            Controls.Add(False);
            Controls.Add(True);
            Controls.Add(textNewLocation);
            Controls.Add(textLocation);
            Controls.Add(textFileName);
            Controls.Add(Admin_Access);
            Controls.Add(Alert);
            Controls.Add(New_Location);
            Controls.Add(Location);
            Controls.Add(FileName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FileName;
        private Label Location;
        private Label New_Location;
        private Label Alert;
        private Label Admin_Access;
        private TextBox textFileName;
        private TextBox textLocation;
        private TextBox textNewLocation;
        private RadioButton True;
        private RadioButton False;
        private CheckBox checkAdmin_Access;
        private CheckBox checkRestricted_Access;
        private Label Display;
        private Button buttonSubmit;
        private DataGridView dataGridView;
    }
}
