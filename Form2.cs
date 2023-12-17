using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formProject
{
    public partial class Form2 : Form
    {
        List<Panel> TourList = new List<Panel>();

        readonly Form1 MainMenu;
        readonly Form2 SelectMenu;

        bool isFemale = false;

        Form4 form4 = new Form4();

        public Form2(Form1 MainMenu)
        {
            InitializeComponent();
            
            form4.Hide();

            this.MainMenu = MainMenu;
            SelectMenu = this;

            DateTimePicker2.MinDate = DateTimeLimits.Min();
            DateTimePicker2.MaxDate = DateTimeLimits.Max();

            //********************************DataBase
            CreateTourPanel("2+1", "Mars > Jupiter", "12:00", "99H59M", 500);
            CreateTourPanel("2+1", "hkjh > Jupiter", "12:00", "99H59M", 500);
            CreateTourPanel("2+1", "Mars > Jupiter", "12:00", "99H59M", 500);
            CreateTourPanel("2+1", "Mars > Jupiter", "12:00", "99H59M", 500);
            CreateTourPanel("2+1", "Mars > Jupiter", "12:10", "99H59M", 500);
            CreateTourPanel("2+1", "Mars > Jupiter", "12:00", "99H59M", 500);
            CreateTourPanel("2+1", "Mars > Jupiter", "12:00", "01H59M", 500);
            CreateTourPanel("2+1", "Mars > Jupiter", "12:00", "99H59M", 500);
            CreateTourPanel("2+1", "Mars > Jupiter", "12:00", "99H59M", 550);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenu.Show();
            this.Hide();
        }

        private void BtnPrevDay_Click(object sender, EventArgs e)
        {
            if(!(DateTimePicker2.Value.AddDays(-1) < DateTimeLimits.Min()))
            {
                DateTimePicker2.Value = DateTimePicker2.Value.AddDays(-1);
            }
        }

        private void BtnNextDay_Click(object sender, EventArgs e)
        {
            if (!(DateTimePicker2.Value.AddDays(1) > DateTimeLimits.Max()))
            {
                DateTimePicker2.Value = DateTimePicker2.Value.AddDays(1);
            }
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        public void ReWriteDate(DateTime dateToWrite)
        {
            DateTimePicker2.Value = dateToWrite;
        }

        void switchToBuyScreen(object sender, EventArgs e, int cost)
        {
            form4.Show();
            if(isFemale)
            {
                form4.UsersGender = Gender.Female;
            }
            else
            {
                form4.UsersGender = Gender.Male;
            }
        }

        public void CreateTourPanel(string sittingArrangement,
            string fromTo, string departureTime, string duration, int cost)
        {
            Panel panelTemp = new Panel();
            panelTemp.Size = new Size(470, 71);
            panelTemp.Location = (new Point(19 , 14 + (77 * TourList.Count)));
            panelTemp.BackColor = Color.White;

            //this.Load += new System.EventHandler(this.Form2_Load);
            panelTemp.Click += (sender, e) => switchToBuyScreen(sender, e, cost);

            for (int i = 0; i < 5; i++)
            {
                Label labelTemp = new Label();
                switch (i)
                {
                    case 0:
                        labelTemp.Location = (new Point(27, 22));
                        labelTemp.Text = sittingArrangement;
                        labelTemp.Font = ChangeFontSize(labelTemp.Font, 14);
                        break;
                    case 1:
                        labelTemp.Location = (new Point(3, 46));
                        labelTemp.Text = fromTo;
                        labelTemp.Font = ChangeFontSize(labelTemp.Font, 15);
                        break;
                    case 2:
                        labelTemp.Location = (new Point(189, 1));
                        labelTemp.Text = departureTime;
                        labelTemp.Font = ChangeFontSize(labelTemp.Font, 20);
                        break;
                    case 3:
                        labelTemp.Location = (new Point(192, 32));
                        labelTemp.Text = duration;
                        labelTemp.Font = ChangeFontSize(labelTemp.Font, 14);
                        break;
                    case 4:
                        labelTemp.Location = (new Point(373, 20));
                        labelTemp.Text = cost + "TL";
                        labelTemp.Font = ChangeFontSize(labelTemp.Font, 20);
                        break;
                }

                labelTemp.AutoSize = true;
                panelTemp.Controls.Add(labelTemp);
            }
            panel3.Controls.Add(panelTemp);
            TourList.Add(panelTemp);
        }

        Font ChangeFontSize(Font font, float size)
        {
            return new Font(font.FontFamily, size, font.Style);
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            isFemale = checkBoxFemale.Checked;

            //Female is changed
            checkBoxMale.Checked = !checkBoxFemale.Checked;
        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            isFemale = !checkBoxMale.Checked;

            //Male is changed
            checkBoxFemale.Checked = !checkBoxMale.Checked;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}