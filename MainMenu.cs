using System;
using System.Windows.Forms;

namespace MegaDesk_Group8
{
    // Represents the main menu form of the application
    public partial class MainMenu : Form
    {
        // Constructor for the MainMenu class
        public MainMenu()
        {
            InitializeComponent();
        }

        // Event handler for the Add New Quote button click
        private void AddNewQuote_Click(object sender, EventArgs e)
        {
            // Create an instance of the AddQuote form
            AddQuote viewAddQuote = new AddQuote(this);

            // Show the AddQuote form
            viewAddQuote.Show();

            // Hide the MainMenu form
            Hide();
        }

        // Event handler for the View Quotes button click
        private void ViewQuotes_Click(object sender, EventArgs e)
        {
            // Create an instance of the ViewAllQuotes form
            ViewAllQuotes viewViewQuotes = new ViewAllQuotes();

            // Set the Tag property of the ViewAllQuotes form to the current MainMenu instance
            viewViewQuotes.Tag = this;

            // Show the ViewAllQuotes form
            viewViewQuotes.Show(this);

            // Hide the MainMenu form
            Hide();
        }

        // Event handler for the Search Quotes button click
        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            // Create an instance of the SearchQuotes form
            SearchQuotes viewSearchQuotes = new SearchQuotes();

            // Set the Tag property of the SearchQuotes form to the current MainMenu instance
            viewSearchQuotes.Tag = this;

            // Show the SearchQuotes form
            viewSearchQuotes.Show(this);

            // Hide the MainMenu form
            Hide();
        }

        // Event handler for the Exit button click
        private void Exit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }
    }
}