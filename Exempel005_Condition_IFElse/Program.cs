﻿Console.WriteLine( "Введите Имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine ("Ура, это де Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine (username);
}