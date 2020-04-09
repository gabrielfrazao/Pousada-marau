using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AluguelDeQuartos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        TimeSpan totalDiarias;
        int tdiarias;
        int saida;
        double soma;
        double resultado;
        Cliente cliente = new Cliente();
        Aluguel aluguel = new Aluguel();
     
      
       
        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy HH:mm:ss";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy HH:mm:ss";
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {


        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                totalDiarias = dateTimePicker2.Value - dateTimePicker1.Value;
                tdiarias = Convert.ToInt32(totalDiarias.Days);
                saida = Convert.ToInt32(dateTimePicker2.Value.Hour);
                if (saida >= 12)
                {
                    tdiarias = tdiarias + 1;
                }

                txtTotal.Text = tdiarias.ToString();
                resultado = tdiarias * soma;
                txtPagar.Text = resultado.ToString();

                MessageBox.Show("Data de Entrada:  " + dateTimePicker1.Text + "\n Data de Saída:  "
                    + dateTimePicker2.Text + "\n Total de Diárias:  " + tdiarias);





            }
            catch (FaultException)
            {
                MessageBox.Show("Erro Ao Fatura e Calcular Sistema !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

      
        private void button1_Click(object sender, EventArgs e)
        {
           
            cliente.nome = txtNomeCadastro.Text;
            cliente.cpf = Convert.ToInt64(mskCpf.Text);
            cliente.endereco = txtenderecoCadastro.Text;
            cliente.celular = Convert.ToInt64(mskCelular.Text);
            cliente.telefone = Convert.ToInt64(mskTelefone.Text);
            cliente.email = txtEmailCadastro.Text;

            cliente.Cadastrar();
                       
            txtNomeCadastro.Clear();
            mskCpf.Clear();
            txtenderecoCadastro.Clear();
            mskCelular.Clear();
            mskTelefone.Clear();
            txtEmailCadastro.Clear();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Correios.AtendeClienteClient consulta = new Correios.AtendeClienteClient("AtendeClientePort");

                var resultado = consulta.consultaCEP(mskCep.Text);

                if (resultado != null)
                {
                    txtEnderecoResidencia.Text = resultado.end;
                    txtComplemento.Text = resultado.complemento;
                    txtBairroRsidencia.Text = resultado.bairro;
                    txtCidade.Text = resultado.cidade;
                    txtEstado.Text = resultado.uf;

                }

            }
            catch (FaultException)
            {
                MessageBox.Show("Cep é inexistente !!!!", "Aviso !!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCep.Clear();
            }
        }

        private void btnSalvarResidencia_Click(object sender, EventArgs e)
        {

            Residencia residencia = new Residencia();
            residencia.endereco = txtEnderecoResidencia.Text;
            residencia.numero = Convert.ToInt32(mskNumero.Text);
            residencia.complemento = txtComplemento.Text;
            residencia.cidade = txtCidade.Text;
            residencia.estado = txtEstado.Text;
            residencia.telefone = Convert.ToInt32(mskTelefone.Text);
            
            

            txtEnderecoResidencia.Clear();
            txtComplemento.Clear();
            txtBairroRsidencia.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            mskNumero.Clear();
            mskCep.Clear();
            mskTelefoneResidencia.Clear();
            txtNumeroQuartos.Clear();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            
                if (txtTq.Text == "Casal")
                {
                    soma = 100.00;
                }
                else
                {
                    soma = 80.00;
                }
                if (txtAr.Text == "comAr")
                {
                    soma = soma + 30.00;
                }
                if (txthidro.Text == "comHidro")
                {
                    soma = soma + 50.00;
                }
            txtValorDiaria.Text = Convert.ToString(soma);

            }

        private void cbQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTq.Text = cbQuarto.SelectedItem.ToString();

        }

       

        private void cbAr_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAr.Text = cbAr.SelectedItem.ToString();
        }

        private void cbHidro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txthidro.Text = cbHidro.SelectedItem.ToString();
        }

        private void btnSairAluguel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void btnSalvarAluguel_Click(object sender, EventArgs e)
        {
            Quarto quarto = new Quarto();
            quarto.tipoQuarto = txtTq.Text;
            quarto.arcondicionador = txtAr.Text;
            quarto.hidromassagem = txthidro.Text;
            quarto.valorDiaria = Convert.ToDouble(txtValorDiaria.Text);

            txtTq.Clear();
            txtAr.Clear();
            txthidro.Clear();
            txtValorDiaria.Clear();
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Aluguel aluguel = new Aluguel();
            aluguel.nomeLocatario = txtLocatario.Text;
            aluguel.dataEntada = dateTimePicker1.Value;
            aluguel.dataSaida = dateTimePicker2.Value;
            aluguel.totalPagar = Convert.ToDouble(txtPagar.Text);


         }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
          
            cliente.Atualizar();
        }

       
    }
}
