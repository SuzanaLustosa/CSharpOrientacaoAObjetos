﻿using bytebank.Contas;
using bytebank.Titular;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;
//Console.WriteLine($" Saldo da conta do André = R${contaDoAndre.saldo}");

//ContaCorrente contaDoAndre2 = new ContaCorrente();
//contaDoAndre2.titular = "André Silva";
//contaDoAndre2.numero_agencia = 15;
//contaDoAndre2.conta = "1010-X";
//contaDoAndre2.saldo = 100;
//Console.WriteLine($" Saldo da conta do André = R${contaDoAndre.saldo}");

//Console.WriteLine(contaDoAndre == contaDoAndre2);

//contaDoAndre.Depositar(100);

//Console.WriteLine($"O saldo da conta do André pós depósito = R${contaDoAndre.saldo}");

//contaDoAndre.Sacar(100);

//Console.WriteLine($"O saldo da conta do André pós saque = R${contaDoAndre.saldo}");

//contaDoAndre.Sacar(200);
//Console.WriteLine($"O saldo da conta do André pós saque = R${contaDoAndre.saldo}");
//contaDoAndre.Sacar(20);
//Console.WriteLine($"O saldo da conta do André pós saque = R${contaDoAndre.saldo}");

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine($"Saldo da conta da Maria = R${contaDaMaria.saldo}");

//contaDoAndre.Transferir(50, contaDaMaria);
//Console.WriteLine($"Saldo da conta do André pós transferência = R${contaDoAndre.saldo}");
//Console.WriteLine($"Saldo da Conta da Maria pós transferência = R${contaDaMaria.saldo}");

//ContaCorrente contaDoPedro = new ContaCorrente();
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.conta);

//double valor = 300;
//double valor2 = valor;

//Console.WriteLine(valor == valor2);

// ContaCorrente conta = new ContaCorrente();

//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_agencia = 15;
//conta.saldo = 200;

//Console.WriteLine($"Titular = {conta.titular.nome}");
//Console.WriteLine($"CPF = {conta.titular.cpf}");
//Console.WriteLine($"Profissão = {conta.titular.profissao}");
//Console.WriteLine($"Nª conta = {conta.conta}");
//Console.WriteLine($"Nª agência = {conta.numero_agencia}");
//Console.WriteLine($"Saldo = {conta.saldo}");

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "987654321";
//conta.conta = "9999-X";
//conta.numero_agencia = 18;
//conta.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_agencia = 18;
//Console.WriteLine(conta3.Numero_agencia);
//conta3.Conta = "1011-H";
//Console.WriteLine(conta3.Conta);
//conta3.SetSaldo(200);
//Console.Write(conta3.GetSaldo());

//ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
//conta4.SetSaldo(500);
//conta4.titular = new Cliente();

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);
//Console.WriteLine(conta4.Conta);

ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);