static void calcular(float pValor1, float pValor2, TipoExpresao expresao)
{
    float Valor1 = 0;
    float Valor2 = 0;
    int Exprecao = 0;
    System.Console.WriteLine("Informe os valores:");

    System.Console.WriteLine("Primeiro valor:");
    Valor1 = float.Parse(Console.ReadLine());

    System.Console.WriteLine("Segundo valor:");
    Valor2 = float.Parse(Console.ReadLine());

    System.Console.WriteLine("Informe a Expresao, 0 - Somar, 1 - Subtrair, 2 - Multiplicar, 3 - Dividir");
    Exprecao = int.Parse(Console.ReadLine());

    calculaValor(Valor1, Valor2, (TipoExpresao)Exprecao);
    System.Console.ReadLine();


    float valor = 0;
    switch (expresao)
    {
        case TipoExpresao.Somar:
            valor = pValor1 + pValor2;
            break;

        case TipoExpresao.Subitrair:
            valor = pValor1 - pValor2;
            break;

        case TipoExpressao.Multiplicar:
            valor = pValor1 * pValor2;
            break;

        case TipoExpresao.Dividir:
            valor = pValor1 / pValor2:
            break;
    }
     System.Console.WriteLine("Resultado :" + valor);
        

}


   