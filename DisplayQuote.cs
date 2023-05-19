using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Group8
{
    public partial class DisplayQuote : Form
    {
        private Form _mainMenu;
        public DisplayQuote(Form mainMenu, DeskQuote deskQuote)
        {
            InitializeComponent();
            _mainMenu = mainMenu;

            customerNameTextBox.Text = deskQuote.CustomerName;
            quoteDateTextBox.Text = deskQuote.QuoteDate.ToString();
            quotePriceTextBox.Text = deskQuote.QuotePrice.ToString("C");
            surfaceAreaTextBox.Text = (deskQuote.Desk.DeskWidth * deskQuote.Desk.DeskDepth).ToString();
            DesktopMaterial material = (DesktopMaterial)deskQuote.Desk.DesktopMaterial;
            desktopMaterialTextBox.Text = Enum.GetName(typeof(DesktopMaterial), material);
            numDrawersTextBox.Text = deskQuote.Desk.NumDrawers.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
