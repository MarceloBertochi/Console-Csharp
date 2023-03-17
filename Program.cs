// See https://aka.ms/new-console-template for more information

// comentários não são C#
//Console.BackgroundColor = ConsoleColor.White; // coloca uma cor de fundo na tela
Console.ForegroundColor = ConsoleColor.Blue; // coloca uma cor na letra

Console.Clear();  //limpa a tela

Console.CursorVisible = true; // true abilita o cursor e fase desabilita

Console.WriteLine("1");
Thread.Sleep(500); // dá um tempo de uma linha a outra
Console.WriteLine("2");
Thread.Sleep(500);
Console.WriteLine("3");
Thread.Sleep(500);
Console.WriteLine("4");
Thread.Sleep(500);
Console.WriteLine("5");

Console.ResetColor();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("G");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("o");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("o");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("G");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("l");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("e");

Console.WriteLine();

Console.Write("Pressione uma tecla para continuar...");
Console.ReadKey();
Console.WriteLine()
;Console.WriteLine("Muito bem , tudo funcionando");