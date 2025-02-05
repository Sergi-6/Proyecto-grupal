﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.TiendaRopa
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.Show();
        }

        private void nuevaventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formNuevaventa = new FormNuevaventa();
            formNuevaventa.MdiParent = this;
            formNuevaventa.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }
    }
}
