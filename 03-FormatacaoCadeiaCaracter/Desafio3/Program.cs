﻿/*Comece a resolver o desafio com as duas linhas de código a seguir.

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\
u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

A variável projectName será usada duas vezes na saída desejada.

A variável russianMessage contém a mensagem "Exibir saída russa" em russo. Você precisa 
usar essa variável em seu código que imprime a mensagem.

Você não pode alterar essas duas linhas de código, mas pode adicionar código acima e 
abaixo de cada linha. Você precisa usar essas duas linhas de código para formar a saída desejada.

Para concluir esse desafio, você só pode criar duas instruções que realmente imprimem a saída no console.*/


string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");
            
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");