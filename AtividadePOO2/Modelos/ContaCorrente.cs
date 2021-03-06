﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Atividade1
{
    public class ContaCorrente { 

     public const decimal Taxa = 0.10M;
    public string titular = string.Empty;

    public ContaCorrente()
    {

    }

    public ContaCorrente(string t)
    {
        this.titular = t;
    }

    [Key]
    public int Id
    {
        get; set;
    }

    public void Depositar(decimal valor)
    {
        decimal desconto = valor * Taxa;
        Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        decimal desconto = valor * Taxa;

        if (valor <= Saldo)
        {
            Saldo -= valor;
        }
    }

    public decimal Saldo { get; set; }

    public string Titular
    {
        get { return titular; }
        set { titular = value; }
    }



}
}
