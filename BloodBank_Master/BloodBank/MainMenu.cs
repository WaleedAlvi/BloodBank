using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class DonorApp : Form
    {
        public List<Person> donlist = new List<Person>(); // Person list that uses Person class
        public DonorApp()
        {
            InitializeComponent();
            CSVGenerateList(); //initialize preselected CSV FILE and insert into donlist 
            ListIntoListboxPopulate(); //takes lists current state and inserts into donorlistview     
        }
           

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        //first run - taking csv file and making initial list
        public void CSVGenerateList()
        {
            string path = "DonorFile.txt";
            FileStream fileStream = null;
            StreamReader streamReader = null;
            try
            {
                fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                streamReader = new StreamReader(fileStream);
                string[] fields;
             
                while (streamReader.Peek() != -1)
                {
                    string record = streamReader.ReadLine();
                    fields = record.Split(',');
                    //adding person objects to list file, based on file text
                    donlist.Add(new Person(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5], fields[6]));
                    DonorListView.Items.Add(donlist);
                } // end while
            } // end try
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            } // end catch
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");
            } // end catch
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                } // end if
            } // finally
        } // End CSVGenerateList


        private void DonorListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = "DonarFile.txt";
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader stRead = new StreamReader(fileStream))
            {
                while(!stRead.EndOfStream)
                {
                    DonorListView.Items.Add(stRead.ReadLine());
                }
            }
        }

        public void ListIntoListboxPopulate() //list into listbox 
        {
            this.DonorListView.Items.Clear();
            string line = "";
            int counter = 0;
            foreach (Person p in donlist)
            {
                line = donlist[counter].fname + "    "
                          + donlist[counter].lname + "    "
                          + donlist[counter].phoneNum + "    "
                          + donlist[counter].email + "    "
                          + donlist[counter].address + "    "
                          + donlist[counter].bloodType + ""
                          + donlist[counter].antigen;
                this.DonorListView.Items.Add(line);
                counter++;
            }
        }

        // void method that saves the text in list box, onto a text file
        public void saveToText()
        {
            string path = "DonarFile.txt";
            int counter = 0;
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Write);
                sw = new StreamWriter(fs);

                foreach (Person p in donlist)
                {
                    sw.WriteLine(donlist[counter].fname + ", "
                          + donlist[counter].lname + ", "
                          + donlist[counter].phoneNum + ", "
                          + donlist[counter].email + ", "
                          + donlist[counter].address + ", "
                          + donlist[counter].bloodType + ", "
                          + donlist[counter].antigen);
                    counter++;
                } // end foreach
            } // end try
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            } // end catch
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");
            } // end catch
            finally
            {
                if (sw != null)
                {

                    sw.Close(); // closing the writer
                } // end if
            } // end finally
        } // end saveToText

        private void Add_Click(object sender, EventArgs e)
        {
            new ModifyWindow(this.donlist).Show(); // leads to window to add person
            this.Hide();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (this.DonorListView.SelectedIndex == -1)
                MessageBox.Show("Please select a patient first!");
            else  // leads to window to edit person
            {
                new ModifyWindow(this.donlist, this.DonorListView.SelectedIndex).Show();
                this.Hide();
            }


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (this.DonorListView.SelectedIndex == -1) // leads to window to delete person
                MessageBox.Show("Please select a Patient first!"); 
            else
            {
                this.donlist.RemoveAt(this.DonorListView.SelectedIndex);
                ListIntoListboxPopulate();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DonorApp_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            saveToText();
            MessageBox.Show("File Has Been Saved");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        // button that will send an email to the selected client
        private void Contactbtn_Click(object sender, EventArgs e)
        {
            if (DonorListView.SelectedIndex == -1)
                MessageBox.Show("Please select a Patient first!");
            else
            {
                string em = this.donlist[this.DonorListView.SelectedIndex].email;
                EmailCreate ec = new EmailCreate(em);
                ec.Show();
            }
        }

        // Exit Button in toolbox
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to close the application?";
            DialogResult dialogResult = MessageBox.Show(message, "Exit Application?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string gb = "Have a nice day!";
                MessageBox.Show(gb);
                Application.Exit();
            } // end if

        } // end exitToolStripMenuItem1_Click
    }
}
