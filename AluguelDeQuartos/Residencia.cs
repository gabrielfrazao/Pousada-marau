using System.Collections.Generic;

namespace AluguelDeQuartos
{
    internal class Residencia
    {
        public string endereco { get; set; }
        public long numero { get; set; }
        public string complemento { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string bairro { get; set; }
        public long cep { get; set; }
        public long telefone { get; set; }
        public List<Quarto> numeroQuartos;
               
                        
        public Residencia()
        {
        }
    }
}