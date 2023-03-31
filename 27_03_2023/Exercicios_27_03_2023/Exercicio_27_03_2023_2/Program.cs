// See https://aka.ms/new-console-template for more information
using Exercicio_27_03_2023_2;


Imensagem email = new Email();
Console.WriteLine("Conteudo do email: ");
string mail = Console.ReadLine();
Console.WriteLine("Enviando e-mail...");
string msg = "email que era pra ir com anexo mas foi apenas com a mensagem kkkkk";
email.EnviarMensagem(msg);
Console.WriteLine($"email enviado com sucesso:[ {mail} ]\nObservação: {msg}");


//Console.WriteLine("Enviando e-mail...");