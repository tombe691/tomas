using System;
using System.Windows.Forms;

namespace Assignment4Win
{
    /// <summary>
    /// Main form class
    /// </summary>
    public partial class MainForm : Form
    {
        Party party;
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        /// <summary>
        /// Method to set GUI defaults
        /// </summary>
        private void InitializeGUI()
        {
            lblNumGuests.Text = string.Empty;
            lblTotalCost.Text = "0.0";
            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            lstAllGuests.Items.Clear();

            grpAddGuests.Enabled = false;
            grpNewParty.Enabled = true;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// When clicking create a new party is created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateList_Click(object sender, EventArgs e)
        {
            bool maxNumOK = CreateParty();
            if (!maxNumOK)
                return;

            bool amountOK = ReadCostPerPerson();

            if (maxNumOK && amountOK)
            {
                grpAddGuests.Enabled = true;
                UpdateGUI();
            }
        }
        /// <summary>
        /// A party is stored in an vector with the size entered
        /// </summary>
        /// <returns></returns>
        private bool CreateParty()
        {
            int maxNumber = 0;
            bool ok = true;

            if (int.TryParse(txtMaxNum.Text, out maxNumber) && (maxNumber > 0))
            {
                party = new Party(maxNumber);
                MessageBox.Show($"Party list with space for {maxNumber} guests created!", "Success");
            }
            else
            {
                MessageBox.Show("Invalid Total Number. Please try again!", "Error");
                ok = false;
            }
            return ok;
        }
        /// <summary>
        /// Check if cost per person is correct
        /// </summary>
        /// <returns></returns>
        private bool ReadCostPerPerson()
        {
            //double instead?
            int amount = 0;
            bool value = false;
            if (int.TryParse(txtAmount.Text, out amount) && (amount > 0))
            {
                value = true;
                party.CostPerCapita = amount;
            }
            return value;
        }
        /// <summary>
        /// GUI updates after each change
        /// </summary>
        private void UpdateGUI()
        {
            lstAllGuests.Items.Clear();
            string[] guestList = party.GetGuestList();
            if (guestList != null)
            {
                for (int i = 0; i < guestList.Length; i++)
                {
                    string str = $"{i + 1,4} {guestList[i],-20}";
                    lstAllGuests.Items.Add(str);
                }
            }
            else
                return;

            double totalCost = party.CalcTotalCost();
           lblTotalCost.Text = totalCost.ToString("0.00");
            lblNumGuests.Text = party.Count.ToString();
        }
        /// <summary>
        /// add new person to party
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TrimNames())
            {
                bool ok = party.AddNewGuest(txtFirstName.Text, txtLastName.Text);
                if (!ok)
                    MessageBox.Show("List is full! New guest not added!", "Error");
                else
                    UpdateGUI();
            }
        }
        /// <summary>
        /// method to trim names
        /// </summary>
        /// <returns></returns>
        private bool TrimNames()
        {
            if ((!ValidateText(txtFirstName.Text)) ||
                (!ValidateText(txtLastName.Text))
                )
                return false;

            txtFirstName.Text = txtFirstName.Text.Trim();
            txtLastName.Text = txtLastName.Text.Trim();
            return true;
        }
        /// <summary>
        /// method to validate the text is filled in for first and last name
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private bool ValidateText(string text)
        {
            text = text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please provide both the first name and the second name.", "Error");
                return false;
            }
            return true;
        }

        private void lblTotalCost_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// method for delete selected button action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            int index = lstAllGuests.SelectedIndex;
            party.DeleteAt(index);
            UpdateGUI();
        }
        /// <summary>
        /// method to change selected value in list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            int index = lstAllGuests.SelectedIndex;
            party.ChangeAt(index, txtFirstName.Text, txtLastName.Text);
            UpdateGUI();
        }
    }
}
