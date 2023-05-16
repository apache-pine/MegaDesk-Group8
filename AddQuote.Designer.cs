namespace MegaDesk_Group8
{
    partial class AddQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.getQuoteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.AddQuoteLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.desktopMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.DeskSizeBox = new System.Windows.Forms.GroupBox();
            this.depthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.desktopMaterialLabel = new System.Windows.Forms.Label();
            this.numDrawerLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.rushOrderLabel = new System.Windows.Forms.Label();
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.numDrawerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rushOrderComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.DeskSizeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawerNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // getQuoteButton
            // 
            this.getQuoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.getQuoteButton.Location = new System.Drawing.Point(163, 214);
            this.getQuoteButton.Name = "getQuoteButton";
            this.getQuoteButton.Size = new System.Drawing.Size(144, 40);
            this.getQuoteButton.TabIndex = 1;
            this.getQuoteButton.Text = "&Get Quote";
            this.getQuoteButton.UseVisualStyleBackColor = true;
            this.getQuoteButton.Click += new System.EventHandler(this.getQuoteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(342, 214);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(144, 40);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddQuoteLabel
            // 
            this.AddQuoteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddQuoteLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.AddQuoteLabel, 3);
            this.AddQuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.AddQuoteLabel.Location = new System.Drawing.Point(163, 5);
            this.AddQuoteLabel.Name = "AddQuoteLabel";
            this.AddQuoteLabel.Size = new System.Drawing.Size(323, 29);
            this.AddQuoteLabel.TabIndex = 3;
            this.AddQuoteLabel.Text = "New Quote";
            this.AddQuoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Controls.Add(this.desktopMaterialComboBox, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.AddQuoteLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeskSizeBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.desktopMaterialLabel, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.numDrawerLabel, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.customerNameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rushOrderLabel, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.customerNameInput, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.getQuoteButton, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.numDrawerNumericUpDown, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.rushOrderComboBox, 5, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 293);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // desktopMaterialComboBox
            // 
            this.desktopMaterialComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.desktopMaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.desktopMaterialComboBox.FormattingEnabled = true;
            this.desktopMaterialComboBox.Location = new System.Drawing.Point(492, 118);
            this.desktopMaterialComboBox.Name = "desktopMaterialComboBox";
            this.desktopMaterialComboBox.Size = new System.Drawing.Size(162, 24);
            this.desktopMaterialComboBox.TabIndex = 5;
            // 
            // DeskSizeBox
            // 
            this.DeskSizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.DeskSizeBox, 2);
            this.DeskSizeBox.Controls.Add(this.depthNumericUpDown);
            this.DeskSizeBox.Controls.Add(this.widthNumericUpDown);
            this.DeskSizeBox.Controls.Add(this.depthLabel);
            this.DeskSizeBox.Controls.Add(this.widthLabel);
            this.DeskSizeBox.Location = new System.Drawing.Point(53, 83);
            this.DeskSizeBox.Name = "DeskSizeBox";
            this.tableLayoutPanel1.SetRowSpan(this.DeskSizeBox, 3);
            this.DeskSizeBox.Size = new System.Drawing.Size(254, 90);
            this.DeskSizeBox.TabIndex = 5;
            this.DeskSizeBox.TabStop = false;
            this.DeskSizeBox.Text = "Desk Size";
            // 
            // depthNumericUpDown
            // 
            this.depthNumericUpDown.Location = new System.Drawing.Point(90, 56);
            this.depthNumericUpDown.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthNumericUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthNumericUpDown.Name = "depthNumericUpDown";
            this.depthNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.depthNumericUpDown.TabIndex = 3;
            this.depthNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthNumericUpDown_KeyPress);
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.Location = new System.Drawing.Point(90, 26);
            this.widthNumericUpDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthNumericUpDown.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.widthNumericUpDown.TabIndex = 2;
            this.widthNumericUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthNumericUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.widthNumericUpDown_Validating);
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(41, 56);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(43, 16);
            this.depthLabel.TabIndex = 1;
            this.depthLabel.Text = "Depth";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(43, 28);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(41, 16);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Width";
            // 
            // desktopMaterialLabel
            // 
            this.desktopMaterialLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.desktopMaterialLabel.AutoSize = true;
            this.desktopMaterialLabel.Location = new System.Drawing.Point(377, 122);
            this.desktopMaterialLabel.Name = "desktopMaterialLabel";
            this.desktopMaterialLabel.Size = new System.Drawing.Size(109, 16);
            this.desktopMaterialLabel.TabIndex = 7;
            this.desktopMaterialLabel.Text = "Desktop Material";
            this.desktopMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numDrawerLabel
            // 
            this.numDrawerLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numDrawerLabel.AutoSize = true;
            this.numDrawerLabel.Location = new System.Drawing.Point(364, 89);
            this.numDrawerLabel.Name = "numDrawerLabel";
            this.numDrawerLabel.Size = new System.Drawing.Size(122, 16);
            this.numDrawerLabel.TabIndex = 6;
            this.numDrawerLabel.Text = "Number of Drawers";
            this.numDrawerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(53, 52);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(104, 16);
            this.customerNameLabel.TabIndex = 4;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // rushOrderLabel
            // 
            this.rushOrderLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rushOrderLabel.AutoSize = true;
            this.rushOrderLabel.Location = new System.Drawing.Point(411, 153);
            this.rushOrderLabel.Name = "rushOrderLabel";
            this.rushOrderLabel.Size = new System.Drawing.Size(75, 16);
            this.rushOrderLabel.TabIndex = 8;
            this.rushOrderLabel.Text = "Rush Order";
            this.rushOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerNameInput
            // 
            this.customerNameInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.customerNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.customerNameInput, 3);
            this.customerNameInput.Location = new System.Drawing.Point(163, 49);
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Size = new System.Drawing.Size(266, 22);
            this.customerNameInput.TabIndex = 9;
            // 
            // numDrawerNumericUpDown
            // 
            this.numDrawerNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numDrawerNumericUpDown.Location = new System.Drawing.Point(492, 86);
            this.numDrawerNumericUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numDrawerNumericUpDown.Name = "numDrawerNumericUpDown";
            this.numDrawerNumericUpDown.Size = new System.Drawing.Size(43, 22);
            this.numDrawerNumericUpDown.TabIndex = 10;
            // 
            // rushOrderComboBox
            // 
            this.rushOrderComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rushOrderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rushOrderComboBox.FormattingEnabled = true;
            this.rushOrderComboBox.Items.AddRange(new object[] {
            "3 Day",
            "5 Day",
            "7 Day",
            "14 Day (Default)"});
            this.rushOrderComboBox.Location = new System.Drawing.Point(492, 149);
            this.rushOrderComboBox.Name = "rushOrderComboBox";
            this.rushOrderComboBox.Size = new System.Drawing.Size(162, 24);
            this.rushOrderComboBox.TabIndex = 11;
            // 
            // AddQuote
            // 
            this.AcceptButton = this.getQuoteButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 344);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(734, 391);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(734, 391);
            this.Name = "AddQuote";
            this.Text = "Add New Quote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddQuote_FormClosing);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.DeskSizeBox.ResumeLayout(false);
            this.DeskSizeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawerNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button getQuoteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label AddQuoteLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.GroupBox DeskSizeBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label desktopMaterialLabel;
        private System.Windows.Forms.Label rushOrderLabel;
        private System.Windows.Forms.Label numDrawerLabel;
        private System.Windows.Forms.TextBox customerNameInput;
        private System.Windows.Forms.ComboBox desktopMaterialComboBox;
        private System.Windows.Forms.NumericUpDown depthNumericUpDown;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.NumericUpDown numDrawerNumericUpDown;
        private System.Windows.Forms.ComboBox rushOrderComboBox;
    }
}