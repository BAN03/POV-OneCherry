﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POV_OneCherry
{
    public partial class PrimerPantallaLogin : Form
    {
        public PrimerPantallaLogin()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form admin = new LoginAdmin();
            admin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form empleado = new LoginEmpleado();
            empleado.ShowDialog();
            new LoginEmpleado().ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form empleado = new Empleado();
            empleado.ShowDialog();
        }

        private void PrimerPantallaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
