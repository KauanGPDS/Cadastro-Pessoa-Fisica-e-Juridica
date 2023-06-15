using pessoaFisica;
using pessoaJuridica;

namespace programaPrincipla
{
    class Principal
    {
        static void Main(string[] args)
        {
            PessoaFisica p1 = new PessoaFisica();
            p1.CadastraPessoaFisica();

            PessoaJuridica p2 = new PessoaJuridica();
            p2.CadastraPessoaJuridica();
            

            // Outras ações do programa principal
        }
    }
}