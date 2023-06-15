using System;
using System.IO;

namespace pessoaFisica
{
    class PessoaFisica
    {
        private string caminhoParaArquivoTxt = @"C:\Users\lipih\OneDrive\Área de Trabalho\backCSenai\AtividadeBackEnd1Senai\arquivo.txt";
        private StreamWriter smt;
        private string cpf = "";

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public void CadastraPessoaFisica()
        {
            int controlador = 0;


                   

                
            while (controlador != 1)
            {
                Console.WriteLine("Digite o dia do seu nascimento: ");
                int dia = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o mês do seu nascimento: ");
                int mes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o ano do seu nascimento: ");
                int ano = Convert.ToInt32(Console.ReadLine());
                DateTime dataNascimento = new DateTime(ano, mes, dia);
                DateTime dataAtual = DateTime.Now;

                
                    controlador = 1;
                    Console.WriteLine("Data de nascimento cadastrada com sucesso!");
                    var dataFormatada = dataNascimento.ToString("dd-MM-yyyy");

                    using (smt = new StreamWriter(caminhoParaArquivoTxt, true))
                    {
                        smt.WriteLine("Pessoa Fisica");
                        smt.WriteLine(dataFormatada);
                    }
                
            }

            while (cpf.Length != 11)
            {
                Console.WriteLine("Digite o CPF: ");
                string tempCpf = Console.ReadLine();
                if (tempCpf.Length == 11)
                {
                    Console.WriteLine("CPF cadastrado com sucesso!!");
                    cpf = tempCpf;

                    using (smt = new StreamWriter(caminhoParaArquivoTxt, true))
                    {
                        smt.WriteLine(cpf);
                    }
                }
                else
                {
                    Console.WriteLine("CPF inválido :(");
                }
            }

            int controlador2 = 0;
            

            while (controlador2 != 1)
            {
                Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();
                string caracteresEspeciais = "!@#$%^&*()0-_123456789";

                bool possuiCaractereEspecial = true;

                foreach (char c in nome)
                {
                    if (caracteresEspeciais.Contains(c))
                    {
                        possuiCaractereEspecial = false;
                        break;
                    }
                }

                if (possuiCaractereEspecial != false) 
                {
                    Console.WriteLine("Nome cadastrado com sucesso!");
                    controlador2 = 1;
                    Console.WriteLine("-------------------------------------");

                    using (smt = new StreamWriter(caminhoParaArquivoTxt, true))
                    {
                        smt.WriteLine(nome);
                    }
                }
                else
                {
                    Console.WriteLine("Nome não cadastrado pois possui caractere especial");
               
            }
        }
                    Console.WriteLine("Qual valor da Compra ?");
                    string input = Console.ReadLine();
                    float valor = float.Parse(input);
                    
                    float calculo = (4*valor)/100;
                    Console.WriteLine("Valor do Imposto -> "+calculo);
                    using(smt = new StreamWriter(caminhoParaArquivoTxt, true))
                    {
                        
                        smt.WriteLine("Imposto para pagar -> " + calculo.ToString());
                    }
          }
               
    }
}

namespace pessoaJuridica
{
    class PessoaJuridica
    {
        private string caminhoParaArquivoTxt = @"C:\Users\lipih\OneDrive\Área de Trabalho\backCSenai\AtividadeBackEnd1Senai\arquivo.txt";
        private StreamWriter smt;
        private string cpf = "";

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public void CadastraPessoaJuridica()
        {
           
int controlador1 = 0;
        string cnpj = "";
            while (controlador1 != 1)
            {
                Console.WriteLine("Digite o cnpj: ");
                string tempCnpj = Console.ReadLine();
                if (tempCnpj.Length == 14)
                {
                    Console.WriteLine("Cnpj cadastrado com sucesso!!");
                    cpf = tempCnpj;
                    controlador1 = 1;

                    using (smt = new StreamWriter(caminhoParaArquivoTxt, true))
                    {
                        smt.WriteLine("Pessoa Juridica");
                        smt.WriteLine(cnpj);
                    }
                }
                else
                {
                    Console.WriteLine("Cnpj inválido :(");
                }
            }

            int controlador2 = 0;
            

            while (controlador2 != 1)
            {
                Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();
                string caracteresEspeciais = "!@#$%^&*()0-_123456789";

                bool possuiCaractereEspecial = true;

                foreach (char c in nome)
                {
                    if (caracteresEspeciais.Contains(c))
                    {
                        possuiCaractereEspecial = false;
                        break;
                    }
                }

                if (possuiCaractereEspecial != false) 
                {
                    Console.WriteLine("Nome cadastrado com sucesso!");
                    controlador2 = 1;
                    Console.WriteLine("-------------------------------------");

                    using (smt = new StreamWriter(caminhoParaArquivoTxt, true))
                    {
                        smt.WriteLine(nome);
                    }
                }
                else
                {
                    Console.WriteLine("Nome não cadastrado pois possui caractere especial");
               
            }
        }
                    Console.WriteLine("Qual valor da Compra ?");
                    string input = Console.ReadLine();
                    float valor = float.Parse(input);
                    
                    float calculo = (7*valor)/100;
                    Console.WriteLine("Valor do Imposto -> "+calculo);
                    using(smt = new StreamWriter(caminhoParaArquivoTxt, true))
                    {
                        
                        smt.WriteLine("Imposto para pagar -> " + calculo.ToString());
                    }
          }
               
    }
}
