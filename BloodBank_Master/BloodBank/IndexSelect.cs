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
    public partial class IndexSelect : Form
    {
        public IndexSelect(List<Person> donlist)
        {
            
            InitializeComponent();
            int counter = 0;
            foreach (Person p in donlist)
            {
                this.IndexSelction.Items.Add(donlist[counter].fname);
                counter++;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IndexSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
