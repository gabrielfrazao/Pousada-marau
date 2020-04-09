namespace AluguelDeQuartos
{
    internal class Quarto
    {

        public string tipoQuarto { get; set; }
        public double valorDiaria { get; set; }
        public string arcondicionador { get; set; }
        public string hidromassagem { get; set; }
        public Quarto numeroQuartos { get; set; }

        public Quarto(){ }

        public void Atualizar()
        {
            this.tipoQuarto = tipoQuarto;
            this.valorDiaria = valorDiaria;
            this.arcondicionador = arcondicionador;
            this.hidromassagem = hidromassagem;
            this.numeroQuartos = numeroQuartos;
        }
        public void ConsultarInfo()
        {
            System.Windows.Forms.MessageBox.Show("Tipo de quarto:"+ tipoQuarto+" Arcodicionardor" +
                arcondicionador+ " Hidromassagem:"+ hidromassagem + " Valor da Diária:"+ valorDiaria
                + " Numero de Quartos"+ numeroQuartos);
        }
    }
}