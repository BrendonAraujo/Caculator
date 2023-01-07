namespace Calculator;

class Program
{
	static void Main(string[] args)
	{
		ChamaMenu();
	}

	static void ChamaMenu(){

		Console.Clear();
		Console.WriteLine("Select what do You want to do");
		Console.WriteLine("1 - Sum");
		Console.WriteLine("2 - Substration");
		Console.WriteLine("3 - Multiplacaton");
		Console.WriteLine("4 - Division");
		Console.WriteLine("5 - Exit");
		Console.WriteLine("[----------------------------]"+Environment.NewLine);

		int option = Convert.ToInt32(Console.ReadLine());
		switch (option)
		{
			case 1: Soma();
				break;
			case 2: Subtracao();
				break;
			case 3: Multiplicacao();
				break;
			case 4: Divisao();
				break;
			case 5: Environment.Exit(0); break;;
			default: ChamaMenu();
				break;
		}	
	}
	static void Soma()
	{
		Console.Clear();
		Console.WriteLine("First Value");
		float primeiroValor = float.Parse(Console.ReadLine()??"0");

		Console.WriteLine("Segundo valor");
		float segundoValor = float.Parse(Console.ReadLine()??"0");

		float soma = primeiroValor + segundoValor;

		Console.WriteLine("");
		Console.WriteLine($"O valor da soma é {soma}");   
		Console.ReadKey();
		ChamaMenu();
	}
	static void Subtracao()
	{
		Console.Clear();
		Console.WriteLine("First Value");
		float primeiroValor = float.Parse(Console.ReadLine()??"0");

		Console.WriteLine("Segundo valor");
		float segundoValor = float.Parse(Console.ReadLine()??"0");

		float substracao = primeiroValor - segundoValor;

		Console.WriteLine("");
		Console.WriteLine($"O valor da subtracao é {substracao}");
		Console.ReadKey();
		ChamaMenu();   
	}
	static void Divisao()
	{
		Console.Clear();
		Console.WriteLine("First Value");
		float primeiroValor = float.Parse(Console.ReadLine()??"0");

		Console.WriteLine("Segundo valor");
		float segundoValor = float.Parse(Console.ReadLine()??"0");

		float divisao = primeiroValor / segundoValor;

		Console.WriteLine("");
		Console.WriteLine($"O valor da divisao é {divisao}");
		Console.ReadKey();   
		ChamaMenu();
	}
	static void Multiplicacao()
	{
		Console.Clear();
		Console.WriteLine("First Value");
		float primeiroValor = float.Parse(Console.ReadLine()??"0");

		Console.WriteLine("Segundo valor");
		float segundoValor = float.Parse(Console.ReadLine()??"0");

		float multiplicacao = primeiroValor * segundoValor;

		Console.WriteLine("");
		Console.WriteLine($"O valor da multiplicacao é {multiplicacao}");
		Console.ReadKey();   
		ChamaMenu();
	}


}