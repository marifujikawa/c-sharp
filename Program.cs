using System;

namespace C_
{
    public class PairNumbers
    {
        private string[] _args;

        public int a { get; set; }
        public int b { get; set; }

        public PairNumbers(string[] args)
        {
            this._args = args;
            Parse();
        }

        public void Parse()
        {
            a = int.Parse(_args[0]);
            b = int.Parse(_args[1]);
        }

    }
    class Program
    {
        //o main só chama. Ele não vai ter métodos e funções extras. vai só chamar mesmo 
        static void Main(string[] args)
        {

            Boolean returnHelloWorld = HelloWorld(args);
            //Write printa o conteúdo e não quebra linha.
            //caso queira quebrar linha, colocar "\n"
            //concatenar string é com o "+"
            Console.Write("Hello");
            Console.Write("World\n");

            PairNumbers pairNumbers = new PairNumbers(args);


            int resultSoma = Soma(pairNumbers);
            Console.WriteLine(resultSoma);

            int resultSubtract = Subtract(args[0], args[1]);
            Console.WriteLine(resultSubtract);

            int resultMutiply = Multiply(args[0], args[1]);
            Console.WriteLine(resultMutiply);

            float resultDivide = Divide(args[0], args[1]);
            Console.WriteLine(resultDivide);

        }

        private static int Soma(PairNumbers pairNumbers)
        {
            return (pairNumbers.a + pairNumbers.b);
        }

        private static int Subtract(int c, int d)
        {
            return (c - d);

        }

        private static int Subtract(string c, string d)
        {
            int c1 = int.Parse(c);
            int d1 = int.Parse(d);
            return Subtract(c1, d1);
        }

        private static int Multiply(int e, int f)
        {
            return (e * f);
        }

        private static int Multiply(string e, string f)
        {
            int e1 = int.Parse(e);
            int f1 = int.Parse(f);
            return Multiply(e1, f1);
        }

        private static float Divide(int g, int h)
        {
            return ((float)g / (float)h);
        }
        private static float Divide(string g, string h)
        {
            int g1 = int.Parse(g);
            int h1 = int.Parse(h);
            return Divide(g1, h1);
        }






        private static Boolean HelloWorld(string[] args)
        {
            //quando colocamos o argumento, passamos o argumento na hora do dotnet build. e.g.: dotnet build hello world. hello é o argumento 0 e o world o argumento 1

            if (args.Length < 2)
            {
                Console.WriteLine("não foram encontrados argumentos necessários para a execução do programa");
                return false;
            }
            string arg1 = args[0];
            string arg2 = args[1];

            //Writeline printa o conteúdo e quebra linha
            //o $"{...}{...}", concatena strings.
            Console.WriteLine($"{arg1} {arg2}");
            return true;
        }
    }
}
