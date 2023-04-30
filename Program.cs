   //Declaração de variáveis
    double dividendo, divisor, quociente;

    Console.WriteLine("------- Divisão -------");

    Console.WriteLine("Digite o dividendo: ");
    dividendo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o divisor: ");
    divisor = Convert.ToDouble(Console.ReadLine());

    //Uso do bool (true or false)
    bool isInvalid = divisor == 0;

    //Condicional if (Se) e else (senao)
    if(isInvalid)
    {
        Console.WriteLine("Não é possível dividir por zero. ");
    }

    else
    {
        //Estes comandos só deve ser executados quando o divisor não for zero
        quociente = dividendo / divisor;
        Console.WriteLine($"A divisão de {dividendo:N1} por {divisor:N1} é {quociente:N1}.");
    
    }
    
    Console.WriteLine("Obrigado!");