﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Atividade1
{
    public class Agencia
    {

        List<ContaCorrente> contas_corrente = new List<ContaCorrente>();
        List<ContaPoupanca> contas_poupanca = new List<ContaPoupanca>();
        List<Solicitacao> solicitacoes = new List<Solicitacao>();

        public void AdicionarContaCorrente(ContaCorrente cc)
        {
            contas_corrente.Add(cc);
            Console.WriteLine("Conta ----------> \n" + "Numero: "  + cc.Id + "\n" + "Titular: " + cc.Titular + "\n" + "Conta Criada, Boa sorte\n");
        }

        public void AdicionarContaPoupanca(ContaPoupanca cp)
        {
            contas_poupanca.Add(cp);
            Console.WriteLine("Conta:\n" + "Numero: " + cp.Id + "\n" + "Titular: " + cp.Titular + "\n" + "Conta Criada, Boa sorte\n");
        }

        public ContaCorrente getCCorrente(int num)
        {
            ContaCorrente cc = null;
            foreach (var conta in contas_corrente)
            {
                if (conta.Id == num)
                {
                    cc = conta;
                    return cc;
                }
            }

            Console.WriteLine("Dados invalidos, verifique se todos os dados estão corretos ou se sua sua conta existe.");
            return null;



        }
        public ContaPoupanca getCPoupanca(int num)
        {
            ContaPoupanca cp = null;
            foreach (var conta in contas_poupanca)
            {
                if (conta.Id == num)
                {
                    cp = conta;
                    return cp;
                }
            }
            Console.WriteLine("Dados invalidos, verifique se todos os dados estão corretos ou se sua sua conta existe.");
            return null;

        }

        [Key]
        public int IdAgencia { get; set; }

        public List<ContaCorrente> ContaCorrentes { get; set; }
        public List<ContaPoupanca> ContaPoupancas { get; set; }
        public List<Solicitacao> Solicitacoes { get; set; }

    }
}
