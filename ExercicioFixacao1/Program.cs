﻿using System.Globalization;
using System;

string produto1 = "Computador";
string produto2 = "Mesa de escritório";

byte idade = 30;
int codigo = 5290;
char genero = 'M';
double preco1 = 2100.0;
double preco2 = 650.50;
double preco3 = 53.234567;

Console.WriteLine("Produto: ");
Console.WriteLine($"{produto1}, cujo o preço é {preco1}");
Console.WriteLine($"{produto2}, cujo o preço é {preco2}\n");
Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
Console.WriteLine($"Medida com oito casas decimais: {preco3:F8}");
Console.WriteLine($"Arrendondado (três casas decimais): {preco3:F3}");
Console.WriteLine($"Separador decimal invariant culture: {preco3.ToString("F3", CultureInfo.InvariantCulture)}");