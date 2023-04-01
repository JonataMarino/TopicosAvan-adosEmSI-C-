// See https://aka.ms/new-console-template for more information
using Exercicio_27_03_2023_2;


Imensagem email = new Email();
Console.WriteLine("Conteudo do email: ");
string mail = Console.ReadLine();
Console.WriteLine("Enviando e-mail...");
string msg = "email com marcação de anexo enviado como apenas texto kkkkk";
email.EnviarMensagem(msg);

Imensagem sms = new Sms();
Console.WriteLine("Enviar SMS: ");
string msgn = Console.ReadLine();
sms.EnviarMensagem(msgn);


Console.WriteLine($"email enviado com sucesso:[ {mail} ]\nObservação: {msg}");
Console.WriteLine($"SMS enviado com sucesso:[ {msgn} ]");


//Console.WriteLine("Enviando e-mail...");