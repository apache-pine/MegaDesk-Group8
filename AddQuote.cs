using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace MegaDesk_Group8
{
    public partial class AddQuote : Form
    {

        public AddQuote()
        {
            InitializeComponent();

            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            desktopMaterialComboBox.DataSource = materials;
        }

        private void cancelButton_Click(object sender, EventArgs e)
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
        private void widthNumericUpDown_Validating(object sender, CancelEventArgs e)
        {
            int width;
            bool isNumeric = int.TryParse(widthNumericUpDown.Text, out width);

            if (!isNumeric || width < Desk.DeskMinWidth || width > Desk.DeskMaxWidth)
            {
                widthNumericUpDown.BackColor = Color.Red;
                e.Cancel = true;
                widthNumericUpDown.Focus();
            }
            else
            {
                widthNumericUpDown.BackColor = Color.White;
            }
        }

        private void depthNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            rushOrderComboBox.SelectedIndex = 3;
        }

        private void getQuoteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
