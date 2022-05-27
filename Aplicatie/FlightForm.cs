using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class FlightForm : Form
    {
        public Flight model = new Flight();
        public FlightForm()
        {

            InitializeComponent();
        }

        void Clear()
        {
            txtName.Text = txtTakeOffDate.Text = txtTakeOffAirport.Text = txtLandingDate.Text = txtLandingAirport.Text = txtEmergencyAirport.Text = "";
            btnADD.Text = "ADD";
            model.IDFlight = 0;
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

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            AirportForm Airport = new AirportForm();
            Airport.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlightForm Flight = new FlightForm();
            Flight.Show();
        }

        private void bunifuMaterialTextbox8_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void FlightForm_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            // var model = ExtractInputsFlight(txtName.Text, txtTakeOffDate.Text, txtNrLicense.Text, txtLocality.Text);
            model.Name = txtName.Text.Trim();
            model.TakeOffDate = txtTakeOffDate.Text.Trim();
            model.TakeOffAirport = txtTakeOffAirport.Text.Trim();
            model.LandingDate = txtLandingDate.Text.Trim();
            model.LandingAirport = txtLandingAirport.Text.Trim();
            model.EmargencyAirport = txtEmergencyAirport.Text.Trim();
            using (DBApp1Entities db = new DBApp1Entities())
            {
                db.Flights.Add(model);
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted Successfully");
        }
        void PopulateDataGridView()
        {
            dgvFlight.AutoGenerateColumns = false;
            using (DBApp1Entities db = new DBApp1Entities())
            {
                dgvFlight.DataSource = db.Flights.ToList<Flight>();
            }
        }

        private void dgvFlight_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFlight.CurrentRow.Index != -1)
            {
                model.IDFlight = Convert.ToInt32(dgvFlight.CurrentRow.Cells["IDFlight"].Value);
                using (DBApp1Entities db = new DBApp1Entities())
                {
                    model = db.Flights.Where(x => x.IDFlight == model.IDFlight).FirstOrDefault();
                    txtName.Text = model.Name;
                    txtTakeOffDate.Text = model.TakeOffDate;
                    txtTakeOffAirport.Text = model.TakeOffAirport;
                    txtLandingDate.Text = model.LandingDate;
                    txtLandingAirport.Text = model.LandingAirport;
                    txtEmergencyAirport.Text = model.EmargencyAirport;
                }
                btnADD.Text = "ADD";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBApp1Entities db = new DBApp1Entities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.Flights.Attach(model);
                    db.Flights.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");

                }
            }
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            model.Name = txtName.Text.Trim();
            model.TakeOffDate = txtTakeOffDate.Text.Trim();
            model.TakeOffAirport = txtTakeOffAirport.Text.Trim();
            model.LandingDate = txtLandingDate.Text.Trim();
            model.LandingAirport = txtLandingAirport.Text.Trim();
            model.EmargencyAirport = txtEmergencyAirport.Text.Trim();

            using (DBApp1Entities db = new DBApp1Entities())
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            MessageBox.Show("Client Successfully Updated");
            PopulateDataGridView();
        }

        public Flight ExtractInputsFlight(string name, string TakeOffD, string TakeOffA, string LandingD, string LandingA, string emargencyA)
        {
            return new Flight { IDFlight = 0, Name = name, TakeOffDate = TakeOffD, TakeOffAirport = TakeOffA, LandingDate = LandingD, LandingAirport = LandingA, EmargencyAirport = emargencyA };
        }
    }
}
