using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexibleList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            listControl1.Add("RADIO ACTIVE", "Smoke and Mirrors", "Imagine Dragons", new TimeSpan(0, 4, 16), 9);
        }
    }
}
