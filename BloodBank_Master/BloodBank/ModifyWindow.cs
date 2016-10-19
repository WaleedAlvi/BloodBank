using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class ModifyWindow : Form
    {
        public  List<Person> donrlist = null; 
        public Boolean Add = false; //determines state of window -- add or edit
        public int index;

        public ModifyWindow(List<Person> dlist) //DETERMINES ADD IF function to this window
        {
            InitializeComponent();
            this.donrlist = dlist;
            Operation.Text = "Add";
            this.Add = true;
        }
        public ModifyWindow(List<Person> dlist, int indexnum) //DETERMINES IF EDIT function to this window
        {
            InitializeComponent();
            this.donrlist = dlist;
            this.Add = false;
            Operation.Text = "Edit";
            this.index = indexnum;
            fnameBox.Text = this.donrlist[index].fname;
            lnameBox.Text= this.donrlist[index].lname;
            pnumBox.Text= this.donrlist[index].phoneNum;
            emailBox.Text= this.donrlist[index].email;
            addrBox.Text= this.donrlist[index].address;
            bloodTypeBox.Text= this.donrlist[index].bloodType;
            antigenBox.Text = this.donrlist[index].antigen;
        }

        private void operate_Click(object sender, EventArgs e)
        {
            if (this.Add == true) //insert person function
            {
                this.donrlist.Add(new Person(fnameBox.Text, lnameBox.Text, pnumBox.Text, emailBox.Text,
                    addrBox.Text, bloodTypeBox.Text, antigenBox.Text));
            }
            if (this.Add == false) //edit person function
            {

                this.donrlist[this.index].fname = fnameBox.Text;
                this.donrlist[this.index].lname = lnameBox.Text;
                this.donrlist[this.index].address = addrBox.Text;
                this.donrlist[this.index].email = emailBox.Text;
                this.donrlist[this.index].antigen =this.antigenBox.Text;
                this.donrlist[this.index].phoneNum = pnumBox.Text;
                this.donrlist[this.index].bloodType = this.bloodTypeBox.Text;
            }


            this.Hide();
            DonorApp d = new DonorApp();  //back to Donor View

            

            d.donlist = this.donrlist; //give attributes of donorapp's current donorlist state to a new window  
            
            d.ListIntoListboxPopulate();  //update new windows's listbox to list's data
            d.Show(); //show  updated window
           
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonorApp d = new DonorApp();
            d.Show();
        }
    }
}
