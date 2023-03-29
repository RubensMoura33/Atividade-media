Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine(@$"
||------------------------------||
|| P R O G R A M A   P A R A    ||
|| C A L C U L A R   M E D I A  ||
||------------------------------||
");

Console.ResetColor();

Console.WriteLine($"Digite o nome do Aluno: ");
string nome = Console.ReadLine();

Console.WriteLine($"Bem vindo ao nosso sistema {nome} ;");

Console.WriteLine($"Informe a Nota 1 do aluno: ");
float Nota1  = float.Parse(Console.ReadLine()) ;

Console.WriteLine($"Informe a Nota 2 do aluno: ");
float Nota2  = float.Parse(Console.ReadLine()) ;

Console.WriteLine($"Informe a Nota 3 do aluno: ");
float Nota3  = float.Parse(Console.ReadLine()) ;

Console.WriteLine($"Informe a Nota 4 do aluno: ");
float Nota4  = float.Parse(Console.ReadLine()) ;

Console.WriteLine($"Informe a Nota 5 do aluno: ");
float Nota5  = float.Parse(Console.ReadLine()) ;

float media = ((Nota1 + Nota2 + Nota3 + Nota4 + Nota5) / 5);

Console.WriteLine($"A média do aluno(a) {nome} é igual a : {media}");
