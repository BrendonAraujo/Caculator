namespace Calculator;

class Program
{
	static void Main(string[] args)
	{
		// Soma();
		//Subtracao();
		// Divisao();
		Multiplicacao();
	}

	static void Soma()
	{
		Console.Clear();
		Console.WriteLine("Primeiro Valor");
		float primeiroValor = float.Parse(Console.ReadLine()??"0");

		Console.WriteLine("Segundo valor");
		float segundoValor = float.Parse(Console.ReadLine()??"0");

		float soma = primeiroValor + segundoValor;

		Console.WriteLine("");
		Console.WriteLine($"O valor da soma é {soma}");   
		Console.ReadKey();
	}
	
	static void Subtracao()
	{
		Console.Clear();
		Console.WriteLine("Primeiro Valor");
		float primeiroValor = float.Parse(Console.ReadLine()??"0");

		Console.WriteLine("Segundo valor");
		float segundoValor = float.Parse(Console.ReadLine()??"0");

		float substracao = primeiroValor - segundoValor;

		Console.WriteLine("");
		Console.WriteLine($"O valor da subtracao é {substracao}");
		Console.ReadKey();   
	}
	static void Divisao()
	{
		Console.Clear();
		Console.WriteLine("Primeiro Valor");
		float primeiroValor = float.Parse(Console.ReadLine()??"0");

		Console.WriteLine("Segundo valor");
		float segundoValor = float.Parse(Console.ReadLine()??"0");

		float divisao = primeiroValor / segundoValor;

		Console.WriteLine("");
		Console.WriteLine($"O valor da divisao é {divisao}");
		Console.ReadKey();   
	}
	static void Multiplicacao()
	{
		Console.Clear();
		Console.WriteLine("Primeiro Valor");
		float primeiroValor = float.Parse(Console.ReadLine()??"0");

		Console.WriteLine("Segundo valor");
		float segundoValor = float.Parse(Console.ReadLine()??"0");

		float multiplicacao = primeiroValor * segundoValor;

		Console.WriteLine("");
		Console.WriteLine($"O valor da multiplicacao é {multiplicacao}");
		Console.ReadKey();   
	}


}