namespace Calculator;

class Program
{
	static void Main(string[] args)
	{
		// Soma();
		Subtracao();
	}

	static void Soma()
	{
		Console.Clear();
		Console.WriteLine("Primeiro Valor");
		float primeiroValor = float.Parse(Console.ReadLine());

		Console.WriteLine("Segundo valor");
		float segundoValor = float.Parse(Console.ReadLine());

		float soma = primeiroValor + segundoValor;

		Console.WriteLine("");
		Console.WriteLine($"O valor da soma é {soma}");   
		Console.ReadKey();
	}
	
	static void Subtracao()
	{
		Console.Clear();
		Console.WriteLine("Primeiro Valor");
		float primeiroValor = float.Parse(Console.ReadLine());

		Console.WriteLine("Segundo valor");
		float segundoValor = float.Parse(Console.ReadLine());

		float soma = primeiroValor - segundoValor;

		Console.WriteLine("");
		Console.WriteLine($"O valor da subtracao é {soma}");
		Console.ReadKey();   
	}


}