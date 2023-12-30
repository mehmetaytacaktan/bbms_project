using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace formProject
{
    public enum Gender
    {
        Empty,
        Male,
        Female
    }

    public partial class Form4 : Form
    {
        PictureBox[] seats;
        Gender[] chairs = new Gender[33];

        public Gender UsersGender = Gender.Male;
        List<int> TakenSeats = new List<int>();

        public Form4()
        {
            InitializeComponent();

            //************************************Database
            chairs[0] = Gender.Male;
            chairs[4] = Gender.Male;
            chairs[8] = Gender.Female;
            chairs[10] = Gender.Male;
            chairs[15] = Gender.Female;
            chairs[30] = Gender.Female;
            chairs[11] = Gender.Male;
            chairs[12] = Gender.Female;
            chairs[31] = Gender.Female;

            int i = 0;
            foreach (Gender gender in chairs)
            {
                if(gender != Gender.Empty)
                {
                    TakenSeats.Add(i);
                }
                i++;
            }

            seats = new PictureBox[]{
                pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9, pb10,
                pb11, pb12, pb13, pb14, pb15, pb16, pb17, pb18, pb19,
                pb20, pb21, pb22, pb23, pb24, pb25, pb26, pb27, pb28,
                pb29, pb30, pb31, pb32, pb33
            };

            resetSeats();
        }

        //name
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string output = "";

            foreach (char ch in textBox2.Text)
            {
                if (char.IsLetter(ch) && !char.IsNumber(ch))
                {
                    output += ch;
                }
            }

            textBox2.Text = output;
        }

        //card number
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 16)
            {
                textBox1.Text = textBox1.Text.Substring(0, 16);
            }
            else
            {
                string output = "";

                foreach (char ch in textBox1.Text)
                {
                    if (char.IsNumber(ch))
                    {
                        output += ch;
                    }
                }

                textBox1.Text = output;
            }
        }

        bool ManuallyChanged = true;
        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if(ManuallyChanged)
            {
                ManuallyChanged = false;
                checkBoxFemale.Checked = !checkBoxFemale.Checked;
                SetUsersGender();
            }
            else
            {
                ManuallyChanged = true;
            }
        }
        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (ManuallyChanged)
            {
                ManuallyChanged = false;
                checkBoxMale.Checked = !checkBoxMale.Checked;
                SetUsersGender();
            }
            else
            {
                ManuallyChanged = true;
            }
        }

        private void SetUsersGender()
        {
            if (checkBoxMale.Checked)
                UsersGender = Gender.Male;
            else
                UsersGender = Gender.Female;
        }

        //buy
        private void button1_Click(object sender, EventArgs e)
        {
            //************************************Database
        }

        void resetSeats()
        {
            int i = 0;
            foreach (Gender gender in chairs)
            {
                if (gender == Gender.Male)
                {
                    seats[i].Image = Properties.Resources.ChairMale;
                }
                else if (gender == Gender.Female)
                {
                    seats[i].Image = Properties.Resources.ChairFemale;
                }
                else
                {
                    seats[i].Image = Properties.Resources.Chair;
                }
                i++;
            }
        }

        void ChangeGivenSeat(int index)
        {
            bool SeatIsTaken = false;
            foreach (int takenSeat in TakenSeats)
            {
                if(takenSeat == index)
                {
                    SeatIsTaken = true;
                    break;
                }
            }

            if(!SeatIsTaken)
            {
                if(chairs[index] == UsersGender)
                {
                    chairs[index] = Gender.Empty;
                }
                else
                {
                    chairs[index] = UsersGender;
                }
                resetSeats();
            }
        }

        private void pb1_Click(object sender, EventArgs e) {ChangeGivenSeat(0);}
        private void pb4_Click(object sender, EventArgs e) {ChangeGivenSeat(3);}
        private void pb7_Click(object sender, EventArgs e) {ChangeGivenSeat(6);}
        private void pb10_Click(object sender, EventArgs e) {ChangeGivenSeat(9);}
        private void pb13_Click(object sender, EventArgs e) {ChangeGivenSeat(12);}
        private void pb16_Click(object sender, EventArgs e) {ChangeGivenSeat(15);}
        private void pb19_Click(object sender, EventArgs e) {ChangeGivenSeat(18);}
        private void pb22_Click(object sender, EventArgs e) {ChangeGivenSeat(21);}
        private void pb25_Click(object sender, EventArgs e) {ChangeGivenSeat(24);}
        private void pb28_Click(object sender, EventArgs e) {ChangeGivenSeat(27);}
        private void pb31_Click(object sender, EventArgs e) {ChangeGivenSeat(30);}
        private void pb32_Click(object sender, EventArgs e) {ChangeGivenSeat(31);}
        private void pb29_Click(object sender, EventArgs e) {ChangeGivenSeat(28);}
        private void pb26_Click(object sender, EventArgs e) {ChangeGivenSeat(25);}
        private void pb23_Click(object sender, EventArgs e) {ChangeGivenSeat(22);}
        private void pb20_Click(object sender, EventArgs e) {ChangeGivenSeat(19);}
        private void pb17_Click(object sender, EventArgs e) {ChangeGivenSeat(16);}
        private void pb14_Click(object sender, EventArgs e) {ChangeGivenSeat(13);}
        private void pb11_Click(object sender, EventArgs e) {ChangeGivenSeat(10);}
        private void pb8_Click(object sender, EventArgs e) {ChangeGivenSeat(7);}
        private void pb5_Click(object sender, EventArgs e) {ChangeGivenSeat(4);}
        private void pb2_Click(object sender, EventArgs e) {ChangeGivenSeat(1);}
        private void pb3_Click(object sender, EventArgs e) {ChangeGivenSeat(2);}
        private void pb6_Click(object sender, EventArgs e) {ChangeGivenSeat(5);}
        private void pb9_Click(object sender, EventArgs e) {ChangeGivenSeat(8);}
        private void pb12_Click(object sender, EventArgs e) {ChangeGivenSeat(11);}
        private void pb15_Click(object sender, EventArgs e) {ChangeGivenSeat(14);}
        private void pb18_Click(object sender, EventArgs e) {ChangeGivenSeat(17);}
        private void pb21_Click(object sender, EventArgs e) {ChangeGivenSeat(20);}
        private void pb24_Click(object sender, EventArgs e) {ChangeGivenSeat(23);}
        private void pb27_Click(object sender, EventArgs e) {ChangeGivenSeat(26);}
        private void pb30_Click(object sender, EventArgs e) {ChangeGivenSeat(29);}
        private void pb33_Click(object sender, EventArgs e) {ChangeGivenSeat(32);}
    }
}