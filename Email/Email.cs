using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Email
{
    public partial class Email : Form
    {
        public Boolean passwordOpened = true;
        private Password password;
        public Email()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (isValidEmail(fromBox.Text))
            {
                if (isValidEmail(toBox.Text))
                {
                    if (subjectBox.Text.Length > 0)
                    {
                        if (bodyBox.Text.Length > 0) {
                            password = new Password();
                            password.ShowDialog();

                            String passwordVal = password.getPassword();
                            if (passwordVal.Length > 0)
                            {
                                try
                                {
                                    MailMessage msg = new MailMessage();
                                    msg.From = new MailAddress(fromBox.Text);
                                    msg.To.Add(toBox.Text);
                                    msg.Subject = subjectBox.Text;

                                    SmtpClient smt = new SmtpClient("mansci-445.uwaterloo.ca", 587);
                                    //smt.Host = "mansci-445.uwaterloo.ca";
                                    smt.DeliveryMethod = SmtpDeliveryMethod.Network;
                                    smt.UseDefaultCredentials = false;
                                    System.Net.NetworkCredential netWorkCred = new NetworkCredential("emchanle", passwordVal);
                                    smt.Credentials = netWorkCred;
                                    smt.EnableSsl = false;
                                    //smt.Port = 587;
                                    smt.Send(msg);
                                    MessageBox.Show("Your Mail is sent!");

                                }

                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.ToString());
                                    MessageBox.Show("Failure when sending mail");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password entry canceled");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please add body to email");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please add a subject line to the email");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid to email entered");
                }
            }
            else
            {
                MessageBox.Show("Invalid from email entered");
            }

        }

        private static Boolean isValidEmail(String email)
        {
            return email.EndsWith("@uwaterloo.ca");
        }

        private void bodyBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
