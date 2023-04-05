using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AutoMeasurement
{
 
    public partial class MainForm : Form
    {
        Settings newForm;
        ConnectDevice cnct;
        public MainForm() //основная форма
        {
            cnct = new ConnectDevice();
            newForm = new Settings(cnct);
            InitializeComponent();
             //форма настройки
            
        }


        public MainForm(MainForm f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cs ces_form = new Cs(newForm);
            ces_form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rb rub_form = new Rb(newForm);
            rub_form.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            newForm.Show();
        }
    }
}
