using formProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formProject
{
    public partial class Driver : Form
    {
        PictureBox[] chairs;
        public Driver()
        {
            InitializeComponent();
            chairs = new PictureBox[]
            {
                pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8,
                pb9, pb10, pb11, pb12, pb13, pb14, pb15,
                pb16, pb17, pb18, pb19, pb20, pb21,
                pb22, pb23, pb24, pb25, pb26, pb27,
                pb28, pb29,pb30, pb31, pb32, pb33
            };

            //*****************************add from database
            comboBox2.Items.Add("Moscow");
            comboBox2.Items.Add("France");
            comboBox2.Items.Add("Chile");
            comboBox2.Items.Add("Turkey");
        }

        private void Driver_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //******************Read from database
            ToFemale(pb1);
            ToFemale(pb3);
            ToFemale(pb28);
            ToFemale(pb11);
            ToMale(pb17);
            ToMale(pb21);
            ToMale(pb2);
            ToMale(pb33);
        }

        void ToFemale(PictureBox subject)
        {
            subject.Image = Resources.ChairFemale;
        }
        void ToMale(PictureBox subject)
        {
            subject.Image = Resources.ChairMale;
        }
    }
}
