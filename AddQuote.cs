using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace MegaDesk_Group8
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
        }
        private void WidthSelect_Validating(object sender, CancelEventArgs e)
        {
            int width;
            bool isNumeric = int.TryParse(WidthSelect.Text, out width);

            if (!isNumeric || width < Desk.MINWIDTH || width > Desk.MAXWIDTH)
            {
                WidthSelect.BackColor = Color.Red;
                e.Cancel = true;
                WidthSelect.Focus();
            }
            else
            {
                WidthSelect.BackColor = Color.White;
            }
        }

        private void DepthSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            DeliverySelect.SelectedIndex = 3;
        }
    }
}
