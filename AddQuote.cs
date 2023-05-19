using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Reflection;
using System.IO;
using System.Data;
using System.Text.Json;

namespace MegaDesk_Group8
{
    public partial class AddQuote : Form
    {
        private Form _mainMenu;

        int deskWidth = 0;
        int deskDepth = 0;
        int numDrawers = 0;
        DesktopMaterial desktopMaterial;
        int rushOrder;
        string customerName = "";
        Desk newDesk;
        DeskQuote newQuote;

        public AddQuote(Form mainMenu)
        {
            InitializeComponent();

            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            desktopMaterialComboBox.DataSource = materials;

            desktopMaterialComboBox.SelectedIndex = -1;
            _mainMenu = mainMenu;

            List<Delivery> deliveryList = Enum.GetValues(typeof (Delivery)).Cast<Delivery>().ToList();

            List<string> deliveryDescription = new List<string>();

            foreach (Delivery delivery in deliveryList)
            {
                var description = GetDescription(delivery);
                deliveryDescription.Add(description);
            }

            rushOrderComboBox.DataSource = deliveryDescription;

            rushOrderComboBox.SelectedIndex = -1;

            widthNumericUpDown.Text = String.Empty;
            depthNumericUpDown.Text = String.Empty;
            numDrawerNumericUpDown.Text = String.Empty;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainMenu.Show();
        }

        private void getQuoteButton_Click(object sender, EventArgs e)
        {
            var desk = new Desk
            {
                DeskDepth = (int)depthNumericUpDown.Value,
                DeskWidth = (int)widthNumericUpDown.Value,
                NumDrawers = (int)numDrawerNumericUpDown.Value,
                DesktopMaterial = (DesktopMaterial)desktopMaterialComboBox.SelectedValue
            };

            var deskQuote = new DeskQuote
            {
                Desk = desk,
                CustomerName = customerNameInput.Text,
                QuoteDate = DateTime.Now,
                RushOrder = (Delivery)rushOrderComboBox.SelectedIndex
            };

            try
            {
                var price = deskQuote.GetQuotePrice();
                deskQuote.QuotePrice = price;
                addQuoteToFile(deskQuote);
                DisplayQuote displayQuoteForm = new DisplayQuote(_mainMenu, deskQuote);
                displayQuoteForm.Show();
                Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show("There was an error creating the quote. {0}", err.InnerException.ToString());
            }
        }


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

        private void SaveQuotes(List<DeskQuote> quotes)
        {
            var quotesFile = @"quotes.json";

            var serializedQuotes = System.Text.Json.JsonSerializer.Serialize(quotes);

            File.WriteAllText(quotesFile, serializedQuotes);
        }

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
    }
}
