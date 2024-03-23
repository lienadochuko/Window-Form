using System.Data;

namespace Window_Form
{
    public partial class Form1 : Form
    {
        DataTable dt =  new DataTable();
        string File_Name;
        string Locations;
        string NewLocation;
        string AlertSet;
        string AdminAccess;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello");
            File_Name = textFileName.Text;
            Locations = textLocation.Text;
            NewLocation = textNewLocation.Text;


            if (True.Checked)
            {
                AlertSet = "True";
            }
            else if (False.Checked)
            {
                AlertSet = "False";
            }
            else
            {
                AlertSet = "UnChecked";
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

            //Display.Text = FileName + " " + Location + " " + NewLocation + " " + Alert + " " + AdminAccess;
            display();
        }

        public void display()
        {
            dt.Columns.Add("FileName");
            dt.Columns.Add("Location");
            dt.Columns.Add("NewLocation");
            dt.Columns.Add("Alert");
            dt.Columns.Add("AdminAccess");

            DataRow dr = dt.NewRow();
            dr["FileName"] = File_Name;
            dr["Location"] = Locations;
            dr["NewLocation"] = NewLocation;
            dr["Alert"] = AlertSet;
            dr["AdminAccess"] = AdminAccess;

            dt.Rows.Add(dr);
            dataGridView.DataSource = dt;
        }

        public void empty()
        {
            textFileName.Text = "";
            textLocation.Text = "";
            textNewLocation.Text = "";
        }
    }
}
