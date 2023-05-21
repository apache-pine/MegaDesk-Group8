using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MegaDesk_Group8
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();

            // Call the method to load the grid when the form is initialized
            loadGrid();
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show the main menu form when this form is closing
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
        }

        private string GetEnumDescription(Enum value)
        {
            // Get the field info for the enum value
            FieldInfo field = value.GetType().GetField(value.ToString());

            // Get the description attribute of the field, if available
            DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();

            // Return the description attribute value if found, otherwise the string representation of the enum value
            return attribute != null ? attribute.Description : value.ToString();
        }

        private void loadGrid()
        {
            // File path for the quotes JSON file
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                // Read the entire contents of the quotes JSON file
                string quotes = reader.ReadToEnd();
                // Deserialize the JSON data into a list of DeskQuote objects
                List<DeskQuote> deskQuotes = System.Text.Json.JsonSerializer.Deserialize<List<DeskQuote>>(quotes);

                // Set the DataGridView's data source with the required properties from the DeskQuote objects
                dataGridView1.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.QuoteDate,
                    Customer = d.CustomerName,
                    Depth = d.Desk.DeskDepth,
                    Width = d.Desk.DeskWidth,
                    Drawers = d.Desk.NumDrawers,
                    SurfaceMaterial = d.Desk.DesktopMaterial,
                    RushOrder = GetEnumDescription(d.RushOrder),
                    QuotePrice = d.QuotePrice.ToString("C")
                }).ToList();
            }
        }
    }
}
