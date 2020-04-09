using System;

namespace AluguelDeQuartos
{
    internal class Aluguel
    {

        public string nomeLocatario { get; set; }
        public DateTime dataEntada { get; set; }
        public DateTime dataSaida { get; set; }
        public int totaDiarias { get; set; }
        public double totalPagar {get; set;}
       

        public Aluguel()
        {
        }
        public void AtualizarAluguel()
        {
            if (this.nomeLocatario == nomeLocatario)
            {
                this.nomeLocatario = nomeLocatario;
                this.dataEntada = dataEntada;
                this.dataSaida = dataSaida;
                this.totaDiarias = totaDiarias;
                this.totalPagar = totalPagar;
            }
            
        }
        public void ConsultarAluguel()
        {
            System.Windows.Forms.MessageBox.Show("Nome do Locatario:"+nomeLocatario+" Data de Entrada:"+ dataEntada
                +" Data de Saída:"+ dataSaida+"Numero de Diarias:"+totaDiarias+"Valor a Pagar:"+totalPagar);
        }

        public void CalcularDiarias()
        {
            totaDiarias = dataSaida.Day - dataEntada.Day;
            if(dataSaida.Hour > 12)
            {
                totaDiarias = totaDiarias + 1;
            }
        }
        
        public double ValorDiarias(double soma)
        {
            Quarto quarto = new Quarto();
            
            if (quarto.tipoQuarto == "Casal")
            {
                soma = 100.00;
            }
            else
            {
                soma = 80.00;
            }
            if (quarto.arcondicionador == "comAr")
            {
                soma = soma + 30.00;
            }
            if (quarto.hidromassagem == "comHidro")
            {
                soma = soma + 50.00;
            }

            return soma;            
        }
    }
   
}