// See https://aka.ms/new-console-template for more information

using DES;


string message = "George";

Algorithm algorithm =  new Algorithm();
string de = algorithm.DesEncrypt("12345678", message);

string ma = algorithm.DesDecrypt("12345678", de);

Console.WriteLine($"Mensaje Encriptado: {de}");
Console.WriteLine($"Mensaje desencriptado: {ma}");