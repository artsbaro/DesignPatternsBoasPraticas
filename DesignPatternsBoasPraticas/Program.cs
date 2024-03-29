﻿// See https://aka.ms/new-console-template for more information
using DesignPatternsBoasPraticas;
using Flurl.Http;
using System.Text.Json;

//Console.WriteLine("Strategy");
//Imposto iss = new ISS();
//Imposto icms = new ICMS();

//Orcamento orcamento = new Orcamento(500.0);
//CalculadorDeImpostos calculador = new CalculadorDeImpostos();
//calculador.RealizaCalculo(orcamento, iss);
//calculador.RealizaCalculo(orcamento, icms);

var response = "https://viacep.com.br/ws/01001000/json/"
    .GetAsync()
    .GetAwaiter()
    .GetResult();

var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};
var endereco = JsonSerializer.Deserialize<Endereco>(response.GetStreamAsync().Result, options);

Console.WriteLine(endereco.ToString());

Console.WriteLine("Chain of Respons.");
CalculadorDeDescontos calculador = new CalculadorDeDescontos();
Orcamento orcamento = new Orcamento(500.0);
orcamento.AdicionaItem(new Item("Caneta", 250));
orcamento.AdicionaItem(new Item("Lapis", 250));
orcamento.AdicionaItem(new Item("Borracha", 250));
orcamento.AdicionaItem(new Item("Lapis de cor", 250));
orcamento.AdicionaItem(new Item("Lapizeira", 250));
orcamento.AdicionaItem(new Item("Livros", 250));

double desconto = calculador.Calcula(orcamento);
Console.WriteLine(desconto);
Console.ReadKey();

