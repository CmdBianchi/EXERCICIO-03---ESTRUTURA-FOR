using System;
namespace EXERCICIO_03___ESTRUTURA_FOR{
   class Program{
        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Msg();
            Conditional();
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg(){
            Console.WriteLine("Exercício 03 - estrutura repetitiva FOR - Lista de exercícios.");
        }
        //------------------------------------------------------------------------------------------//
        static void Conditional(){
            int n = int.Parse(Console.ReadLine()); //----> Números de casos

            for ( int i = 0; i < n; i++) {
                string[] line = Console.ReadLine().Split(' '); //----> Digitar lateralmente com espaço os valores | Cria um ARRAY de POSIÇOES "N"
                double a = double.Parse(line[0]); double b = double.Parse(line[1]); double c = double.Parse(line[2]);
                Double media = ((a * 2.0 + b * 3.0 + c * 5) / 10.0);

                Console.WriteLine(media.ToString("F1"));
            }

            
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }
}
