using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace MegaDesk_Group8
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();

            List<string> desktopMaterial = Enum.GetNames(typeof(DesktopMaterial)).ToList();
            desktopMaterial.Insert(0, "All Materials");

            desktopMaterialComboBox.DataSource = desktopMaterial;

            loadGrid();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {

        }

        private void SearchQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
        }

        private void desktopMaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;

            if (combo.SelectedIndex == 0)
            {
                loadGrid();
            }
            else
            {
                loadGrid(combo.SelectedValue.ToString());
            }
        }

        private void loadGrid()
        {
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = System.Text.Json.JsonSerializer.Deserialize<List<DeskQuote>>(quotes);

                dataGridView1.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.QuoteDate,
                    Customer = d.CustomerName,
                    Depth = d.Desk.DeskDepth,
                    Width = d.Desk.DeskWidth,
                    Drawers = d.Desk.NumDrawers,
                    SurfaceMaterial = d.Desk.DesktopMaterial,
                    RushOrder = d.RushOrder,
                    QuotePrice = d.QuotePrice
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

                dataGridView1.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.QuoteDate,
                    Customer = d.CustomerName,
                    Depth = d.Desk.DeskDepth,
                    Width = d.Desk.DeskWidth,
                    Drawers = d.Desk.NumDrawers,
                    SurfaceMaterial = d.Desk.DesktopMaterial,
                    RushOrder = d.RushOrder,
                    QuotePrice = d.QuotePrice
                }).Where(q => q.SurfaceMaterial == desktopMaterialSelection)
                .ToList();
            }
        }
    }
}
