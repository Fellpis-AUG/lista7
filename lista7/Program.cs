using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exercicio;
            Console.WriteLine("=======Menu=======");
            Console.WriteLine("\nExercicio 1");
            Console.WriteLine("Exercicio 2");
            Console.WriteLine("Exercicio 3");
            Console.WriteLine("Exercicio 4");
            Console.WriteLine("Exercicio 5");
            Console.WriteLine("Exercicio 6");
            Console.WriteLine("Exercicio 7");
            exercicio = int.Parse(Console.ReadLine());

            switch (exercicio)
            {


                case 1:
                    int quantidadeTotal = 0;
                    double precoTotal = 0;

                    while (true)
                    {
                        Console.Write("Quantidade de itens adquiridos: ");
                        int quantidade = int.Parse(Console.ReadLine());

                        if (quantidade <= 0)
                        {
                            break;
                        }

                        Console.Write("Preço do produto: ");
                        double preco = double.Parse(Console.ReadLine());

                        quantidadeTotal += quantidade;
                        precoTotal += quantidade * preco;
                    }

                    Console.WriteLine($"Quantidade total de itens adquiridos: {quantidadeTotal}");
                    Console.WriteLine($"Valor total da compra: R${precoTotal:F2}");

                    break;
                case 2:
                    float preco;
                    string nomeI, nomemenor = "", nomemaior = "";
                    int num2, parada = 1;
                    float maior = float.MinValue;
                    float menor = float.MaxValue;

                    while (parada != 2)
                    {
                        Console.WriteLine("qual o nome do produto:");
                        nomeI = Console.ReadLine();

                        Console.WriteLine("qual o valor do produto");
                        preco = float.Parse(Console.ReadLine());

                        Console.WriteLine("quantas produtos voce comprou:");
                        num2 = int.Parse(Console.ReadLine());

                        float tota = num2 * preco;
                        if (tota > maior)
                        {
                            maior = tota;
                            nomemaior = nomeI;
                        }
                        if (tota > menor)
                        {
                            menor = tota;
                            nomemenor = nomeI;
                        }

                        Console.WriteLine("digite 1 para adicionar um novo valor e 2 para parar ");
                        parada = int.Parse(Console.ReadLine());



                    }
                    break;

                case 3:
                    string nome = "";
                    int total = 0, atividade;

                    while (total <= 100)
                    {
                        Console.WriteLine("qual o nome da atividade;");
                        nome = Console.ReadLine();

                        Console.WriteLine("qual o valor da atividade:");
                        atividade = int.Parse(Console.ReadLine());

                        total += atividade;
                    }
                    break;


                case 5:
                    int mes, dia;
                    string estacaoDoAno = "";
                    Console.WriteLine("1 - Janeiro");
                    Console.WriteLine("2 - Fevereiro");
                    Console.WriteLine("3 - Marco");
                    Console.WriteLine("4 - Abril");
                    Console.WriteLine("5 - Maio");
                    Console.WriteLine("6 - Junho");
                    Console.WriteLine("7 - Julho");
                    Console.WriteLine("8 - Agosto");
                    Console.WriteLine("9 - Setembro");
                    Console.WriteLine("10 - Outubro");
                    Console.WriteLine("11 - Novembro");
                    Console.WriteLine("12 - Dezembro");

                    Console.WriteLine("Qual o mes ? ");
                    mes = int.Parse(Console.ReadLine());

                    switch (mes)
                    {
                        case 1:
                            estacaoDoAno = "Verao";
                            break;
                        case 2:
                            estacaoDoAno = "Verao";
                            break;
                        case 3:
                            Console.WriteLine("Informe o dia do mês:");
                            dia = int.Parse(Console.ReadLine());

                            if (dia < 21) estacaoDoAno = "Verao";
                            else estacaoDoAno = "Outono";
                            break;

                        case 4:
                            estacaoDoAno = "Outono";
                            break;
                        case 5:
                            estacaoDoAno = "Outono";
                            break;
                        case 6:
                            Console.WriteLine("Informe o dia do mês:");
                            dia = int.Parse(Console.ReadLine());

                            if (dia >= 21) estacaoDoAno = "Inverno";
                            else estacaoDoAno = "Outono";
                            break;
                        case 7:
                            estacaoDoAno = "Inverno";
                            break;
                        case 8:
                            estacaoDoAno = "Inverno";
                            break;
                        case 9:
                            Console.WriteLine("Informe o dia do mês:");
                            dia = int.Parse(Console.ReadLine());

                            if (dia >= 23) estacaoDoAno = "Primavera";
                            else estacaoDoAno = "Inverno";
                            break;
                        case 10:
                            estacaoDoAno = "Primavera";
                            break;
                        case 11:
                            estacaoDoAno = "Primavera";
                            break;
                        case 12:
                            Console.WriteLine("Informe o dia do mês:");
                            dia = int.Parse(Console.ReadLine());

                            if (dia >= 22) estacaoDoAno = "Verao";
                            else estacaoDoAno = "Primavera";
                            break;
                    }
                    Console.WriteLine("A estacao do ano é {0}", estacaoDoAno);
                    Console.ReadKey();
                    break;

                case 6:
                    int mes, dia;
                    string estacaoDoAno = "";

                    Console.WriteLine("1 - Janeiro");
                    Console.WriteLine("2 - Fevereiro");
                    Console.WriteLine("3 - Marco");
                    Console.WriteLine("4 - Abril");
                    Console.WriteLine("5 - Maio");
                    Console.WriteLine("6 - Junho");
                    Console.WriteLine("7 - Julho");
                    Console.WriteLine("8 - Agosto");
                    Console.WriteLine("9 - Setembro");
                    Console.WriteLine("10 - Outubro");
                    Console.WriteLine("11 - Novembro");
                    Console.WriteLine("12 - Dezembro");

                    Console.WriteLine("Qual o mes ? ");
                    mes = int.Parse(Console.ReadLine());

                    while (mes < 1 || mes > 12)
                    {
                        Console.WriteLine("Mês inválido! Digite novamente:");
                        mes = int.Parse(Console.ReadLine());
                    }

                    switch (mes)
                    {
                        case 1:
                        case 2:
                            estacaoDoAno = "Verao";
                            break;

                        case 3:
                            Console.WriteLine("Informe o dia do mês:");
                            dia = int.Parse(Console.ReadLine());

                            while (dia < 1 || dia > 31)
                            {
                                Console.WriteLine("Dia inválido! Digite novamente:");
                                dia = int.Parse(Console.ReadLine());
                            }

                            if (dia < 21) estacaoDoAno = "Verao";
                            else estacaoDoAno = "Outono";
                            break;

                        case 4:
                        case 5:
                            estacaoDoAno = "Outono";
                            break;

                        case 6:
                            Console.WriteLine("Informe o dia do mês:");
                            dia = int.Parse(Console.ReadLine());

                            while (dia < 1 || dia > 30)
                            {
                                Console.WriteLine("Dia inválido! Digite novamente:");
                                dia = int.Parse(Console.ReadLine());
                            }

                            if (dia >= 21) estacaoDoAno = "Inverno";
                            else estacaoDoAno = "Outono";
                            break;

                        case 7:
                        case 8:
                            estacaoDoAno = "Inverno";
                            break;

                        case 9:
                            Console.WriteLine("Informe o dia do mês:");
                            dia = int.Parse(Console.ReadLine());

                            while (dia < 1 || dia > 30)
                            {
                                Console.WriteLine("Dia inválido! Digite novamente:");
                                dia = int.Parse(Console.ReadLine());
                            }

                            if (dia >= 23) estacaoDoAno = "Primavera";
                            else estacaoDoAno = "Inverno";
                            break;

                        case 10:
                        case 11:
                            estacaoDoAno = "Primavera";
                            break;

                        case 12:
                            Console.WriteLine("Informe o dia do mês:");
                            dia = int.Parse(Console.ReadLine());

                            while (dia < 1 || dia > 31)
                            {
                                Console.WriteLine("Dia inválido! Digite novamente:");
                                dia = int.Parse(Console.ReadLine());
                            }

                            if (dia >= 22) estacaoDoAno = "Verao";
                            else estacaoDoAno = "Primavera";
                            break;

                    }

                    Console.WriteLine("A estacao do ano é ", estacaoDoAno);
                    Console.ReadKey();
                    break;




                case 4:

                    string sigla = "";
                    Console.WriteLine("Digite a sigla do estado que deseja consultar. Digite SAIR para encerrar.");
                    while (sigla != "SAIR")
                    {
                        Console.WriteLine("\nAM");
                        Console.WriteLine("AC");
                        Console.WriteLine("AL");
                        Console.WriteLine("AP");
                        Console.WriteLine("BA");
                        Console.WriteLine("CE");
                        Console.WriteLine("ES");
                        Console.WriteLine("GO");
                        Console.WriteLine("MA");
                        Console.WriteLine("MT");
                        Console.WriteLine("MS");
                        Console.WriteLine("MG");
                        Console.WriteLine("PA");
                        Console.WriteLine("PB");
                        Console.WriteLine("PR");
                        Console.WriteLine("PE");
                        Console.WriteLine("PI");
                        Console.WriteLine("RJ");
                        Console.WriteLine("RN");
                        Console.WriteLine("RS");
                        Console.WriteLine("RO");
                        Console.WriteLine("RR");
                        Console.WriteLine("SC");
                        Console.WriteLine("SE");
                        Console.WriteLine("TO");
                        Console.WriteLine("DF");

                        Console.WriteLine("\nQual a sigla você deseja usar?");
                        sigla = Console.ReadLine();

                        switch (sigla)
                        {
                            case "AM":
                                Console.WriteLine("Amazonas");
                                break;
                            case "AC":
                                Console.WriteLine("Acre");
                                break;
                            case "RR":
                                Console.WriteLine("Roraima");
                                break;
                            case "SC":
                                Console.WriteLine("Santa Catrina");
                                break;
                            case "SE":
                                Console.WriteLine("Sergipe");
                                break;
                            case "TO":
                                Console.WriteLine("Tocantins");
                                break;
                            case "DF":
                                Console.WriteLine("Distrito Federal");
                                break;
                            case "AL":
                                Console.WriteLine("Alagoas");
                                break;
                            case "AP":
                                Console.WriteLine("Amapa");
                                break;
                            case "BA":
                                Console.WriteLine("Bahia");
                                break;
                            case "CE":
                                Console.WriteLine("Ceara");
                                break;
                            case "ES":
                                Console.WriteLine("Espirito Santo ");
                                break;
                            case "GO":
                                Console.WriteLine("Goias");
                                break;
                            case "PB":
                                Console.WriteLine("Paraiba");
                                break;
                            case "PR":
                                Console.WriteLine("Parana");
                                break;
                            case "PE":
                                Console.WriteLine("Pernambuco");
                                break;
                            case "PI":
                                Console.WriteLine("Piaui");
                                break;
                            case "RJ":
                                Console.WriteLine("Rio de Janeiro");
                                break;
                            case "RN":
                                Console.WriteLine("Rio Grande do Norte");
                                break;
                            case "RS":
                                Console.WriteLine("Rio Grande do Sul");
                                break;
                            case "RO":
                                Console.WriteLine("Rondonia");
                                break;
                            case "MA":
                                Console.WriteLine("Maranhao");
                                break;
                            case "MT":
                                Console.WriteLine("Mato Grosso");
                                break;
                            case "MS":
                                Console.WriteLine("Mato Grosso do sul");
                                break;
                            case "MG":
                                Console.WriteLine("Minas Gerais");
                                break;
                            case "PA":
                                Console.WriteLine("Para");
                                break;
                            case "SAIR":
                                Console.WriteLine("Encerrando...");
                                break;


                                break;

                            case 7:
                                int num;
                                Console.WriteLine("Informe um número:");
                                num = int.Parse(Console.ReadLine());

                                if (num <= 0)
                                    Console.WriteLine("O número informado deve ser maior que 0!");

                                string divisores = "";

                                for (int i = 1; i < num + 1; i++)
                                {
                                    if (num % i == 0) divisores += i + " ";
                                }
                                break;

                            default:
                                Console.WriteLine("Exercicio invalido");
                                break;

                        }
                    }

            }
        }
    }
}
