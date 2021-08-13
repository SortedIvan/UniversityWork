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
    //Main form class - used for all of the logical connections
    public partial class Form1 : Form
    {
        private Organiser organiser;
        private AvailableWorkshops newForm;
        public Form1()
        {
            InitializeComponent();
            this.organiser = new Organiser();
            this.newForm = new AvailableWorkshops(organiser);
        }

        
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            try
            {
                    CheckUserTextboxes();
                    CheckUserNameExists();
                    CheckExistingPcn();
                    CheckExistingEmail();

                    string name = Convert.ToString(tbxPersonName.Text);
                    string email = Convert.ToString(tbxEmail.Text);
                    string pcn = Convert.ToString(tbxPcn.Text);
                    string type = cbxOccupation.Text;
                    string course = Convert.ToString(tbxCourse.Text);

                    this.organiser.PersonManager.AddPerson(name,email,pcn,course,type);
                    

                    UpdatePersonListBox();
                    UpdateWorkshopTeacherCbx();
                    UpdateAvailableWorkshopsCheckbox();  
                    SuccessfullyAddedPerson();
                    




            }
            catch(AlreadyExistingException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(EmptyOrNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(AddedPersonException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CheckWorkshopTextboxes()
        {
            if (String.IsNullOrEmpty(tbxWorkshopTitle.Text))
            {
                throw new EmptyOrNullException("Workshop title");
            }
            else if (String.IsNullOrEmpty(tbxCapacity.Text))
            {
                throw new EmptyOrNullException("Capacity");
            }
            else if (String.IsNullOrEmpty(dtpStartDate.Value.ToString()))
            {
                throw new EmptyOrNullException("Start date");
            }
            else if (String.IsNullOrEmpty(cbxWorkshopTeacher.Text))
            {
                throw new EmptyOrNullException("Teacher");
            }
            else if (String.IsNullOrEmpty(tbxUrl.Text))
            {
                throw new EmptyOrNullException("Url");
            }
            else if (String.IsNullOrEmpty(tbxRoomNr.Text))
            {
                throw new EmptyOrNullException("Room nr");
            }
            else if (String.IsNullOrEmpty(tbxAddress.Text))
            {
                throw new EmptyOrNullException("Address");
            }
            else if (String.IsNullOrEmpty(cbxWorkshopTeacher.Text))
            {
                throw new EmptyOrNullException("Teacher");
            }
        }
        private void CheckUserTextboxes()
        {
            if (String.IsNullOrEmpty(tbxPersonName.Text))
            {
                throw new EmptyOrNullException("Name");
            }
            else if (String.IsNullOrEmpty(tbxEmail.Text))
            {
                throw new EmptyOrNullException("Email");
            }
            else if (String.IsNullOrEmpty(tbxCourse.Text))
            {
                throw new EmptyOrNullException("Course");
            }
            else if (String.IsNullOrEmpty(tbxPcn.Text))
            {
                throw new EmptyOrNullException("Pcn");
            }
            else if (String.IsNullOrEmpty(cbxOccupation.Text))
            {
                throw new EmptyOrNullException("Occupation");
            }

        }
        private void UpdatePersonListBox()
        {
            lbxPeople.Items.Clear();
            foreach(var p in this.organiser.PersonManager.GetPeople())
            {
                lbxPeople.Items.Add(p);
            }
        }

        private void CheckUserNameExists()
        {
            string name = Convert.ToString(tbxPersonName.Text);
            this.organiser.PersonManager.CheckIfUserExists(name);
        }
        


        private void CheckExistingPcn()
        {
            string pcn = Convert.ToString(tbxPcn.Text);
            this.organiser.PersonManager.CheckIfPcnExists(pcn);
        }

        private void CheckExistingEmail()
        {
            string email = Convert.ToString(tbxEmail.Text);
            this.organiser.PersonManager.CheckIfEmailExists(email);
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            int index = lbxPeople.SelectedIndex;
            this.organiser.PersonManager.DeletePerson(index);
            UpdatePersonListBox();
        }

        
        private void btnAddWorkshop_Click(object sender, EventArgs e)
        {
            try
            {
                CheckWorkshopTextboxes();

                string workshopName = Convert.ToString(tbxWorkshopTitle.Text);
                int workshopCapacity = Convert.ToInt32(tbxCapacity.Text);
                string workshopDescription = Convert.ToString(tbxTopicDescription.Text);
                string type = cbxWorkshopType.Text;
                int index = cbxWorkshopTeacher.SelectedIndex;
                string url = Convert.ToString(tbxUrl.Text);
                string address = Convert.ToString(tbxAddress.Text);
                string roomNr = Convert.ToString(tbxRoomNr.Text);
                DateTime startDate = dtpStartDate.Value;
                int index1 = cbxWorkshopTeacher.SelectedIndex;

                Workshop.Workshop workshop = this.organiser.WorkshopManager.WorkshopFactory.CreateWorkshop(startDate, organiser.PersonManager.GetTeacher1(index1), workshopName, type,
                workshopCapacity, workshopDescription, false, url, address, roomNr);
                workshop.Workshop90Percent += newForm.CapacityAt90;
                
                this.organiser.WorkshopManager.AddWorkshopToList(workshop);
                this.organiser.WorkshopManager.allWorkshopsLoaded += newForm.UpdateAvailableWorkshops;
                this.organiser.WorkshopManager.allWorkshopsLoaded.Invoke();


                UpdateAvailableWorkshops();
                UpdateWorkshopListbox();
                SuccessfullyAddedWorkshop();
                UpdateSecondFormWorkshops();





            }
            catch (EmptyOrNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(AlreadyExistingException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(AddedPersonException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateSecondFormWorkshops()
        {
            this.newForm.UpdateAvailableWorkshops();
        }
        private void UpdateWorkshopListbox()
        {
            lbxWorkshops.Items.Clear();
            foreach(var v in this.organiser.WorkshopManager.GetWorkshops())
            {
                lbxWorkshops.Items.Add(v);
            }
        }
        private void UpdateAvailableWorkshops()
        {
            lbxAvailableWorkshops.Items.Clear();
            foreach(var v in this.organiser.WorkshopManager.GetWorkshops())
            {
                lbxAvailableWorkshops.Items.Add(v);
            }
        }
        private void UpdateWorkshopTeacherCbx()
        {
            this.cbxWorkshopTeacher.Items.Clear();
            
            foreach(var v in this.organiser.PersonManager.GetTeachers())
            {
                this.cbxWorkshopTeacher.Items.Add(v);
                
            }
        }

        private void cbxWorkshopTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lbxWorkshops.SelectedIndex;
            this.organiser.WorkshopManager.DeleteWorkshop(index);
            UpdateWorkshopListbox();

        }

        private void btnSearchByPcnOrEmail_Click(object sender, EventArgs e)
        {
            string searchPcn = tbxPcnSearch.Text;
            lbxPeople.Items.Clear();
            lbxPeople.Items.Add(this.organiser.PersonManager.FindPersonByPcn(searchPcn));
        }

        private void btnShowAllPeople_Click(object sender, EventArgs e)
        {
            
            UpdatePersonListBox();
        }

        private void lbxPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = lbxPeople.SelectedIndex;
                if (index > -1)
                {
                    tbxEmail.Text = this.organiser.PersonManager.GetPerson(index).Email;
                    tbxCourse.Text = this.organiser.PersonManager.GetPerson(index).GetCourse();
                    tbxPcn.Text = this.organiser.PersonManager.GetPerson(index).GetPcn();
                    tbxPersonName.Text = this.organiser.PersonManager.GetPerson(index).GetName();
                    cbxOccupation.Text = this.organiser.PersonManager.GetOccupation(index);
                }
                else
                {
                    throw new EmptyOrNullException("Person");
                }
            }
            catch (EmptyOrNullException)
            {

            }


        }

        private void UpdateAvailableWorkshopsCheckbox()
        {
            cbxAddStudentWorkshop.Items.Clear();
            
            foreach(var v in this.organiser.PersonManager.GetStudents())
            {
                cbxAddStudentWorkshop.Items.Add(v);
            }
            //foreach (var v in this.organiser.PersonManager.GetTeachers())
            //{
            //    cbxAddStudentWorkshop.Items.Add(v);
            //}

        }

        private void UpdateAvailableWorkshopsTeachersCheckbox()
        {
            cbxAddStudentWorkshop.Items.Clear();


        }

        private void btnViewAllWorkshops_Click(object sender, EventArgs e)
        {
            foreach(var v in this.organiser.WorkshopManager.GetWorkshops())
            {
                lbxWorkshops.Items.Add(v);
            }
        }

        private void SuccessfullyAddedWorkshop()
        {
            if(this.cbxWorkshopType.Text == "ONLINE")
            {
                throw new AddedPersonException("Online workshop");
            }
            else if(this.cbxWorkshopType.Text == "BUILDING")
            {
                throw new AddedPersonException("Building workshop");
            }
        }
        private void SuccessfullyAddedPerson()
        {
            if(this.cbxOccupation.Text == "STUDENT")
            {
                throw new AddedPersonException("Student");
            }
            else if(this.cbxOccupation.Text == "TEACHER")
            {
                throw new AddedPersonException("Teacher");
            }
        }
        private void btnAddStudentToWorkshop_Click(object sender, EventArgs e)
        {
            try
            {
                int sIndex = cbxAddStudentWorkshop.SelectedIndex;
                int wIndex = lbxAvailableWorkshops.SelectedIndex;
                if (sIndex > -1 && wIndex > -1)
                {
                    this.organiser.AddStudentToOnlineWorkshop(sIndex, wIndex);
                    UpdatePeopleInWorkshop();
                    
                }
                else
                {
                    throw new EmptyOrNullException("Student and workshop");
                }
            }
            catch (EmptyOrNullException)
            {
                
            }


        }
        private void UpdatePeopleInWorkshop()
        {
            try
            {
                int wIndex = lbxAvailableWorkshops.SelectedIndex;
                if (wIndex > -1)
                {
                    lbxStudentsInWorkshop.Items.Clear();
                    foreach (var v in this.organiser.WorkshopManager.GetWorkshop(wIndex).GetPeopleInWorkshop())
                    {
                        lbxStudentsInWorkshop.Items.Add(v);
                    }
                }
                else
                {
                    throw new EmptyOrNullException("Workshop");
                }

            }
            catch (EmptyOrNullException)
            {

            }

        }
        private void lbxStartedWorkshops_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lbxAvailableWorkshops_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePeopleInWorkshop();
        }

        private void lbxWorkshops_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = lbxWorkshops.SelectedIndex;
                if (index > -1)
                {
                    tbxWorkshopTitle.Text = this.organiser.WorkshopManager.GetWorkshop(index).GetWorkshopTitle().ToString();
                    tbxCapacity.Text = this.organiser.WorkshopManager.GetWorkshop(index).GetMaxCapacity().ToString();
                    tbxTopicDescription.Text = this.organiser.WorkshopManager.GetWorkshop(index).GetTopicDescription();
                }
                else
                {
                    throw new EmptyOrNullException("Workshop");
                }
            }
            catch(EmptyOrNullException)
            {
                
            }




        }

        private void btnStartWorkshop_Click(object sender, EventArgs e)
        {
            int index = lbxAvailableWorkshops.SelectedIndex;
            if (index > -1) 
            {
                this.organiser.StartWorkshop(index);
                UpdateStartedWorkshops();
                UpdateAvailableWorkshops();
            }
            else
            {
                MessageBox.Show("Please select a workshop first!");
            }

        }

        public void UpdateStartedWorkshops()
        {
            lbxStartedWorkshops.Items.Clear();
            foreach (var v in this.organiser.WorkshopManager.GetStartedWorkshops())
            {
                this.lbxStartedWorkshops.Items.Add(v);
            }
        }

        private void btnUpdatePersonInfo_Click(object sender, EventArgs e)
        {
            int index = lbxPeople.SelectedIndex;
            string newName = tbxPersonName.Text;
            string newPcn = tbxPcn.Text;
            string newCourse = tbxCourse.Text;
            string newEmail = tbxEmail.Text;
            string newOccupation = cbxOccupation.Text;

            this.organiser.PersonManager.GetPerson(index).Email = newEmail;
            this.organiser.PersonManager.GetPerson(index).Name = newName;
            this.organiser.PersonManager.GetPerson(index).Course = newCourse;
            this.organiser.PersonManager.GetPerson(index).Pcn = newPcn;
            MessageBox.Show("Successfully updated person info!");
            UpdatePersonListBox();



        }

        private void btnChangeWorkshopInfo_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lbxWorkshops.SelectedIndex;
                if (index > -1)
                {
                    this.organiser.WorkshopManager.GetWorkshop(index).SetWorkshopTitle(this.tbxWorkshopTitle.Text);
                    this.organiser.WorkshopManager.GetWorkshop(index).SetWorkshopDescription(this.tbxTopicDescription.Text);
                    this.UpdateAvailableWorkshops();
                }
                else
                {
                    throw new EmptyOrNullException("Workshop!");
                }
            }
            catch(EmptyOrNullException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int index = lbxStartedWorkshops.SelectedIndex;
            //foreach (var v in this.organiser.WorkshopManager.GetRandomCodes(index))
            //{
            //    lbxStartedWorkshops.Items.Add(v);
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.newForm.Show();
            
        }

        private void btnSaveWorkshops_Click(object sender, EventArgs e)
        {
            this.organiser.WorkshopManager.SaveToFile();
            MessageBox.Show("Success!");
        }

        private void lbxStudentsInWorkshop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxStudentsInWorkshop.SelectedIndex;
            MessageBox.Show($"{this.organiser.WorkshopManager.GetRandomCode(index)}");
        }
    }
}
