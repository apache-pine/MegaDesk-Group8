namespace MegaDesk_Group8
{
    partial class SearchQuotes
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
            this.desktopMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.desktopMaterialLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // desktopMaterialComboBox
            // 
            this.desktopMaterialComboBox.FormattingEnabled = true;
            this.desktopMaterialComboBox.Location = new System.Drawing.Point(373, 44);
            this.desktopMaterialComboBox.Name = "desktopMaterialComboBox";
            this.desktopMaterialComboBox.Size = new System.Drawing.Size(121, 24);
            this.desktopMaterialComboBox.TabIndex = 0;
            // 
            // desktopMaterialLabel
            // 
            this.desktopMaterialLabel.AutoSize = true;
            this.desktopMaterialLabel.Location = new System.Drawing.Point(242, 47);
            this.desktopMaterialLabel.Name = "desktopMaterialLabel";
            this.desktopMaterialLabel.Size = new System.Drawing.Size(109, 16);
            this.desktopMaterialLabel.TabIndex = 1;
            this.desktopMaterialLabel.Text = "Desktop Material";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.desktopMaterialLabel);
            this.Controls.Add(this.desktopMaterialComboBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchQuotes_FormClosing);
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox desktopMaterialComboBox;
        private System.Windows.Forms.Label desktopMaterialLabel;
    }
}