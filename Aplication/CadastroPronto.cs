using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplication
{
    public partial class CadastroPronto : Form
    {/*
        /// <summary>
        /// Construtor. Sem assinatura nenhuma. Possui o mesmo nome da classe e nenhum tipo de retorno.
        /// </summary>*/
        public CadastroPronto()
        {
            InitializeComponent();
           

        }
        //Construtor que recebe um parametro. Pode receber mais com a adição da virgula, seguida do parametro.
        public CadastroPronto(string Form2 ) //Parametros dento ()
        {
        }
        //Metodo, que recebe um parametro. Neste caso ''string teste''.
        //Retorno em string que é definida pelo programador.
        public string ExibeMensagem(string teste)
        {

            ExibeMensagem(teste, 1);
            return "Ola " + teste ;
        }

        //Metodo com dois parametros. Fazem a mesma coisa, de modo diferente.
        public string ExibeMensagem(string teste, int qt)
        {
            for (int i = 0; i < qt; i++)
            {
                MessageBox.Show(teste);
            }
            
            return teste;
        }
        //Variavel
        string teste1;
        //Property
        public string Teste1
        {
            get { return teste1; }
            set { teste1 = value; }
        }
        //Metodo normal, sem retorno.
         bool nomeValido = false;
         bool cpfValido = false;
         bool telefoneValido = false;

       private void textBox1_Leave(object sender, EventArgs e)
       {
           for (int i = 0; i <textBox1.Text.Length; i++)
           {
               if (!char.IsLetter(textBox1.Text[i]))
               {
                   MessageBox.Show("Nome não informado ou inválido.");
                   nomeValido = false;
                   return;
               }
           }
           if (textBox1.Text.Length >= 3)
               nomeValido = true;
           else
           {
               MessageBox.Show("Nome não informado ou inválido.");
               nomeValido = false;
           }
       }
       
        private void textBox2_Leave(object sender, EventArgs e)
        {
            
              //     char.is
            for (int i = 0; i <textBox2.Text.Length; i++)
            {
                if (!char.IsNumber(textBox2.Text[i]))
                {

                    MessageBox.Show("Telefone não informado ou inválido.");
                    telefoneValido = false;
                    return ;
                }
                
            }



            if (textBox2.Text == "" || textBox2.Text.Length < 8 || textBox2.Text.Length > 9)
            {
                MessageBox.Show("Telefone não informado ou inválido.");
                telefoneValido = false;
            }
            else
            {
                textBox2.Text = string.Format("(55){0}-{1}", textBox2.Text.Substring(0, 4), textBox2.Text.Substring(4, 
                    textBox2.Text.Length == 8 ? 4 : 5));
                telefoneValido = true;
            }
        }

       
        private void textBox3_Leave(object sender, EventArgs e)
        {

            for (int i = 0; i < textBox3.Text.Length; i++)
            {
                if (!char.IsNumber(textBox3.Text[i]))
                {
                    cpfValido = false;
                    MessageBox.Show("CPF não informado ou inválido.");
                    return;
                }
            }


            if (textBox3.Text == "" || textBox3.Text.Length != 11)
            {
                MessageBox.Show("CPF não informado ou inválido.");
                cpfValido = false;
            }
            else
            {
                textBox3.Text = string.Format("{0}.{1}.{2}-{3}", textBox3.Text.Substring(0, 3), textBox3.Text.Substring(3, 3), 
                    textBox3.Text.Substring(6, 3), textBox3.Text.Substring(9, 2));
                cpfValido = true;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.Replace("-", "");
            textBox2.Text = textBox2.Text.Replace("(55)", "");
   
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text.Replace("-", "");
            textBox3.Text = textBox3.Text.Replace(".", "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro cadastroPessoa = new Cadastro(textBox1.Text, textBox2.Text, textBox3.Text);


            if (nomeValido && telefoneValido && cpfValido)
            {
                textBox2.Text = cadastroPessoa.Telefone;
                textBox3.Text = cadastroPessoa.Cpf;
                ExibeMensagem(cadastroPessoa.Nome + ", Você foi cadastrado com sucesso!");
                //Close();
            }
            else MessageBox.Show("Cadastro Inválido.");

           

           
        }

                           

        
    }
        
}

