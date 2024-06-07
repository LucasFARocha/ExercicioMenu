using System;

namespace menu2
{
    class Program
    {
        static void Main()
        {
            int resp;
            do
            {
                Console.Clear();
                Console.Write("\n** Menu Principal **");
                Console.Write("\n====================");
                Console.Write("\n[1] Consulta dia/mês");
                Console.Write("\n[2] Consulta sigla/estado");
                Console.Write("\n[3] Extenso de um número");
                Console.Write("\n[4] Fatorial");
                Console.Write("\n[5] Cálculo específico");
                Console.Write("\n[6] Fim");
                Console.Write("\n====================");
                Console.Write("\nEscolha a opção desejada: ");

                resp = Convert.ToInt16(Console.ReadLine());

                switch (resp)
                {
                    case 1:
                        {
                            Diames();
                            break;
                        }
                    case 2:
                        {
                            Siglaestado();
                            break;
                        }
                    case 3:
                        {
                            Extenso();
                            break;
                        }
                    case 4:
                        {
                            Fatorial();
                            break;
                        }
                    case 5:
                        {
                            Calcula1();
                            break;
                        }
                    case 6:
                        {
                            Console.Write("Fim do programa\n");
                            break;
                        }
                    default:
                        {
                            Console.Write("Opção inválida");
                            break;
                        }
                }
            } while (resp != 6);
        }

        static void Traco(String traco, int max)
        {
            for (int i = 0; i < max; i++)
            {
                Console.Write(traco);
            }
        }

        static void Diames()
        {
            string resp;
            do
            {
                Console.Clear();
                Console.Write("\nHoje é " + DateTime.Now.ToLongDateString() + "\n");

                Traco("-", 100);

                Console.Write("\nDeseja repetir o processo?(s/n): ");
                resp = Console.ReadLine();

            } while (resp == "sim" || resp == "s");
        }

        static void Siglaestado()
        {
            string[,] estado = new string[27, 2];
            string texto, resp;
            bool achou;

            estado[0, 0] = "AC"; estado[0, 1] = "Acre";

            estado[1, 0] = "AL"; estado[1, 1] = "Alagoas";

            estado[2, 0] = "AP"; estado[2, 1] = "Amapá";

            estado[3, 0] = "AM"; estado[3, 1] = "Amazonas";

            estado[4, 0] = "BA"; estado[4, 1] = "Bahia";

            estado[5, 0] = "CE"; estado[5, 1] = "Ceará";

            estado[6, 0] = "DF"; estado[6, 1] = "Distrito Federal";

            estado[7, 0] = "ES"; estado[7, 1] = "Espírito Santo";

            estado[8, 0] = "GO"; estado[8, 1] = "Goiás";

            estado[9, 0] = "MA"; estado[9, 1] = "Maranhão";

            estado[10, 0] = "MT"; estado[10, 1] = "Mato Grosso";

            estado[11, 0] = "MS"; estado[11, 1] = "Mato Grosso do Sul";

            estado[12, 0] = "MG"; estado[12, 1] = "Minas Gerais";

            estado[13, 0] = "PA"; estado[13, 1] = "Pará";

            estado[14, 0] = "PB"; estado[14, 1] = "Paraíba";

            estado[15, 0] = "PR"; estado[15, 1] = "Paraná";

            estado[16, 0] = "PE"; estado[16, 1] = "Pernambuco";

            estado[17, 0] = "PI"; estado[17, 1] = "Piauí";

            estado[18, 0] = "RJ"; estado[18, 1] = "Rio de Janeiro";

            estado[19, 0] = "RN"; estado[19, 1] = "Rio Grande do Norte";

            estado[20, 0] = "RS"; estado[20, 1] = "Rio Grande do Sul";

            estado[21, 0] = "RO"; estado[21, 1] = "Rondônia";

            estado[22, 0] = "RR"; estado[22, 1] = "Roraima";

            estado[23, 0] = "SC"; estado[23, 1] = "Santa Catarina";

            estado[24, 0] = "SP"; estado[24, 1] = "São Paulo";

            estado[25, 0] = "SE"; estado[25, 1] = "Sergipe";

            estado[26, 0] = "TO"; estado[26, 1] = "Tocantins";

            do
            {
                Console.Clear();
                Console.Write("\n*** Pesquisando Estados ***");

                Console.Write("\n===========================\n");


                Console.Write("\nInforme uma sigla ou um estado: ");

                texto = Console.ReadLine();


                achou = false;

                for (int i = 0; i < 27; i++)
                {

                    if (texto == estado[i, 0])
                    {
                        Console.Write("\n" + texto + " corresponde a " + estado[i, 1] + "\n");


                        achou = true;


                        break;
                    }
                    else if (texto == estado[i, 1])
                    {
                        Console.Write("\n" + texto + " corresponde a " + estado[i, 0] + "\n");


                        achou = true;


                        break;
                    }
                }
                if (achou == false)
                {
                    Console.Write("\n\nSigla ou estado não cadastrado\n");


                }

                Traco("-", 100);

                Console.Write("\nDeseja continuar?(s/n): ");

                resp = Console.ReadLine();

            } while (resp == "sim" || resp == "s");
        }

        static void Extenso()
        {
            string[] unidade = { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze", "quartorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            string[] dezena = { "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
            string[] centena = { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };
            string resp;
            int na, nd, ne, nn;

            do
            {
                Console.Clear();

                Console.Write("\nDigite um número de 0 a 1000: ");
                na = Convert.ToInt16(Console.ReadLine());


                if (na < 0 || na > 1000)
                {
                    Console.Write("\n\nNúmero fora da faixa");

                }
                else if (na == 100)
                {
                    Console.Write("\n\nA forma extensa desse número é: cem");

                }
                else if (na < 20)
                {
                    Console.Write("\n\nA forma extensa desse número é: " + unidade[na]);

                }
                else if (na == 1000)
                {
                    Console.Write("\n\nA forma extensa desse número é: mil");

                }
                else if (na < 100)
                {
                    ne = na / 10;

                    nd = na % 10;

                    Console.Write("\n\nA forma extensa desse número é: " + dezena[ne]);


                    if (nd > 0)
                    {
                        Console.Write(" e " + unidade[nd]);

                    }
                }
                else if (na > 100 & na < 1000)
                {
                    ne = na / 100;

                    nn = na % 100;

                    Console.Write("\n\nA forma extensa desse número é: " + centena[ne]);


                    if (nn > 0 & nn <= 19)
                    {
                        Console.Write(" e " + unidade[nn]);

                    }
                    else if (nn >= 20)
                    {

                        int ee = nn % 10;

                        Console.Write(" e " + dezena[nn / 10]);


                        if (ee != 0)
                        {
                            Console.Write(" e " + unidade[ee]);

                        }
                    }
                }

                Console.Write("\n");

                Traco("-", 100);

                Console.Write("\n\nDeseja continuar?(s/n): ");

                resp = Console.ReadLine();
            }
            while (resp == "s" || resp == "sim");

        }

        static void Fatorial()
        {
            string resp;

            do
            {
                Console.Clear();
                int x, f = 1;


                do
                {
                    Console.Write("\nDigite um valor maior que zero: ");

                    x = Convert.ToInt16(Console.ReadLine());

                }
                while (x < 1);


                while (x > 0)
                {
                    f = f * x;


                    x--;

                }
                Console.Write("\nFatorial = " + f);

                Console.Write("\n");
                Traco("-", 100);

                Console.Write("\nDeseja continuar?(s/n): ");

                resp = Console.ReadLine();
            }
            while (resp == "s" || resp == "sim");

        }

        static void Calcula1()
        {
            string resp;

            do
            {
                Console.Clear();


                Traco("-", 100);
                Console.Write("\nBem Vindo!\n");
                Traco("-", 100);
                Console.Write("\nO primeiro cálculo será 3 x 3 + 4 x 4\n");
                Console.Write("\nO segundo cálculo será 7 x 7 + 2 x 2\n");
                Traco("-", 100);


                Console.Write("\nO resultado do primeiro cálculo é: " + Calcula(3.0, 4.0) + "\n");
                Console.Write("\nO resultado do segundo cálculo é: " + Calcula(7.0, 2.0) + "\n");

                Traco("-", 100);
                Console.Write("\n!!!Tchau!!!\n");
                Traco("-", 100);

                Console.Write("\nDeseja continuar?(s/n): ");

                resp = Console.ReadLine();
            } while (resp == "s" || resp == "sim");

        }

        static Double Calcula(double a, double b)
        {
            double resultado;
            resultado = a * b + a * b;
            return resultado;
        }
    }
}
