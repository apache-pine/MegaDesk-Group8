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
            this.GetQuote = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.AddQuoteLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SurfaceMaterialSelect = new System.Windows.Forms.ComboBox();
            this.DeskSize = new System.Windows.Forms.GroupBox();
            this.DepthSelect = new System.Windows.Forms.NumericUpDown();
            this.WidthSelect = new System.Windows.Forms.NumericUpDown();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.SurfaceMaterialLabel = new System.Windows.Forms.Label();
            this.NumDrawerLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.DeliveryLabel = new System.Windows.Forms.Label();
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.NumDrawerSelect = new System.Windows.Forms.NumericUpDown();
            this.DeliverySelect = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.DeskSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepthSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDrawerSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // GetQuote
            // 
            this.GetQuote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GetQuote.Location = new System.Drawing.Point(163, 214);
            this.GetQuote.Name = "GetQuote";
            this.GetQuote.Size = new System.Drawing.Size(144, 40);
            this.GetQuote.TabIndex = 1;
            this.GetQuote.Text = "&Get Quote";
            this.GetQuote.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(342, 214);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(144, 40);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.SurfaceMaterialSelect, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.Cancel, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.AddQuoteLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeskSize, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SurfaceMaterialLabel, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.NumDrawerLabel, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.CustomerNameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DeliveryLabel, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.customerNameInput, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.GetQuote, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.NumDrawerSelect, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.DeliverySelect, 5, 4);
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
            // SurfaceMaterialSelect
            // 
            this.SurfaceMaterialSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SurfaceMaterialSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SurfaceMaterialSelect.FormattingEnabled = true;
            this.SurfaceMaterialSelect.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.SurfaceMaterialSelect.Location = new System.Drawing.Point(492, 118);
            this.SurfaceMaterialSelect.Name = "SurfaceMaterialSelect";
            this.SurfaceMaterialSelect.Size = new System.Drawing.Size(162, 24);
            this.SurfaceMaterialSelect.TabIndex = 5;
            // 
            // DeskSize
            // 
            this.DeskSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.DeskSize, 2);
            this.DeskSize.Controls.Add(this.DepthSelect);
            this.DeskSize.Controls.Add(this.WidthSelect);
            this.DeskSize.Controls.Add(this.DepthLabel);
            this.DeskSize.Controls.Add(this.WidthLabel);
            this.DeskSize.Location = new System.Drawing.Point(53, 83);
            this.DeskSize.Name = "DeskSize";
            this.tableLayoutPanel1.SetRowSpan(this.DeskSize, 3);
            this.DeskSize.Size = new System.Drawing.Size(254, 90);
            this.DeskSize.TabIndex = 5;
            this.DeskSize.TabStop = false;
            this.DeskSize.Text = "Desk Size";
            // 
            // DepthSelect
            // 
            this.DepthSelect.Location = new System.Drawing.Point(90, 56);
            this.DepthSelect.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.DepthSelect.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DepthSelect.Name = "DepthSelect";
            this.DepthSelect.Size = new System.Drawing.Size(120, 22);
            this.DepthSelect.TabIndex = 3;
            this.DepthSelect.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DepthSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthSelect_KeyPress);
            // 
            // WidthSelect
            // 
            this.WidthSelect.Location = new System.Drawing.Point(90, 26);
            this.WidthSelect.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.WidthSelect.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.WidthSelect.Name = "WidthSelect";
            this.WidthSelect.Size = new System.Drawing.Size(120, 22);
            this.WidthSelect.TabIndex = 2;
            this.WidthSelect.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.WidthSelect.Validating += new System.ComponentModel.CancelEventHandler(this.WidthSelect_Validating);
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Location = new System.Drawing.Point(41, 56);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(43, 16);
            this.DepthLabel.TabIndex = 1;
            this.DepthLabel.Text = "Depth";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(43, 28);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(41, 16);
            this.WidthLabel.TabIndex = 0;
            this.WidthLabel.Text = "Width";
            // 
            // SurfaceMaterialLabel
            // 
            this.SurfaceMaterialLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SurfaceMaterialLabel.AutoSize = true;
            this.SurfaceMaterialLabel.Location = new System.Drawing.Point(382, 122);
            this.SurfaceMaterialLabel.Name = "SurfaceMaterialLabel";
            this.SurfaceMaterialLabel.Size = new System.Drawing.Size(104, 16);
            this.SurfaceMaterialLabel.TabIndex = 7;
            this.SurfaceMaterialLabel.Text = "Surface Material";
            this.SurfaceMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumDrawerLabel
            // 
            this.NumDrawerLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NumDrawerLabel.AutoSize = true;
            this.NumDrawerLabel.Location = new System.Drawing.Point(364, 89);
            this.NumDrawerLabel.Name = "NumDrawerLabel";
            this.NumDrawerLabel.Size = new System.Drawing.Size(122, 16);
            this.NumDrawerLabel.TabIndex = 6;
            this.NumDrawerLabel.Text = "Number of Drawers";
            this.NumDrawerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(53, 52);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(104, 16);
            this.CustomerNameLabel.TabIndex = 4;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // DeliveryLabel
            // 
            this.DeliveryLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DeliveryLabel.AutoSize = true;
            this.DeliveryLabel.Location = new System.Drawing.Point(429, 153);
            this.DeliveryLabel.Name = "DeliveryLabel";
            this.DeliveryLabel.Size = new System.Drawing.Size(57, 16);
            this.DeliveryLabel.TabIndex = 8;
            this.DeliveryLabel.Text = "Delivery";
            this.DeliveryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // NumDrawerSelect
            // 
            this.NumDrawerSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumDrawerSelect.Location = new System.Drawing.Point(492, 86);
            this.NumDrawerSelect.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NumDrawerSelect.Name = "NumDrawerSelect";
            this.NumDrawerSelect.Size = new System.Drawing.Size(43, 22);
            this.NumDrawerSelect.TabIndex = 10;
            // 
            // DeliverySelect
            // 
            this.DeliverySelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeliverySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeliverySelect.FormattingEnabled = true;
            this.DeliverySelect.Items.AddRange(new object[] {
            "3 Day",
            "5 Day",
            "7 Day",
            "14 Day (Default)"});
            this.DeliverySelect.Location = new System.Drawing.Point(492, 149);
            this.DeliverySelect.Name = "DeliverySelect";
            this.DeliverySelect.Size = new System.Drawing.Size(162, 24);
            this.DeliverySelect.TabIndex = 11;
            // 
            // AddQuote
            // 
            this.AcceptButton = this.GetQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
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
            this.DeskSize.ResumeLayout(false);
            this.DeskSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepthSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDrawerSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button GetQuote;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label AddQuoteLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.GroupBox DeskSize;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label SurfaceMaterialLabel;
        private System.Windows.Forms.Label DeliveryLabel;
        private System.Windows.Forms.Label NumDrawerLabel;
        private System.Windows.Forms.TextBox customerNameInput;
        private System.Windows.Forms.ComboBox SurfaceMaterialSelect;
        private System.Windows.Forms.NumericUpDown DepthSelect;
        private System.Windows.Forms.NumericUpDown WidthSelect;
        private System.Windows.Forms.NumericUpDown NumDrawerSelect;
        private System.Windows.Forms.ComboBox DeliverySelect;
    }
}