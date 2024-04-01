using System.Data;

namespace Window_Form
{
    public partial class Form1 : Form
    {
        string filter;
        string filter1;
        string filter2;
        string filter3;

        int totalFiles;

        FolderBrowserDialog ofd = new FolderBrowserDialog();

        public Form1()
        {
            InitializeComponent();
            filter = "";
            filter1 = "";
            filter2 = "";
            filter3 = "";
            button2.Enabled = false;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            textFileName.Text = ofd.SelectedPath;
            button1.Enabled = true;
        }

        public void empty()
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            textDestination.Text = ofd.SelectedPath;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the source and destination folder paths
                string sourceFolder = textFileName.Text;
                string destinationFolder = textDestination.Text;

                // Check if source and destination folders are valid
                if (!Directory.Exists(sourceFolder) || !Directory.Exists(destinationFolder))
                {
                    MessageBox.Show("Source or destination folder does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Copy all files from source folder to destination folder
                // Get the list of files in the source folder

                if (filter1 == "" || filter2 == "" || filter3 == "")
                {
                    string[] files = Directory.GetFiles(sourceFolder, filter);
                    totalFiles = files.Length;
                    progressBar1.Maximum = totalFiles;
                    progressBar1.Value = 0;


                    // Copy each file from the source folder to the destination folder
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        string destFilePath = Path.Combine(destinationFolder, fileName);

                        File.Copy(file, destFilePath, true);

                        // Update the progress bar value
                        progressBar1.Value++;
                    }
                }
                else
                {
                    if (filter2 == "")
                    {
                        string[] files = Directory.GetFiles(sourceFolder, filter);
                        string[] files1 = Directory.GetFiles(sourceFolder, filter1);

                        string[] Totalfiles = files.Concat(files1).ToArray(); ;
                        totalFiles = Totalfiles.Length;
                        progressBar1.Maximum = totalFiles;
                        progressBar1.Value = 0;


                        // Copy each file from the source folder to the destination folder
                        foreach (string file in Totalfiles)
                        {
                            string fileName = Path.GetFileName(file);
                            string destFilePath = Path.Combine(destinationFolder, fileName);

                            File.Copy(file, destFilePath, true);

                            // Update the progress bar value
                            progressBar1.Value++;
                        }
                    }

                    else
                    {
                        if(filter3 == "")
                        {
                            string[] files = Directory.GetFiles(sourceFolder, filter);
                            string[] files1 = Directory.GetFiles(sourceFolder, filter1);
                            string[] files2 = Directory.GetFiles(sourceFolder, filter2);

                            string[] Totalfiles = files.Concat(files1).Concat(files2).ToArray(); ;
                            totalFiles = Totalfiles.Length;
                            progressBar1.Maximum = totalFiles;
                            progressBar1.Value = 0;


                            // Copy each file from the source folder to the destination folder
                            foreach (string file in Totalfiles)
                            {
                                string fileName = Path.GetFileName(file);
                                string destFilePath = Path.Combine(destinationFolder, fileName);

                                File.Copy(file, destFilePath, true);

                                // Update the progress bar value
                                progressBar1.Value++;
                            }
                        }
                        else
                        {
                            string[] files = Directory.GetFiles(sourceFolder, filter);
                            string[] files1 = Directory.GetFiles(sourceFolder, filter1);
                            string[] files2 = Directory.GetFiles(sourceFolder, filter2);
                            string[] files3 = Directory.GetFiles(sourceFolder, filter3);

                            string[] Totalfiles = files.Concat(files1).Concat(files2).Concat(files3).ToArray(); ;
                            totalFiles = Totalfiles.Length;
                            progressBar1.Maximum = totalFiles;
                            progressBar1.Value = 0;


                            // Copy each file from the source folder to the destination folder
                            foreach (string file in Totalfiles)
                            {
                                string fileName = Path.GetFileName(file);
                                string destFilePath = Path.Combine(destinationFolder, fileName);

                                File.Copy(file, destFilePath, true);

                                // Update the progress bar value
                                progressBar1.Value++;
                            }
                        }
                    }
                }

                MessageBox.Show("Files copied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error copying files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the source and destination folder paths
                string sourceFolder = textFileName.Text;
                string destinationFolder = textDestination.Text;

                // Check if source and destination folders are valid
                if (!Directory.Exists(sourceFolder) || !Directory.Exists(destinationFolder))
                {
                    MessageBox.Show("Source or destination folder does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] files = Directory.GetFiles(sourceFolder, "*.xlsx", (SearchOption)SortOrder.Ascending);
                int totalFiles = files.Length;
                progressBar1.Maximum = totalFiles;
                progressBar1.Value = 0;

                // Copy each file from the source folder to the destination folder
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string destFilePath = Path.Combine(destinationFolder, fileName);
                    File.Copy(file, destFilePath, true);

                    // Update the progress bar value
                    progressBar1.Value++;
                }

                MessageBox.Show("Files copied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error copying files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(0, 62, 0);
            button4.ForeColor = Color.White;

            //pdf buttton
            buttonpdf.BackColor = Color.Lavender;
            buttonpdf.ForeColor = Color.FromArgb(0, 62, 0);

            //excel button
            buttonExcel.BackColor = Color.Lavender;
            buttonExcel.ForeColor = Color.FromArgb(0, 62, 0);

            //word button
            buttonWord.BackColor = Color.Lavender;
            buttonWord.ForeColor = Color.FromArgb(0, 62, 0);

            filter = "";
            filter1 = "";
            filter2 = "";
            filter3 = "";
        }

        private void buttonpdf_Click(object sender, EventArgs e)
        {
            //All button
            button4.BackColor = Color.Lavender;
            button4.ForeColor = Color.FromArgb(0, 62, 0);

            //pdf buttton
            buttonpdf.BackColor = Color.FromArgb(0, 62, 0);
            buttonpdf.ForeColor = Color.White;

            //excel button
            buttonExcel.BackColor = Color.Lavender;
            buttonExcel.ForeColor = Color.FromArgb(0, 62, 0);

            //word button
            buttonWord.BackColor = Color.Lavender;
            buttonWord.ForeColor = Color.FromArgb(0, 62, 0);

            filter = "*.pdf";
            filter1 = "";
            filter2 = "";
            filter3 = "";
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            //All button
            button4.BackColor = Color.Lavender;
            button4.ForeColor = Color.FromArgb(0, 62, 0);

            //pdf buttton
            buttonpdf.BackColor = Color.Lavender;
            buttonpdf.ForeColor = Color.FromArgb(0, 62, 0);

            //excel button
            buttonExcel.BackColor = Color.FromArgb(0, 62, 0);
            buttonExcel.ForeColor = Color.White;

            //word button
            buttonWord.BackColor = Color.Lavender;
            buttonWord.ForeColor = Color.FromArgb(0, 62, 0);

            filter = "*.xlsx";
            filter1 = "*.xls";
            filter2 = "*.xml";
            filter3 = "*.xlsm";
        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            //All button
            button4.BackColor = Color.Lavender;
            button4.ForeColor = Color.FromArgb(0, 62, 0);

            //pdf buttton
            buttonpdf.BackColor = Color.Lavender;
            buttonpdf.ForeColor = Color.FromArgb(0, 62, 0);

            //excel button
            buttonExcel.BackColor = Color.Lavender;
            buttonExcel.ForeColor = Color.FromArgb(0, 62, 0);

            //word button
            buttonWord.BackColor = Color.FromArgb(0, 62, 0);
            buttonWord.ForeColor = Color.White;

            filter = "*.docx";
            filter1 = "*.doc";
            filter2 = "*.txt";
            filter3 = "";
        }
    }
}
