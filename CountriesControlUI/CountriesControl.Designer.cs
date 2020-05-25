namespace CountriesControlUI
{
    partial class CountriesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.pb_Flag = new System.Windows.Forms.PictureBox();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_Capital = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.flp_Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_UndoDelete = new System.Windows.Forms.Button();
            this.lbl_CountryName = new System.Windows.Forms.Label();
            this.lbl_CapitalName = new System.Windows.Forms.Label();
            this.tlp_Description = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.btn_ChangeDescription = new System.Windows.Forms.Button();
            this.tlp_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Flag)).BeginInit();
            this.flp_Buttons.SuspendLayout();
            this.tlp_Description.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 2;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_Main.Controls.Add(this.pb_Flag, 0, 0);
            this.tlp_Main.Controls.Add(this.lbl_Country, 0, 1);
            this.tlp_Main.Controls.Add(this.lbl_Capital, 0, 2);
            this.tlp_Main.Controls.Add(this.lbl_Description, 0, 3);
            this.tlp_Main.Controls.Add(this.flp_Buttons, 0, 4);
            this.tlp_Main.Controls.Add(this.lbl_CountryName, 1, 1);
            this.tlp_Main.Controls.Add(this.lbl_CapitalName, 1, 2);
            this.tlp_Main.Controls.Add(this.tlp_Description, 1, 3);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 5;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.88372F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.28239F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Main.Size = new System.Drawing.Size(328, 323);
            this.tlp_Main.TabIndex = 0;
            // 
            // pb_Flag
            // 
            this.tlp_Main.SetColumnSpan(this.pb_Flag, 2);
            this.pb_Flag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Flag.Location = new System.Drawing.Point(3, 3);
            this.pb_Flag.Name = "pb_Flag";
            this.pb_Flag.Size = new System.Drawing.Size(322, 90);
            this.pb_Flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Flag.TabIndex = 0;
            this.pb_Flag.TabStop = false;
            // 
            // lbl_Country
            // 
            this.lbl_Country.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Location = new System.Drawing.Point(3, 105);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(43, 13);
            this.lbl_Country.TabIndex = 1;
            this.lbl_Country.Text = "Country";
            // 
            // lbl_Capital
            // 
            this.lbl_Capital.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Capital.AutoSize = true;
            this.lbl_Capital.Location = new System.Drawing.Point(3, 137);
            this.lbl_Capital.Name = "lbl_Capital";
            this.lbl_Capital.Size = new System.Drawing.Size(39, 13);
            this.lbl_Capital.TabIndex = 2;
            this.lbl_Capital.Text = "Capital";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(3, 163);
            this.lbl_Description.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(60, 13);
            this.lbl_Description.TabIndex = 3;
            this.lbl_Description.Text = "Description";
            // 
            // flp_Buttons
            // 
            this.tlp_Main.SetColumnSpan(this.flp_Buttons, 2);
            this.flp_Buttons.Controls.Add(this.btn_Previous);
            this.flp_Buttons.Controls.Add(this.btn_Next);
            this.flp_Buttons.Controls.Add(this.btn_Delete);
            this.flp_Buttons.Controls.Add(this.btn_UndoDelete);
            this.flp_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_Buttons.Location = new System.Drawing.Point(3, 275);
            this.flp_Buttons.Name = "flp_Buttons";
            this.flp_Buttons.Size = new System.Drawing.Size(322, 45);
            this.flp_Buttons.TabIndex = 4;
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(3, 3);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(75, 23);
            this.btn_Previous.TabIndex = 0;
            this.btn_Previous.Text = "<- Prev";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(84, 3);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "Next ->";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(165, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_UndoDelete
            // 
            this.btn_UndoDelete.Location = new System.Drawing.Point(246, 3);
            this.btn_UndoDelete.Name = "btn_UndoDelete";
            this.btn_UndoDelete.Size = new System.Drawing.Size(60, 23);
            this.btn_UndoDelete.TabIndex = 3;
            this.btn_UndoDelete.Text = "UndoDelete";
            this.btn_UndoDelete.UseVisualStyleBackColor = true;
            this.btn_UndoDelete.Click += new System.EventHandler(this.btn_UndoDelete_Click);
            // 
            // lbl_CountryName
            // 
            this.lbl_CountryName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_CountryName.AutoSize = true;
            this.lbl_CountryName.Location = new System.Drawing.Point(134, 105);
            this.lbl_CountryName.Name = "lbl_CountryName";
            this.lbl_CountryName.Size = new System.Drawing.Size(0, 13);
            this.lbl_CountryName.TabIndex = 5;
            // 
            // lbl_CapitalName
            // 
            this.lbl_CapitalName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_CapitalName.AutoSize = true;
            this.lbl_CapitalName.Location = new System.Drawing.Point(134, 137);
            this.lbl_CapitalName.Name = "lbl_CapitalName";
            this.lbl_CapitalName.Size = new System.Drawing.Size(0, 13);
            this.lbl_CapitalName.TabIndex = 6;
            // 
            // tlp_Description
            // 
            this.tlp_Description.ColumnCount = 1;
            this.tlp_Description.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Description.Controls.Add(this.tb_Description, 0, 0);
            this.tlp_Description.Controls.Add(this.btn_ChangeDescription, 0, 1);
            this.tlp_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Description.Location = new System.Drawing.Point(134, 163);
            this.tlp_Description.Name = "tlp_Description";
            this.tlp_Description.RowCount = 2;
            this.tlp_Description.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlp_Description.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Description.Size = new System.Drawing.Size(191, 106);
            this.tlp_Description.TabIndex = 7;
            // 
            // tb_Description
            // 
            this.tb_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Description.Location = new System.Drawing.Point(3, 3);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Description.Size = new System.Drawing.Size(185, 73);
            this.tb_Description.TabIndex = 0;
            this.tb_Description.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_Description_KeyUp);
            // 
            // btn_ChangeDescription
            // 
            this.btn_ChangeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_ChangeDescription.Location = new System.Drawing.Point(58, 82);
            this.btn_ChangeDescription.Name = "btn_ChangeDescription";
            this.btn_ChangeDescription.Size = new System.Drawing.Size(75, 21);
            this.btn_ChangeDescription.TabIndex = 1;
            this.btn_ChangeDescription.Text = "Change";
            this.btn_ChangeDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ChangeDescription.UseVisualStyleBackColor = true;
            this.btn_ChangeDescription.Click += new System.EventHandler(this.btn_ChangeDescription_Click);
            // 
            // CountriesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_Main);
            this.Name = "CountriesControl";
            this.Size = new System.Drawing.Size(328, 323);
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Flag)).EndInit();
            this.flp_Buttons.ResumeLayout(false);
            this.tlp_Description.ResumeLayout(false);
            this.tlp_Description.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.PictureBox pb_Flag;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_Capital;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.FlowLayoutPanel flp_Buttons;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_CountryName;
        private System.Windows.Forms.Label lbl_CapitalName;
        private System.Windows.Forms.Button btn_UndoDelete;
        private System.Windows.Forms.TableLayoutPanel tlp_Description;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Button btn_ChangeDescription;
    }
}
