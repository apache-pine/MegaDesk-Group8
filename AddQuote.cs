using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.IO;
using System.Data;

namespace MegaDesk_Group8
{
    // Represents the form for adding a quote
    public partial class AddQuote : Form
    {
        private Form _mainMenu;

        // Variables to store user inputs
        int deskWidth = 0;
        int deskDepth = 0;
        int numDrawers = 0;
        DesktopMaterial desktopMaterial;
        int rushOrder;
        string customerName = "";
        Desk newDesk;
        DeskQuote newQuote;

        // Constructor for the AddQuote form
        public AddQuote(Form mainMenu)
        {
            InitializeComponent();

            // Set up the desktop material combo box
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            desktopMaterialComboBox.DataSource = materials;
            desktopMaterialComboBox.SelectedIndex = -1;

            _mainMenu = mainMenu;

            // Set up the rush order combo box
            List<Delivery> deliveryList = Enum.GetValues(typeof(Delivery)).Cast<Delivery>().ToList();
            List<string> deliveryDescription = new List<string>();

            foreach (Delivery delivery in deliveryList)
            {
                var description = GetDescription(delivery);
                deliveryDescription.Add(description);
            }

            rushOrderComboBox.DataSource = deliveryDescription;
            rushOrderComboBox.SelectedIndex = -1;

            // Clear the numeric up-down controls
            widthNumericUpDown.Text = String.Empty;
            depthNumericUpDown.Text = String.Empty;
            numDrawerNumericUpDown.Text = String.Empty;

            // Disable the Get Quote button initially
            getQuoteButton.Enabled = false;
        }

        // Event handler for the cancel button click
        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Close the form
            Close();
        }

        // Event handler for the FormClosing event
        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show the main menu form when the AddQuote form is closing
            _mainMenu.Show();
        }

        // Event handler for the get quote button click
        private void getQuoteButton_Click(object sender, EventArgs e)
        {
            // Create a new desk object with user inputs
            var desk = new Desk
            {
                DeskDepth = (int)depthNumericUpDown.Value,
                DeskWidth = (int)widthNumericUpDown.Value,
                NumDrawers = (int)numDrawerNumericUpDown.Value,
                DesktopMaterial = (DesktopMaterial)desktopMaterialComboBox.SelectedValue
            };

            // Create a new desk quote object with user inputs
            var deskQuote = new DeskQuote
            {
                Desk = desk,
                CustomerName = customerNameInput.Text,
                QuoteDate = DateTime.Now,
                RushOrder = (Delivery)rushOrderComboBox.SelectedIndex
            };

            try
            {
                // Calculate the quote price and save the quote
                var price = deskQuote.GetQuotePrice();
                deskQuote.QuotePrice = price;
                addQuoteToFile(deskQuote);

                // Show the DisplayQuote form with the quote details
                DisplayQuote displayQuoteForm = new DisplayQuote(_mainMenu, deskQuote);
                displayQuoteForm.Show();
                Hide();
            }
            catch (Exception err)
            {
                // Display an error message if there was an error creating the quote
                MessageBox.Show("There was an error creating the quote. {0}", err.InnerException.ToString());
            }
        }

        // Method to add the quote to the quotes file
        private void addQuoteToFile(DeskQuote deskQuote)
        {
            var quotesFile = @"quotes.json";
            List<DeskQuote> deskQuotes = new List<DeskQuote>();

            if (File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    string quotes = reader.ReadToEnd();

                    if (quotes.Length > 0)
                    {
                        deskQuotes = System.Text.Json.JsonSerializer.Deserialize<List<DeskQuote>>(quotes);
                    }
                }
            }
            deskQuotes.Add(deskQuote);

            SaveQuotes(deskQuotes);
        }

        // Method to save the quotes to the quotes file
        private void SaveQuotes(List<DeskQuote> quotes)
        {
            var quotesFile = @"quotes.json";
            var serializedQuotes = System.Text.Json.JsonSerializer.Serialize(quotes);
            File.WriteAllText(quotesFile, serializedQuotes);
        }

        // Method to get the description of an enum value
        private string GetDescription(Enum GenericEnum)
        {
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());

            if (memberInfo != null && memberInfo.Length > 0)
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (_Attribs != null && _Attribs.Count() > 0)
                {
                    return ((DescriptionAttribute)_Attribs.ElementAt(0)).Description;
                }
            }

            return GenericEnum.ToString();
        }

        // Event handler for the text changed event of customerNameInput
        private void customerNameInput_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        // Event handler for the selected index changed event of desktopMaterialComboBox
        private void desktopMaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        // Event handler for the selected index changed event of rushOrderComboBox
        private void rushOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        // Event handler for the value changed event of widthNumericUpDown
        private void widthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        // Event handler for the value changed event of depthNumericUpDown
        private void depthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        // Event handler for the value changed event of numDrawerNumericUpDown
        private void numDrawerNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        // Method to validate all inputs and enable/disable the Get Quote button accordingly
        private void ValidateInputs()
        {
            if (!string.IsNullOrWhiteSpace(customerNameInput.Text) &&
                desktopMaterialComboBox.SelectedIndex >= 0 &&
                rushOrderComboBox.SelectedIndex >= 0 &&
                widthNumericUpDown.Text != string.Empty &&
                depthNumericUpDown.Text != string.Empty &&
                widthNumericUpDown.Value >= Desk.DESK_MIN_WIDTH &&
                widthNumericUpDown.Value <= Desk.DESK_MAX_WIDTH &&
                depthNumericUpDown.Value >= Desk.DESK_MIN_DEPTH &&
                depthNumericUpDown.Value <= Desk.DESK_MAX_DEPTH &&
                numDrawerNumericUpDown.Value >= 0)
            {
                getQuoteButton.Enabled = true;
            }
            else
            {
                getQuoteButton.Enabled = false;
            }
        }
    }
}
