using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEALibrary
{
    public partial class ViewCompletedReservationForm : Form
    {
        public ViewCompletedReservationForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void ViewCompletedReservationForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {

            
            dataGridViewReservation.DataSource = Reservation.GetReservedBooksWithAvailabilityByStudentId(Program.user.GetUserId());
        }
    }
}
