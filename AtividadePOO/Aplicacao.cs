using System;

namespace Atividade1
{
    class Aplicacao
    {
        public const decimal Juros = 0.6M;
        
        static void Main(string[] args)
        {
            int sum = 0;
            int id_contaCorrente = 0;
            int id_contaPoupanca = 0;

            Banco bb = new Banco();
            bool init = true;
            while (init)
            {
               
                MenuAgencia();
                int op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Agencia agencia = new Agencia();
                    agencia.IdAgencia = sum;
                    bb.AdicionarAgencia(agencia);
                    sum++;

                }
                else if (op == 2)
                {
                    Cliente cliente = new Cliente();
                    Console.WriteLine("digite o nome do titular: ");
                    string nome_cliente = Console.ReadLine();
                    cliente.Nome = nome_cliente;

                    Console.WriteLine("Temos 2 tipos de conta, qual deseja?\n");
                    Console.WriteLine("1 - Conta Corrente: ");
                    Console.WriteLine("2 - Conta Poupança: ");

                    int tipo_conta = int.Parse(Console.ReadLine());
                    if (tipo_conta == 1)
                    {
                        ContaCorrente cc = new ContaCorrente(cliente.Nome);
                        Console.WriteLine("Digite o numero da agência: ");
                        int numAgencia = int.Parse(Console.ReadLine());

                        Agencia agencia = bb.buscaAgencia(numAgencia);
                        if (agencia != null)
                        {
                            cc.Id = id_contaCorrente;
                            agencia.AdicionarContaCorrente(cc);
                            id_contaCorrente++;
                        }
                        else
                        {
                            Console.WriteLine("Dados errado, tente novamente.");
                        }
                        
                    }
                    else if (tipo_conta == 2)
                    {
                        ContaPoupanca cp = new ContaPoupanca(Juros, DateTime.Now, cliente.Nome);
                        Console.WriteLine("Digite o numero da agência: ");
                        int numAgencia = int.Parse(Console.ReadLine());

                        Agencia agencia = bb.buscaAgencia(numAgencia);
                        if (agencia != null)
                        {
                            cp.Id = id_contaPoupanca;
                            agencia.AdicionarContaPoupanca(cp);
                            id_contaPoupanca++;
                        }
                        else
                        {
                            Console.WriteLine("Dados errado, tente novamente.");
                        }
                        
                    }
                }
                else if (op == 3)
                {
                    Solicitacao solicitacao = new Solicitacao();
                    solicitacao.realizarSolicitacao(bb);

                    
                }
                else if (op == 4)
                {
                    bb.listaIdAgencias();


                }
                else if( op == 0)
                {
                    init = false;
                }


            }
        }

        public static void MenuAgencia()
        {
            Console.WriteLine("Bem vindo ao nosso Banco, oque deseja?");
            Console.WriteLine(" 1 - Cadastrar Agência  ");
            Console.WriteLine(" 2 - Criar Conta ");
            Console.WriteLine(" 3 - Abrir uma Sessão ");
            Console.WriteLine(" 4 - Listar agências ");
            Console.WriteLine(" 0 - Sair");
        }



    }
}
