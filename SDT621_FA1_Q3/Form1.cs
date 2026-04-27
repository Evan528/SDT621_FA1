namespace SDT621_FA1_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string language = txtInput.Text.Trim();

            
            if (string.IsNullOrEmpty(language))
            {
                MessageBox.Show("Please enter a programming language.");
                return;
            }

           
            if (lbOutput.Items.Contains(language))
            {
                MessageBox.Show("This language is already in the list.");
                return;
            }

           
            lbOutput.Items.Add(language);

            
            txtInput.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            if (lbOutput.SelectedItem == null)
            {
                MessageBox.Show("Please select a language to remove.");
                return;
            }

            string removedItem = lbOutput.SelectedItem.ToString();

           
            lbOutput.Items.Remove(removedItem);

           
            Label_removed.Text = $"Removed '{removedItem}' at {DateTime.Now}";
        }
    }
}
