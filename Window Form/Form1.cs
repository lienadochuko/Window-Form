using System.Data;

namespace Window_Form
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        string File_Name;
        string Locations;
        string NewLocation;
        string AlertSet;
        string AdminAccess;
        FolderBrowserDialog ofd = new FolderBrowserDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            textFileName.Text = ofd.SelectedPath;
            display();
        }

        public void display()
        {
        }

        public void empty()
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            textDestination.Text = ofd.SelectedPath;
            display();
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
                string[] files = Directory.GetFiles(sourceFolder);
                string[] files1 = Directory.GetFiles(sourceFolder,);
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
    }
}
