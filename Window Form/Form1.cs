namespace Window_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FileName;
            string Location;
            string NewLocation;
            string Alert;
            string AdminAccess;
            //MessageBox.Show("Hello");
            FileName = textFileName.Text;
            Location = textLocation.Text;
            NewLocation = textNewLocation.Text;


            if (True.Checked)
            {
                Alert = "True";
            }
            else if (False.Checked)
            {
                Alert = "False";
            }
            else
            {
                Alert = "UnChecked";
            }
            if (checkAdmin_Access.Checked)
            {
                AdminAccess = "True";
            }
            else if (checkRestricted_Access.Checked)
            {
                AdminAccess = "True";
            }
            else
            {
                AdminAccess = "UnChecked";
            }

            Display.Text = FileName + " " + Location + " " + NewLocation + " " + Alert + " " + AdminAccess;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
