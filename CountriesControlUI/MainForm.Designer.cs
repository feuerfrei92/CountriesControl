namespace CountriesControlUI
{
    partial class MainForm
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
            this.tlp_UserControls = new System.Windows.Forms.TableLayoutPanel();
            this.countriesControl1 = new CountriesControlUI.CountriesControl();
            this.tlp_UserControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_UserControls
            // 
            this.tlp_UserControls.ColumnCount = 1;
            this.tlp_UserControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_UserControls.Controls.Add(this.countriesControl1, 0, 1);
            this.tlp_UserControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UserControls.Location = new System.Drawing.Point(0, 0);
            this.tlp_UserControls.Name = "tlp_UserControls";
            this.tlp_UserControls.RowCount = 2;
            this.tlp_UserControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlp_UserControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_UserControls.Size = new System.Drawing.Size(334, 316);
            this.tlp_UserControls.TabIndex = 0;
            // 
            // countriesControl1
            // 
            this.countriesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countriesControl1.Location = new System.Drawing.Point(3, 4);
            this.countriesControl1.Name = "countriesControl1";
            this.countriesControl1.SelectedCountry = null;
            this.countriesControl1.Size = new System.Drawing.Size(328, 309);
            this.countriesControl1.TabIndex = 0;
            this.countriesControl1.MoveNext += new System.EventHandler(this.countriesControl1_MoveNext);
            this.countriesControl1.MovePrevious += new System.EventHandler(this.countriesControl1_MovePrevious);
            this.countriesControl1.DescriptionChanged += new System.EventHandler(this.countriesControl1_DescriptionChanged);
            this.countriesControl1.CountryDeleted += new System.EventHandler(this.countriesControl1_CountryDeleted);
            this.countriesControl1.RestoreCountries += new System.EventHandler(this.countriesControl1_RestoreCountries);
            this.countriesControl1.Load += new System.EventHandler(this.countriesControl1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 316);
            this.Controls.Add(this.tlp_UserControls);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Countries";
            this.tlp_UserControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_UserControls;
        private CountriesControl countriesControl1;


    }
}

