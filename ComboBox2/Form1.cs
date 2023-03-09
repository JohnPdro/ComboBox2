using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (textNome.TextLength == 0)
                MessageBox.Show("Por favor digite algo", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textNome.Focus();

            {
                cmbSelecao.Items.Add(textNome.Text);
                textNome.Clear();
                textNome.Focus();
            }
        }

        private void cmbSelecao_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSelecao.SelectedIndex = 0;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (cmbSelecao.SelectedIndex == 0)
                MessageBox.Show("Por favor digite algo", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textNome.Focus();

            {
                cmbSelecao.Items.Remove(cmbSelecao.SelectedItem);
                cmbSelecao.SelectedIndex = 0;
            }
        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
