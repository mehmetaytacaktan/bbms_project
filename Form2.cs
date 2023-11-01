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

        public Form2(Form1 MainMenu)
        {
            InitializeComponent();
            this.MainMenu = MainMenu;

            DateTimePicker2.MinDate = DateTimeLimits.Min();
            DateTimePicker2.MaxDate = DateTimeLimits.Max();

            CreateTourPanel("2+1", "Mars > Jupiter", "12:00", "99H59M", "500TL");
            CreateTourPanel("2+1", "hkjh > Jupiter", "12:00", "99H59M", "500TL");
            CreateTourPanel("2+1", "Mars > Jupiter", "12:00", "99H59M", "500TL");
            CreateTourPanel("2+1", "Mars > Jupiter", "12:00", "99H59M", "500TL");
            CreateTourPanel("2+1", "Mars > Jupiter", "12:10", "99H59M", "500TL");
            CreateTourPanel("2+1", "Mars > Jupiter", "12:00", "99H59M", "500TL");
            CreateTourPanel("2+1", "Mars > Jupiter", "12:00", "01H59M", "500TL");
            CreateTourPanel("2+1", "Mars > Jupiter", "12:00", "99H59M", "500TL");
            CreateTourPanel("2+1", "Mars > Jupiter", "12:00", "99H59M", "550TL");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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

        public void CreateTourPanel(string sittingArrangement,
            string fromTo, string departureTime, string duration, string cost)
        {
            Panel panelTemp = new Panel();
            panelTemp.Size = new Size(470, 71);
            panelTemp.Location = (new Point(19 , 14 + (77 * TourList.Count)));
            panelTemp.BackColor = Color.White;

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
                        labelTemp.Text = cost;
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
    }
}