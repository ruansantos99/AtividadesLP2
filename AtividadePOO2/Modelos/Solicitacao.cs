using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Atividade1
{
    public class Solicitacao
    {
       public void realizarSolicitacao(Banco banco)
        {
            Console.WriteLine("Digite o numero da agência: ");
            int numAgencia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tipo da conta: 1 - Corrente/ 2 - Poupança");
            Console.WriteLine("1 - Corrente:");
            Console.WriteLine("2 - Poupança:");
            int tipo_conta = int.Parse(Console.ReadLine());

            if (tipo_conta == 1)
            {
                Console.WriteLine("Digite o numero da sua conta: ");
                int num_conta = int.Parse(Console.ReadLine());
                Agencia agencia = banco.buscaAgencia(numAgencia);
                if(agencia == null)
                {
                    return;
                }
                ContaCorrente cc = agencia.getCCorrente(num_conta);
                if(cc == null)
                {
                    return;
                }

                Console.WriteLine("Que operação deseja realizar? ");
                Console.WriteLine("1 - Consultar Saldo:");
                Console.WriteLine("2 - Sacar:");
                Console.WriteLine("3 - Depositar:");
                int operacao = int.Parse(Console.ReadLine());

                if (operacao == 1)
                {
                    Console.WriteLine("Situação da conta:");
                    Console.WriteLine("Conta = " + cc.Id);
                    Console.WriteLine("Titular = " + cc.Titular);
                    Console.WriteLine("Seu saldo é = R$ " + cc.Saldo);
                }
                else if (operacao == 2)
                {
                    Console.WriteLine("Sua operação é SAQUE");
                    Console.WriteLine("Quanto deseja sacar?");
                    cc.Sacar(decimal.Parse(Console.ReadLine()));

                }
                else if (operacao == 3)
                {
                    Console.WriteLine("Sua operação é DEPÓSITO");
                    Console.WriteLine("Quanto deseja depositar: ");
                    cc.Depositar(decimal.Parse(Console.ReadLine()));
                }
            }
            else if (tipo_conta == 2)
            {
                Console.WriteLine("Digite o numero da conta: ");
                int num_conta = int.Parse(Console.ReadLine());
                Agencia agencia = banco.buscaAgencia(numAgencia);
                if (agencia == null)
                {
                    return;
                }
                ContaPoupanca cp = agencia.getCPoupanca(num_conta);
                if (cp == null)
                {
                    return;
                }

                Console.WriteLine("Que operação deseja realizar? ");
                Console.WriteLine("1 - Consultar Saldo:");
                Console.WriteLine("2 - Sacar:");
                Console.WriteLine("3 - Depositar:");
                int operacao = int.Parse(Console.ReadLine());

                if (operacao == 1)
                {
                    Console.WriteLine("Situação da conta:");
                    Console.WriteLine("Conta = " + cp.Id);
                    Console.WriteLine("Titular = " + cp.Titular);
                    Console.WriteLine("Seu saldo é = R$ " + cp.Saldo);
                }
                else if (operacao == 2)
                {
                    Console.WriteLine("Sua operação é SAQUE");
                    Console.WriteLine("Quanto deseja saque: ");
                    cp.Sacar(decimal.Parse(Console.ReadLine()));
                }
                else if (operacao == 3)
                {
                    Console.WriteLine("Sua operação é DEPÓSITO");
                    Console.WriteLine("Quanto deseja depositar: ");
                    cp.Depositar(decimal.Parse(Console.ReadLine()));
                }
            }
        }

        [Key]
        public int IdSolicitacao { get; set; }

    }
}
