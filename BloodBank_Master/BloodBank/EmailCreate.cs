using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class EmailCreate : Form
    {
        public string emailreceipient;
  

        public EmailCreate(string recip)
        {
            this.emailreceipient = recip;
            InitializeComponent();
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            //Look at this
            ///*http://www.csharptutorial.in/16/csharp-net-how-to-send-email-from-gmail-using-c-sharp *//
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                string msg = msgbox.Text;
                string sub = subjbox.Text;

                message.From = new MailAddress("blood4lyfefdacrips@gmail.com");
                message.To.Add(new MailAddress(this.emailreceipient));
                message.Subject = sub;
                message.Body = msg;

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("blood4lyfefdacrips@gmail.com", "truemantrue");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("err: " + ex.Message);
            }
            this.Hide();
        }

        private void EmailCreate_Load(object sender, EventArgs e)
        {

        }
    }
}
