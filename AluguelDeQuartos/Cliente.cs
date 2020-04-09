namespace AluguelDeQuartos
{
    internal class Cliente
    {
        
        public string nome { get; set; }
        public long cpf { get; set; }
        public string endereco { get; set; }
        public long celular { get; set; }
        public long telefone { get; set; }
        public string email { get; set; }

        
        public Cliente() { }

        public void Cadastrar()
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.celular = celular;
            this.telefone = telefone;
            this.email = email;

        }

        public void Atualizar()
        {
            if (this.cpf == cpf)
            {
                this.nome = nome;
                this.endereco = endereco;
                this.celular = celular;
                this.email = email;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Cliente não cadastrado","Aviso !!!!!",
                    System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void ConsultarCliente()
        {
            System.Windows.Forms.MessageBox.Show("Nome:" +nome+ "CPF:" + cpf + "Endereço:" + endereco +
                "Celular:" + celular + "Telefone:" + telefone + "Email:" + email);
        }

    } 
}