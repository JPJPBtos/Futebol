using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futebol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
        }

        private void btnAdiciona_Click(object sender, EventArgs e)
        {
            lstJogadores.Items.Add(txtNome.Text);
            txtNome.Clear();
            txtNome.Focus();
        }

        private void btnAdicionaJogo_Click(object sender, EventArgs e)
        {
            lstConfirmados.Items.Add(lstJogadores.Text);
            if (lstMachucados.Items.Contains(lstJogadores.SelectedItem))
            {
               
                MessageBox.Show("Jogador esta machucado");
                lstConfirmados.Items.Remove(lstJogadores.SelectedItem);
            }

        }

        private void btnRetiraJogo_Click(object sender, EventArgs e)
        {           
            lstConfirmados.Items.Remove(lstConfirmados.Text);
        }

        private void btnMachucado_Click(object sender, EventArgs e)
        {
            lstMachucados.Items.Add(lstJogadores.Text);
        }

        private void btnRecuperado_Click(object sender, EventArgs e)
        {
            lstMachucados.Items.Remove(lstMachucados.Text);
        }

        private void btnLimparListaJogadores_Click(object sender, EventArgs e)
        {
            lstJogadores.Items.Clear();
        }

        private void btnLimparMachucado_Click(object sender, EventArgs e)
        {
            lstMachucados.Items.Clear();
        }

        private void lstJogadores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lstJogadores.Items.Remove(lstJogadores.SelectedItem);
        }
    }
    }
