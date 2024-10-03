
		Random random = new Random(); // gerador automatico
		int numeroSecreto = random.Next(1, 101); // variavel de numeros inteiros
		int palpite = 0; // variavel de numeros inteiros
		int tentativas = 0; // variavel de numeros inteiros
		Console.WriteLine("Tente adivinhar o número entre 1 e 100!"); //impressao de tela
		while (palpite != numeroSecreto) // executa uma instrucao
		{
			Console.Write("Digite seu palpite: ");//impressao de tela
			string entrada = Console.ReadLine(); //e uma cadeia  de caracteres que representa  um tipo de valor 
			if (int.TryParse(entrada, out palpite)) // estrutura de decisoes
			{
				tentativas++;
				if (palpite < numeroSecreto)// e uma estrutura  de decisoes
				{
					Console.WriteLine("Muito baixo! Tente novamente.");//impressao de tela
				}

				if (palpite > numeroSecreto)// e uma estrutura de decisoes
				{
					Console.WriteLine("Muito alto! Tente novamente.");//impressao de tela
				}
				else if (palpite == numeroSecreto)// estrutura de decisoes
				{
					Console.WriteLine($"Parabéns! Você adivinhou em {tentativas} tentativas.");//impressao de tela
				}
			}
			else // estrutura de decisoes
			{
				Console.WriteLine("Por favor, insira um número válido!");//impressao de tela
			}
		}
	