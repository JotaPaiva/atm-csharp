using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contaBancaria
{
    public partial class frmContaBancaria : Form
    {
        public frmContaBancaria()
        {
            InitializeComponent();
        }

        string nomeCliente;
        double saldoCliente = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnEntrar;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            nomeCliente = txtNome.Text;
            txtNomeCliente.Text = nomeCliente;
            try
            {
                if (nomeCliente == "")
                {
                    MessageBox.Show("O campo deve ser preenchido!");
                }
                else
                {
                    grpLogin.Visible = false;
                    grpSaudacao.Visible = true;
                    grpOpcoes.Visible = true;
                    txtSaldo.Text = saldoCliente.ToString("c");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado, tente novamente!");
            }                        
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            grpValorDeposito.Visible = true;
            grpOpcoes.Visible = false;
            this.AcceptButton = btnConfirmarDepósito;
        }

        private void btnConfirmarDepósito_Click(object sender, EventArgs e)
        {
            try
            {
                double valorDeposito = Convert.ToDouble(txtValorDepósito.Text);
                saldoCliente = saldoCliente + valorDeposito;
                txtSaldo.Text = saldoCliente.ToString("c");
                grpOpcoes.Visible = true;
                grpSaudacao.Enabled = true;
                grpValorDeposito.Visible = false;
                txtValorDepósito.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Insira um valor válido!");
                txtValorDepósito.Clear();
            }                        
        }        

        private void btnSacar_Click_1(object sender, EventArgs e)
        {
            grpValorSaque.Visible = true;
            grpOpcoes.Visible = false;
            grpValorDeposito.Visible = false;
            txtValorDepósito.Clear();
            this.AcceptButton = btnConfirmarSaque;
        }

        private void btnConfirmarSaque_Click(object sender, EventArgs e)
        {
            try
            {
                double valorSaque = Convert.ToDouble(txtValorSaque.Text);
                if (valorSaque <= saldoCliente)
                {
                    saldoCliente = saldoCliente - valorSaque;
                    txtSaldo.Text = saldoCliente.ToString("c");
                    grpOpcoes.Visible = true;
                    grpSaudacao.Enabled = true;
                    grpValorSaque.Visible = false;
                    txtValorSaque.Clear();
                }
                else
                {
                    MessageBox.Show("Saldo Insuficiente!");
                    txtValorSaque.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Insira um valor válido!");
                txtValorSaque.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpOpcoes.Visible = true;
            txtValorSaque.Clear();
            txtValorDepósito.Clear();
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            grpOpcoes.Visible = true;
            txtValorSaque.Clear();
            txtValorDepósito.Clear();
        }
    }
}
