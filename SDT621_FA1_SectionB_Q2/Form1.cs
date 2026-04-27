namespace SDT621_FA1_SectionB_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbCitizen.Items.AddRange(new string[] { "South African", "Permanent Resident", "Visitor" });
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string id = txtID.Text.Trim();
            string citizenship = cbCitizen.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(citizenship))
            {
                labelValid.Text = "Please fill in all fields.";
                return;
            }

            CitizenProfile profile = new CitizenProfile(name, id, citizenship);
            labelValid.Text = profile.ValidateID();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string id = txtID.Text.Trim();
            string citizenship = cbCitizen.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(citizenship))
            {
                lbOutput.Items.Clear();
                lbOutput.Items.Add("Please fill in all fields before generating profile.");
                return;
            }

            CitizenProfile profile = new CitizenProfile(name, id, citizenship);
            string validation = profile.ValidateID();
            string timestamp = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            lbOutput.Items.Clear();
            lbOutput.Items.Add("==== DIGITAL CITIZEN SUMMARY ====");
            lbOutput.Items.Add("Name: " + profile.FullName);
            lbOutput.Items.Add("ID Number: " + profile.IDNumber);
            lbOutput.Items.Add("Age: " + profile.Age);
            lbOutput.Items.Add("Citizenship: " + profile.CitizenshipStatus);
            lbOutput.Items.Add("Validation: " + validation);
            lbOutput.Items.Add("Processed at: Home Affairs Digital Desk");
            lbOutput.Items.Add("Timestamp: " + timestamp);
        }
    }
}
