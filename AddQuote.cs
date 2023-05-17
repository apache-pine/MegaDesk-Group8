﻿using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;


namespace MegaDesk_Group8
{
    public partial class AddQuote : Form
    {
        int deskWidth = 0;
        int deskDepth = 0;
        int numDrawers = 0;
        DesktopMaterial desktopMaterial;
        int rushOrder;
        string customerName = "";
        Desk newDesk;
        DeskQuote newQuote;

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
            deskWidth = (int)widthNumericUpDown.Value;
            deskDepth = (int)depthNumericUpDown.Value;
            numDrawers = (int)numDrawerNumericUpDown.Value;
            desktopMaterial = (DesktopMaterial)desktopMaterialComboBox.SelectedValue;
            rushOrder = rushOrderComboBox.SelectedIndex;
            customerName = customerNameInput.Text;
            decimal quotePrice = newQuote.GetQuotePrice(deskWidth, deskDepth, numDrawers, desktopMaterial, rushOrder);

            if (customerName == string.Empty)
            {
                customerNameInput.BackColor = Color.Red;
                customerNameInput.Focus();
            }
            else
            {
                newDesk = new Desk(deskWidth, deskDepth, numDrawers, desktopMaterial);
                newQuote = new DeskQuote(customerName, rushOrder, quotePrice, newDesk);



                DisplayQuote viewDisplayQuote = new DisplayQuote();
                viewDisplayQuote.Tag = this;
                viewDisplayQuote.Show(this);
                Hide();
            }
        }
    }
}
