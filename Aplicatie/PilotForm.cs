using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Aplicatie
{
    public partial class PilotForm : Form
    {
        public Pilot model = new Pilot();
    
        public PilotForm()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        void Clear()
        {
            txtFirstName.Text = txtLastName.Text = txtNrLicense.Text = txtLocality.Text = "";
            btnADD.Text = "ADD";
            btnEDIT.Text = "EDIT";
            model.IDPilot = 0;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            AirportForm Airport = new AirportForm();
            Airport.Show();
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            PilotForm Pilot = new PilotForm();
            Pilot.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlightForm Flight = new FlightForm();
            Flight.Show();
        }

        private void PilotForm_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            var model = ExtractInputsPilot(txtFirstName.Text.Trim(), txtLastName.Text.Trim(), txtNrLicense.Text.Trim(), txtLocality.Text.Trim());
            using (DBApp1Entities db = new DBApp1Entities())
            {
                db.Pilots.Add(model);
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted Successfully");
        }

        void PopulateDataGridView()
        {
            dgvPilot.AutoGenerateColumns = false;
            using (DBApp1Entities db = new DBApp1Entities())
            {
                dgvPilot.DataSource = db.Pilots.ToList<Pilot>();
            }
        }

        private void dgvPilot_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPilot.CurrentRow.Index != -1)
            {
                model.IDPilot = Convert.ToInt32(dgvPilot.CurrentRow.Cells["IDPilot"].Value);
                using (DBApp1Entities db = new DBApp1Entities())
                {
                    model = db.Pilots.Where(x => x.IDPilot == model.IDPilot).FirstOrDefault();
                    txtFirstName.Text = model.FirstName;
                    txtLastName.Text = model.LastName;  
                    txtNrLicense.Text = model.NrLicense;
                    txtLocality.Text = model.Locality;
                }
                btnADD.Text = "ADD";
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBApp1Entities db = new DBApp1Entities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.Pilots.Attach(model);
                    db.Pilots.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");

                }
            }
        }

        public Pilot ExtractInputsPilot(string first, string last, string number, string localitate)
        {
            return new Pilot { IDPilot = 0, FirstName = first, LastName = last, NrLicense = number, Locality = localitate };
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {                  
            model.FirstName = txtFirstName.Text.Trim();
            model.LastName = txtLastName.Text.Trim();
            model.NrLicense = txtNrLicense.Text.Trim();
            model.Locality = txtLocality.Text.Trim();
            using (DBApp1Entities db = new DBApp1Entities())
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
                Clear();
                MessageBox.Show("Client Successfully Updated");
                PopulateDataGridView();
        }

        private void dgvPilot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
