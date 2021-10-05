﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Administrador
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        Form1 Logs = new Form1();

        private void button1_Click(object sender, EventArgs e)
        {
            Productos dest = new Productos();
            this.Hide();
            dest.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {    
            Logs.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleados dest = new Empleados();
            this.Hide();
            dest.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clientes dest = new Clientes();
            this.Hide();
            dest.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Proveedores dets = new Proveedores();
            this.Hide();
            dets.ShowDialog();
        }
    }
}
