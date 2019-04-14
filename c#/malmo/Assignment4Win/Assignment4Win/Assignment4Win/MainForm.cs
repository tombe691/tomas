using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4Win
{
    public partial class MainForm : Form
    {
        Party party;
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

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
        // complete with more code here
        private bool ReadCostPerPerson()
        {
            double amount = 0.0;
            bool value = true;
            return value;
        }
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
    }
}
