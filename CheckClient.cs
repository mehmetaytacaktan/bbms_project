using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BMSAdminPanel
{
    public partial class CheckClient : Form
    {
        AdminPanel adminPanel = null;
        public CheckClient(AdminPanel adminPanel)
        {
            this.adminPanel = adminPanel;
            InitializeComponent();

            List<string> ClientIDs = new List<string>();
            //0000000, 0000001, 0000002, 0000003
            //*************************************************DataBase
            for (int i = 1; i <= 1297; i++)
            {
                string CurrentID = "";
                int digits = (int)Math.Log10(i) + 1; // get the number of digits in i
                CurrentID = ""; // reset the CurrentID
                for (int j = 0; j < 7 - digits; j++)
                {
                    CurrentID += "0"; // add zeros to the CurrentID
                }

                CurrentID += i;
                ClientIDs.Add(CurrentID);
            }
            foreach (var ClientID in ClientIDs)
            {
                cmbboxClientIDs.Items.Add(ClientID);
            }

            //*************************************************Database
            //Add name, surname etc as string to listView1
        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            adminPanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SelectedUserID = cmbboxClientIDs.SelectedText;
            //write the user with the selected ID on top.
            //*************************************************Database
        }
    }
}