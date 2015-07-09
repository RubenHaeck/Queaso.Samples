namespace Queaso.IBAN.Client
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tpCountries = new MetroFramework.Controls.MetroTabPage();
            this.gridCountries = new MetroFramework.Controls.MetroGrid();
            this.tpIBANConvert = new MetroFramework.Controls.MetroTabPage();
            this.btnConvert = new MetroFramework.Controls.MetroButton();
            this.txtBBAN = new MetroFramework.Controls.MetroTextBox();
            this.txtBankName = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.tpCountries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCountries)).BeginInit();
            this.tpIBANConvert.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tpCountries);
            this.metroTabControl1.Controls.Add(this.tpIBANConvert);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(441, 270);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // tpCountries
            // 
            this.tpCountries.Controls.Add(this.gridCountries);
            this.tpCountries.HorizontalScrollbarBarColor = true;
            this.tpCountries.HorizontalScrollbarHighlightOnWheel = false;
            this.tpCountries.HorizontalScrollbarSize = 10;
            this.tpCountries.Location = new System.Drawing.Point(4, 38);
            this.tpCountries.Name = "tpCountries";
            this.tpCountries.Size = new System.Drawing.Size(433, 228);
            this.tpCountries.TabIndex = 0;
            this.tpCountries.Text = "Countries";
            this.tpCountries.VerticalScrollbarBarColor = true;
            this.tpCountries.VerticalScrollbarHighlightOnWheel = false;
            this.tpCountries.VerticalScrollbarSize = 10;
            // 
            // gridCountries
            // 
            this.gridCountries.AllowUserToResizeRows = false;
            this.gridCountries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCountries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCountries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCountries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCountries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCountries.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridCountries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCountries.EnableHeadersVisualStyles = false;
            this.gridCountries.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridCountries.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCountries.Location = new System.Drawing.Point(0, 0);
            this.gridCountries.Name = "gridCountries";
            this.gridCountries.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCountries.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridCountries.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCountries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCountries.Size = new System.Drawing.Size(433, 228);
            this.gridCountries.TabIndex = 3;
            // 
            // tpIBANConvert
            // 
            this.tpIBANConvert.Controls.Add(this.txtBankName);
            this.tpIBANConvert.Controls.Add(this.btnConvert);
            this.tpIBANConvert.Controls.Add(this.txtBBAN);
            this.tpIBANConvert.HorizontalScrollbarBarColor = true;
            this.tpIBANConvert.HorizontalScrollbarHighlightOnWheel = false;
            this.tpIBANConvert.HorizontalScrollbarSize = 10;
            this.tpIBANConvert.Location = new System.Drawing.Point(4, 38);
            this.tpIBANConvert.Name = "tpIBANConvert";
            this.tpIBANConvert.Size = new System.Drawing.Size(433, 228);
            this.tpIBANConvert.TabIndex = 1;
            this.tpIBANConvert.Text = "Convert to IBAN";
            this.tpIBANConvert.VerticalScrollbarBarColor = true;
            this.tpIBANConvert.VerticalScrollbarHighlightOnWheel = false;
            this.tpIBANConvert.VerticalScrollbarSize = 10;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(327, 16);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(103, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseSelectable = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtBBAN
            // 
            this.txtBBAN.Lines = new string[] {
        "979-5486140-19"};
            this.txtBBAN.Location = new System.Drawing.Point(3, 16);
            this.txtBBAN.MaxLength = 32767;
            this.txtBBAN.Name = "txtBBAN";
            this.txtBBAN.PasswordChar = '\0';
            this.txtBBAN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBBAN.SelectedText = "";
            this.txtBBAN.Size = new System.Drawing.Size(318, 23);
            this.txtBBAN.TabIndex = 2;
            this.txtBBAN.Text = "979-5486140-19";
            this.txtBBAN.UseSelectable = true;
            // 
            // txtBankName
            // 
            this.txtBankName.Lines = new string[0];
            this.txtBankName.Location = new System.Drawing.Point(3, 45);
            this.txtBankName.MaxLength = 32767;
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.PasswordChar = '\0';
            this.txtBankName.ReadOnly = true;
            this.txtBankName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBankName.SelectedText = "";
            this.txtBankName.Size = new System.Drawing.Size(318, 23);
            this.txtBankName.TabIndex = 4;
            this.txtBankName.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 350);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "MainForm";
            this.Text = "My IBAN BIC Tool";
            this.metroTabControl1.ResumeLayout(false);
            this.tpCountries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCountries)).EndInit();
            this.tpIBANConvert.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tpCountries;
        private MetroFramework.Controls.MetroGrid gridCountries;
        private MetroFramework.Controls.MetroTabPage tpIBANConvert;
        private MetroFramework.Controls.MetroButton btnConvert;
        private MetroFramework.Controls.MetroTextBox txtBBAN;
        private MetroFramework.Controls.MetroTextBox txtBankName;

    }
}

