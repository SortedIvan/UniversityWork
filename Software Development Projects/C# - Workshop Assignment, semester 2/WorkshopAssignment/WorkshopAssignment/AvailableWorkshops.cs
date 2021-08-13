using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkshopAssignment.People;
using WorkshopAssignment.Workshop;
using WorkshopAssignment;

namespace WorkshopAssignment
{
    //Available workshops form - this is the secondary form where the workshops are displayed
    public partial class AvailableWorkshops : Form
    {
        public List<string> warns;
        Organiser organiser;
        public AvailableWorkshops(Organiser organiser)
        {
            InitializeComponent();
            this.warns = new List<string>();
            this.organiser = organiser;
        }

        private void AvailableWorkshops_Load(object sender, EventArgs e)
        {

        }

        public void CapacityAt90(string message)
        {
            this.warns.Add(message);
            UpdateListBox();
        }

        public void UpdateListBox()
        {
            lbxStartedWorkshopss.Items.Clear();
            foreach(var v in this.warns)
            {
                lbxStartedWorkshopss.Items.Add(v);
            }
        }

        public void UpdateAvailableWorkshops()
        {
            lbxAvailableWorkshops.Items.Clear();
            foreach(var v in this.organiser.WorkshopManager.GetWorkshops())
            {
                lbxAvailableWorkshops.Items.Add(v);
            }
        }
        public void LoadWorkshops(List<Workshop.Workshop> workshops)
        {
            lbxAvailableWorkshops.Items.Clear();
            foreach(var v in workshops)
            {
                lbxAvailableWorkshops.Items.Add(v);
            }
        }
    }
}
