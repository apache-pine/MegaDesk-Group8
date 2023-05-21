using System;
using System.Windows.Forms;

namespace MegaDesk_Group8
{
    // Represents the form for displaying a quote
    public partial class DisplayQuote : Form
    {
        private Form _mainMenu;

        // Constructor for the DisplayQuote class
        public DisplayQuote(Form mainMenu, DeskQuote deskQuote)
        {
            InitializeComponent();
            _mainMenu = mainMenu;

            // Set the values of the text boxes with the data from the DeskQuote object
            customerNameTextBox.Text = deskQuote.CustomerName;
            quoteDateTextBox.Text = deskQuote.QuoteDate.ToString();
            quotePriceTextBox.Text = deskQuote.QuotePrice.ToString("C");

            // Calculate the surface area and append the units to the text
            int surfaceArea = deskQuote.Desk.DeskWidth * deskQuote.Desk.DeskDepth;
            surfaceAreaTextBox.Text = $"{surfaceArea} in²";

            // Get the enum value of the desktop material and display its name
            DesktopMaterial material = (DesktopMaterial)deskQuote.Desk.DesktopMaterial;
            desktopMaterialTextBox.Text = Enum.GetName(typeof(DesktopMaterial), material);

            numDrawersTextBox.Text = deskQuote.Desk.NumDrawers.ToString();
        }

        // Event handler for the close button click
        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form
            Close();
        }

        // Event handler for the FormClosing event
        private void DisplayQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show the main menu form when the DisplayQuote form is closing
            _mainMenu.Show();
        }
    }
}
