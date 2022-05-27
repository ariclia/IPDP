namespace Aplicatie
{
    partial class PilotForm
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
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocality = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgvPilot = new System.Windows.Forms.DataGridView();
            this.IDPilot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNrLicense = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilot)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button9.Location = new System.Drawing.Point(34, 172);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(119, 47);
            this.button9.TabIndex = 45;
            this.button9.Text = "Flight";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button10.Location = new System.Drawing.Point(1367, -6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(45, 47);
            this.button10.TabIndex = 44;
            this.button10.Text = "x";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button11.Location = new System.Drawing.Point(23, 126);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(157, 40);
            this.button11.TabIndex = 43;
            this.button11.Text = "Airport";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button12.Location = new System.Drawing.Point(34, 80);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(108, 40);
            this.button12.TabIndex = 42;
            this.button12.Text = "Pilot";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtLocality);
            this.panel2.Controls.Add(this.dgvPilot);
            this.panel2.Controls.Add(this.txtNrLicense);
            this.panel2.Controls.Add(this.btnEDIT);
            this.panel2.Controls.Add(this.btnADD);
            this.panel2.Controls.Add(this.btnDELETE);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(186, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1163, 547);
            this.panel2.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(28, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 32;
            this.label1.Text = "LOCALITY";
            // 
            // txtLocality
            // 
            this.txtLocality.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtLocality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocality.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLocality.ForeColor = System.Drawing.SystemColors.Control;
            this.txtLocality.HintForeColor = System.Drawing.SystemColors.Control;
            this.txtLocality.HintText = "";
            this.txtLocality.isPassword = false;
            this.txtLocality.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtLocality.LineIdleColor = System.Drawing.SystemColors.Control;
            this.txtLocality.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtLocality.LineThickness = 3;
            this.txtLocality.Location = new System.Drawing.Point(176, 272);
            this.txtLocality.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocality.Name = "txtLocality";
            this.txtLocality.Size = new System.Drawing.Size(277, 44);
            this.txtLocality.TabIndex = 31;
            this.txtLocality.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgvPilot
            // 
            this.dgvPilot.AllowUserToDeleteRows = false;
            this.dgvPilot.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPilot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPilot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPilot,
            this.FirstName,
            this.LastName,
            this.NrLicense,
            this.Locality});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPilot.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPilot.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPilot.Location = new System.Drawing.Point(478, 114);
            this.dgvPilot.Name = "dgvPilot";
            this.dgvPilot.ReadOnly = true;
            this.dgvPilot.RowHeadersWidth = 51;
            this.dgvPilot.RowTemplate.Height = 24;
            this.dgvPilot.Size = new System.Drawing.Size(662, 372);
            this.dgvPilot.TabIndex = 30;
            this.dgvPilot.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPilot_CellContentClick);
            this.dgvPilot.DoubleClick += new System.EventHandler(this.dgvPilot_DoubleClick);
            // 
            // IDPilot
            // 
            this.IDPilot.DataPropertyName = "IDPilot";
            this.IDPilot.HeaderText = "IDPilot";
            this.IDPilot.MinimumWidth = 6;
            this.IDPilot.Name = "IDPilot";
            this.IDPilot.ReadOnly = true;
            this.IDPilot.Visible = false;
            this.IDPilot.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // NrLicense
            // 
            this.NrLicense.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NrLicense.DataPropertyName = "NrLicense";
            this.NrLicense.HeaderText = "NrLicense";
            this.NrLicense.MinimumWidth = 6;
            this.NrLicense.Name = "NrLicense";
            this.NrLicense.ReadOnly = true;
            // 
            // Locality
            // 
            this.Locality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Locality.DataPropertyName = "Locality";
            this.Locality.HeaderText = "Locality";
            this.Locality.MinimumWidth = 6;
            this.Locality.Name = "Locality";
            this.Locality.ReadOnly = true;
            // 
            // txtNrLicense
            // 
            this.txtNrLicense.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtNrLicense.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNrLicense.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNrLicense.ForeColor = System.Drawing.SystemColors.Control;
            this.txtNrLicense.HintForeColor = System.Drawing.SystemColors.Control;
            this.txtNrLicense.HintText = "";
            this.txtNrLicense.isPassword = false;
            this.txtNrLicense.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtNrLicense.LineIdleColor = System.Drawing.SystemColors.Control;
            this.txtNrLicense.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtNrLicense.LineThickness = 3;
            this.txtNrLicense.Location = new System.Drawing.Point(176, 220);
            this.txtNrLicense.Margin = new System.Windows.Forms.Padding(4);
            this.txtNrLicense.Name = "txtNrLicense";
            this.txtNrLicense.Size = new System.Drawing.Size(277, 44);
            this.txtNrLicense.TabIndex = 29;
            this.txtNrLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnEDIT
            // 
            this.btnEDIT.BackColor = System.Drawing.SystemColors.Control;
            this.btnEDIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEDIT.FlatAppearance.BorderSize = 0;
            this.btnEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEDIT.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEDIT.Location = new System.Drawing.Point(170, 446);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(124, 40);
            this.btnEDIT.TabIndex = 24;
            this.btnEDIT.Text = "EDIT";
            this.btnEDIT.UseVisualStyleBackColor = false;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.SystemColors.Control;
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnADD.Location = new System.Drawing.Point(33, 446);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(120, 40);
            this.btnADD.TabIndex = 23;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.BackColor = System.Drawing.SystemColors.Control;
            this.btnDELETE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDELETE.FlatAppearance.BorderSize = 0;
            this.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDELETE.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDELETE.Location = new System.Drawing.Point(312, 446);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(124, 40);
            this.btnDELETE.TabIndex = 22;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(28, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "LAST NAME";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLastName.ForeColor = System.Drawing.SystemColors.Control;
            this.txtLastName.HintForeColor = System.Drawing.SystemColors.Control;
            this.txtLastName.HintText = "";
            this.txtLastName.isPassword = false;
            this.txtLastName.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtLastName.LineIdleColor = System.Drawing.SystemColors.Control;
            this.txtLastName.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtLastName.LineThickness = 3;
            this.txtLastName.Location = new System.Drawing.Point(176, 169);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(277, 44);
            this.txtLastName.TabIndex = 15;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.Control;
            this.txtFirstName.HintForeColor = System.Drawing.SystemColors.Control;
            this.txtFirstName.HintText = "";
            this.txtFirstName.isPassword = false;
            this.txtFirstName.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtFirstName.LineIdleColor = System.Drawing.SystemColors.Control;
            this.txtFirstName.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtFirstName.LineThickness = 3;
            this.txtFirstName.Location = new System.Drawing.Point(176, 114);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(277, 44);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFirstName.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox3_OnValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(28, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "NR. LICENSE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(28, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 27);
            this.label9.TabIndex = 13;
            this.label9.Text = "FIRST NAME";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(458, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 37);
            this.label10.TabIndex = 12;
            this.label10.Text = "MANAGE PILOTS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(228, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 37);
            this.label11.TabIndex = 11;
            // 
            // PilotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 622);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PilotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PilotForm";
            this.Load += new System.EventHandler(this.PilotForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLocality;
        private System.Windows.Forms.DataGridView dgvPilot;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNrLicense;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLastName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPilot;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locality;
    }
}