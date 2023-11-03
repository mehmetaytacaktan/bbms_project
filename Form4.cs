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
    public enum Chairs
    {
        Empty,
        Male,
        Female
    }

    public partial class Form4 : Form
    {
        PictureBox[] seats;
        Chairs[] chairs = new Chairs[33];

        public Form4()
        {
            InitializeComponent();

            //************************************Database
            chairs[0] = Chairs.Male;
            chairs[4] = Chairs.Male;
            chairs[8] = Chairs.Female;
            chairs[10] = Chairs.Male;
            chairs[15] = Chairs.Female;
            chairs[30] = Chairs.Female;
            chairs[11] = Chairs.Male;
            chairs[12] = Chairs.Female;
            chairs[31] = Chairs.Female;

            seats = new PictureBox[]{
                pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9, pb10,
                pb11, pb12, pb13, pb14, pb15, pb16, pb17, pb18, pb19,
                pb20, pb21, pb22, pb23, pb24, pb25, pb26, pb27, pb28,
                pb29, pb30, pb31, pb32, pb33
            };

            int i = 0;
            foreach(Chairs gender in chairs)
            {
                if(gender == Chairs.Male)
                {
                    seats[i].Image = Properties.Resources.ChairMale;
                }
                else if(gender == Chairs.Female)
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
    }
}
