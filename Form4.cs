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

        Gender UsersGender = Gender.Male;//************************************Database

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

            seats = new PictureBox[]{
                pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9, pb10,
                pb11, pb12, pb13, pb14, pb15, pb16, pb17, pb18, pb19,
                pb20, pb21, pb22, pb23, pb24, pb25, pb26, pb27, pb28,
                pb29, pb30, pb31, pb32, pb33
            };

            resetSeats();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

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

            //string input = textBox1.Text;
            //string inputWoSpace = "";
            //string seperator = " ";
            //
            //foreach (char _char in input)
            //{
            //    if(_char != seperator[0])
            //    {
            //        inputWoSpace += _char;
            //    }
            //}
            //
            //inputWoSpace.Replace(seperator, "");
            //
            //if (inputWoSpace.Length % 4 == 0 && !textBox1.Text.EndsWith(seperator))
            //{
            //    textBox1.Text = textBox1.Text + seperator;
            //    Debug.Print(textBox1.Text);
            //}
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

        private void pb1_Click(object sender, EventArgs e)
        {
            chairs[0] = UsersGender;
            resetSeats();
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            chairs[3] = UsersGender;
            resetSeats();
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            chairs[6] = UsersGender;
            resetSeats();
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            chairs[9] = UsersGender;
            resetSeats();
        }

        private void pb13_Click(object sender, EventArgs e)
        {
            chairs[12] = UsersGender;
            resetSeats();
        }

        private void pb16_Click(object sender, EventArgs e)
        {
            chairs[15] = UsersGender;
            resetSeats();
        }

        private void pb19_Click(object sender, EventArgs e)
        {
            chairs[18] = UsersGender;
            resetSeats();
        }

        private void pb22_Click(object sender, EventArgs e)
        {
            chairs[21] = UsersGender;
            resetSeats();
        }

        private void pb25_Click(object sender, EventArgs e)
        {
            chairs[24] = UsersGender;
            resetSeats();
        }

        private void pb28_Click(object sender, EventArgs e)
        {
            chairs[27] = UsersGender;
            resetSeats();
        }

        private void pb31_Click(object sender, EventArgs e)
        {
            chairs[30] = UsersGender;
            resetSeats();
        }

        private void pb32_Click(object sender, EventArgs e)
        {
            chairs[31] = UsersGender;
            resetSeats();
        }

        private void pb29_Click(object sender, EventArgs e)
        {
            chairs[28] = UsersGender;
            resetSeats();
        }

        private void pb26_Click(object sender, EventArgs e)
        {
            chairs[25] = UsersGender;
            resetSeats();
        }

        private void pb23_Click(object sender, EventArgs e)
        {
            chairs[22] = UsersGender;
            resetSeats();
        }

        private void pb20_Click(object sender, EventArgs e)
        {
            chairs[19] = UsersGender;
            resetSeats();
        }

        private void pb17_Click(object sender, EventArgs e)
        {
            chairs[16] = UsersGender;
            resetSeats();
        }

        private void pb14_Click(object sender, EventArgs e)
        {
            chairs[13] = UsersGender;
            resetSeats();
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            chairs[10] = UsersGender;
            resetSeats();
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            chairs[7] = UsersGender;
            resetSeats();
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            chairs[4] = UsersGender;
            resetSeats();
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            chairs[1] = UsersGender;
            resetSeats();
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            chairs[2] = UsersGender;
            resetSeats();
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            chairs[5] = UsersGender;
            resetSeats();
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            chairs[8] = UsersGender;
            resetSeats();
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            chairs[11] = UsersGender;
            resetSeats();
        }

        private void pb15_Click(object sender, EventArgs e)
        {
            chairs[14] = UsersGender;
            resetSeats();
        }

        private void pb18_Click(object sender, EventArgs e)
        {
            chairs[17] = UsersGender;
            resetSeats();
        }

        private void pb21_Click(object sender, EventArgs e)
        {
            chairs[20] = UsersGender;
            resetSeats();
        }

        private void pb24_Click(object sender, EventArgs e)
        {
            chairs[23] = UsersGender;
            resetSeats();
        }

        private void pb27_Click(object sender, EventArgs e)
        {
            chairs[26] = UsersGender;
            resetSeats();
        }

        private void pb30_Click(object sender, EventArgs e)
        {
            chairs[29] = UsersGender;
            resetSeats();
        }

        private void pb33_Click(object sender, EventArgs e)
        {
            chairs[32] = UsersGender;
            resetSeats();
        }
    }
}