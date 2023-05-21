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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();

            // Populate the desktopMaterialComboBox with the available desktop materials
            List<string> desktopMaterial = Enum.GetNames(typeof(DesktopMaterial)).ToList();
            desktopMaterial.Insert(0, "All Materials");
            desktopMaterialComboBox.DataSource = desktopMaterial;

            // Load the grid with all quotes when the form is initialized
            loadGrid();
        }

        private void SearchQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show the main menu form when this form is closing
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
        }

        private void desktopMaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;

            if (combo.SelectedIndex == 0)
            {
                // Load the grid with all quotes when "All Materials" is selected
                loadGrid();
            }
            else
            {
                // Load the grid with quotes filtered by the selected desktop material
                loadGrid(combo.SelectedValue.ToString());
            }
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
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
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

        private void loadGrid(string desktopMaterial)
        {
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = System.Text.Json.JsonSerializer.Deserialize<List<DeskQuote>>(quotes);

                DesktopMaterial desktopMaterialSelection = (DesktopMaterial)Enum.Parse(typeof(DesktopMaterial), desktopMaterial);

                // Set the DataGridView's data source with the required properties from the DeskQuote objects,
                // filtered by the selected desktop material
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
                }).Where(q => q.SurfaceMaterial == desktopMaterialSelection)
                .ToList();
            }
        }
    }
}
