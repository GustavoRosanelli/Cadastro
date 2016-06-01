using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication
{
    public class Cadastro 
    {

        public Cadastro(string nome, string telefone, string cpf)
        {
            _nome = nome;
            _telefone = telefone;
            _cpf = cpf;
        }
 

        private string _nome = "";


        public string Nome
        {
            get {  return _nome;}
            set { _nome = value; }
        }
        
        private string _telefone = "";
        public string Telefone
        {
            get {  return _telefone; }
            set { _telefone = value; }

        }
        private string _cpf = "";
        public string Cpf
        {
            get
            {return _cpf;}
            set
            {_cpf = value; }
        }

   

    
    }
}
