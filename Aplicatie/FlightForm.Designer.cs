namespace Aplicatie
{
    partial class FlightForm
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
            this.txtEmergencyAirport = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLandingAirport = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLandingDate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTakeOffAirport = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTakeOffDate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvFlight = new System.Windows.Forms.DataGridView();
            this.IDFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakeOffDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakeOffAirport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LandingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LandingAirport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmargencyAirport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlight)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button9.Location = new System.Drawing.Point(36, 159);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(119, 47);
            this.button9.TabIndex = 40;
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
            this.button10.Location = new System.Drawing.Point(1376, -8);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(45, 47);
            this.button10.TabIndex = 39;
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
            this.button11.Location = new System.Drawing.Point(12, 113);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(157, 40);
            this.button11.TabIndex = 38;
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
            this.button12.Location = new System.Drawing.Point(36, 72);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(108, 40);
            this.button12.TabIndex = 37;
            this.button12.Text = "Pilot";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.txtEmergencyAirport);
            this.panel2.Controls.Add(this.txtLandingAirport);
            this.panel2.Controls.Add(this.txtLandingDate);
            this.panel2.Controls.Add(this.txtTakeOffAirport);
            this.panel2.Controls.Add(this.txtTakeOffDate);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dgvFlight);
            this.panel2.Controls.Add(this.btnEDIT);
            this.panel2.Controls.Add(this.btnADD);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(179, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1191, 547);
            this.panel2.TabIndex = 36;
            // 
            // txtEmergencyAirport
            // 
            this.txtEmergencyAirport.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtEmergencyAirport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmergencyAirport.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmergencyAirport.ForeColor = System.Drawing.SystemColors.Control;
            this.txtEmergencyAirport.HintForeColor = System.Drawing.SystemColors.Control;
            this.txtEmergencyAirport.HintText = "";
            this.txtEmergencyAirport.isPassword = false;
            this.txtEmergencyAirport.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtEmergencyAirport.LineIdleColor = System.Drawing.SystemColors.Control;
            this.txtEmergencyAirport.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtEmergencyAirport.LineThickness = 3;
            this.txtEmergencyAirport.Location = new System.Drawing.Point(282, 361);
            this.txtEmergencyAirport.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmergencyAirport.Name = "txtEmergencyAirport";
            this.txtEmergencyAirport.Size = new System.Drawing.Size(232, 44);
            this.txtEmergencyAirport.TabIndex = 38;
            this.txtEmergencyAirport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLandingAirport
            // 
            this.txtLandingAirport.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtLandingAirport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLandingAirport.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLandingAirport.ForeColor = System.Drawing.SystemColors.Control;
            this.txtLandingAirport.HintForeColor = System.Drawing.SystemColors.Control;
            this.txtLandingAirport.HintText = "";
            this.txtLandingAirport.isPassword = false;
            this.txtLandingAirport.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtLandingAirport.LineIdleColor = System.Drawing.SystemColors.Control;
            this.txtLandingAirport.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtLandingAirport.LineThickness = 3;
            this.txtLandingAirport.Location = new System.Drawing.Point(252, 312);
            this.txtLandingAirport.Margin = new System.Windows.Forms.Padding(4);
            this.txtLandingAirport.Name = "txtLandingAirport";
            this.txtLandingAirport.Size = new System.Drawing.Size(262, 44);
            this.txtLandingAirport.TabIndex = 37;
            this.txtLandingAirport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLandingDate
            // 
            this.txtLandingDate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtLandingDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLandingDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLandingDate.ForeColor = System.Drawing.SystemColors.Control;
            this.txtLandingDate.HintForeColor = System.Drawing.SystemColors.Control;
            this.txtLandingDate.HintText = "";
            this.txtLandingDate.isPassword = false;
            this.txtLandingDate.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtLandingDate.LineIdleColor = System.Drawing.SystemColors.Control;
            this.txtLandingDate.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtLandingDate.LineThickness = 3;
            this.txtLandingDate.Location = new System.Drawing.Point(252, 260);
            this.txtLandingDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtLandingDate.Name = "txtLandingDate";
            this.txtLandingDate.Size = new System.Drawing.Size(262, 44);
            this.txtLandingDate.TabIndex = 36;
            this.txtLandingDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTakeOffAirport
            // 
            this.txtTakeOffAirport.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtTakeOffAirport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTakeOffAirport.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTakeOffAirport.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTakeOffAirport.HintForeColor = System.Drawing.SystemColors.Control;
            this.txtTakeOffAirport.HintText = "";
            this.txtTakeOffAirport.isPassword = false;
            this.txtTakeOffAirport.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtTakeOffAirport.LineIdleColor = System.Drawing.SystemColors.Control;
            this.txtTakeOffAirport.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtTakeOffAirport.LineThickness = 3;
            this.txtTakeOffAirport.Location = new System.Drawing.Point(252, 212);
            this.txtTakeOffAirport.Margin = new System.Windows.Forms.Padding(4);
            this.txtTakeOffAirport.Name = "txtTakeOffAirport";
            this.txtTakeOffAirport.Size = new System.Drawing.Size(262, 44);
            this.txtTakeOffAirport.TabIndex = 35;
            this.txtTakeOffAirport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTakeOffDate
            // 
            this.txtTakeOffDate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtTakeOffDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTakeOffDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTakeOffDate.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTakeOffDate.HintForeColor = System.Drawing.SystemColors.Control;
            this.txtTakeOffDate.HintText = "";
            this.txtTakeOffDate.isPassword = false;
            this.txtTakeOffDate.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtTakeOffDate.LineIdleColor = System.Drawing.SystemColors.Control;
            this.txtTakeOffDate.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtTakeOffDate.LineThickness = 3;
            this.txtTakeOffDate.Location = new System.Drawing.Point(252, 167);
            this.txtTakeOffDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtTakeOffDate.Name = "txtTakeOffDate";
            this.txtTakeOffDate.Size = new System.Drawing.Size(262, 44);
            this.txtTakeOffDate.TabIndex = 34;
            this.txtTakeOffDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.SystemColors.Control;
            this.txtName.HintForeColor = System.Drawing.SystemColors.Control;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txtName.LineIdleColor = System.Drawing.SystemColors.Control;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(252, 115);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(262, 44);
            this.txtName.TabIndex = 33;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(9, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 27);
            this.label3.TabIndex = 32;
            this.label3.Text = "EMERGENCY AIRPORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(28, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 32;
            this.label2.Text = "NAME";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(9, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "TAKE-OFF AIRPORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(9, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 27);
            this.label4.TabIndex = 32;
            this.label4.Text = "LANDING AIRPORT";
            // 
            // dgvFlight
            // 
            this.dgvFlight.AllowUserToDeleteRows = false;
            this.dgvFlight.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDFlight,
            this.Name,
            this.TakeOffDate,
            this.TakeOffAirport,
            this.LandingDate,
            this.LandingAirport,
            this.EmargencyAirport});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlight.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFlight.GridColor = System.Drawing.SystemColors.Control;
            this.dgvFlight.Location = new System.Drawing.Point(532, 115);
            this.dgvFlight.Name = "dgvFlight";
            this.dgvFlight.ReadOnly = true;
            this.dgvFlight.RowHeadersWidth = 51;
            this.dgvFlight.RowTemplate.Height = 24;
            this.dgvFlight.Size = new System.Drawing.Size(643, 372);
            this.dgvFlight.TabIndex = 30;
            this.dgvFlight.DoubleClick += new System.EventHandler(this.dgvFlight_DoubleClick);
            // 
            // IDFlight
            // 
            this.IDFlight.DataPropertyName = "IDFlight";
            this.IDFlight.HeaderText = "IDFlight";
            this.IDFlight.MinimumWidth = 6;
            this.IDFlight.Name = "IDFlight";
            this.IDFlight.ReadOnly = true;
            this.IDFlight.Visible = false;
            this.IDFlight.Width = 125;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // TakeOffDate
            // 
            this.TakeOffDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TakeOffDate.DataPropertyName = "TakeOffDate";
            this.TakeOffDate.HeaderText = "TakeOffDate";
            this.TakeOffDate.MinimumWidth = 6;
            this.TakeOffDate.Name = "TakeOffDate";
            this.TakeOffDate.ReadOnly = true;
            this.TakeOffDate.Visible = false;
            // 
            // TakeOffAirport
            // 
            this.TakeOffAirport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TakeOffAirport.DataPropertyName = "TakeOffAirport";
            this.TakeOffAirport.HeaderText = "TakeOffAirport";
            this.TakeOffAirport.MinimumWidth = 6;
            this.TakeOffAirport.Name = "TakeOffAirport";
            this.TakeOffAirport.ReadOnly = true;
            // 
            // LandingDate
            // 
            this.LandingDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LandingDate.DataPropertyName = "LandingDate";
            this.LandingDate.HeaderText = "LandingDate";
            this.LandingDate.MinimumWidth = 6;
            this.LandingDate.Name = "LandingDate";
            this.LandingDate.ReadOnly = true;
            this.LandingDate.Visible = false;
            // 
            // LandingAirport
            // 
            this.LandingAirport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LandingAirport.DataPropertyName = "LandingAirport";
            this.LandingAirport.HeaderText = "LandingAirport";
            this.LandingAirport.MinimumWidth = 6;
            this.LandingAirport.Name = "LandingAirport";
            this.LandingAirport.ReadOnly = true;
            // 
            // EmargencyAirport
            // 
            this.EmargencyAirport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmargencyAirport.DataPropertyName = "EmergencyAirport";
            this.EmargencyAirport.HeaderText = "EmargencyAirport";
            this.EmargencyAirport.MinimumWidth = 6;
            this.EmargencyAirport.Name = "EmargencyAirport";
            this.EmargencyAirport.ReadOnly = true;
            // 
            // btnEDIT
            // 
            this.btnEDIT.BackColor = System.Drawing.SystemColors.Control;
            this.btnEDIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEDIT.FlatAppearance.BorderSize = 0;
            this.btnEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEDIT.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEDIT.Location = new System.Drawing.Point(204, 447);
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
            this.btnADD.Location = new System.Drawing.Point(14, 447);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(120, 40);
            this.btnADD.TabIndex = 23;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Location = new System.Drawing.Point(390, 447);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 40);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(9, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "TAKE-OFF DATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "LANDING DATE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(9, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 27);
            this.label9.TabIndex = 13;
            this.label9.Text = "NAME PILOT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(458, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(268, 37);
            this.label10.TabIndex = 12;
            this.label10.Text = "MANAGE FLIGHTS";
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
            // FlightForm
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
            this.Name.Name = "FlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.FlightForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvFlight;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmergencyAirport;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLandingAirport;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLandingDate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTakeOffAirport;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTakeOffDate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakeOffDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakeOffAirport;
        private System.Windows.Forms.DataGridViewTextBoxColumn LandingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LandingAirport;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmargencyAirport;
    }
}