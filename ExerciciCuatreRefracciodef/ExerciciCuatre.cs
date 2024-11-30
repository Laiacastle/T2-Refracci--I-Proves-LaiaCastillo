using System;
using RefraccioUtils;
//posat el names sapace, cambiat el nbombre de l-arxiu i la clasde i posat el class library
namespace RefraccioExerciciCuatre
{

    class ExerciciCuatre
    {
    
        static void Main(string[] args)
        {

            const string MsgAmp = "Introdueix l'amplada del rectangle:",
                MsgAlt = "Introdueix l'altura del rectangle:",
                MsgArea = "L'àrea del rectangle és: {0} ",
                MsgRadi = "Introdueix el radi del cercle:",
                MsgCircum = "La circumferència del cercle és: {0}",
                MsgGran = "L'àrea és més gran de 50",
                MsgMig = "L'àrea és entre 20 i 50",
                MsgPetit = "L'àrea és menor o igual a 20",
                MsgError = "Error de format";

       
            double width, height, radius, area;

            // calcular area

            Console.WriteLine(MsgAmp);
            try
            {
                do {
                    width = Convert.ToDouble(Console.ReadLine());
                } while(!Utils.GraterThanZero(width));

                Console.WriteLine(MsgAlt);
                do
                {
                    height = Convert.ToDouble(Console.ReadLine());
                }while(!Utils.GraterThanZero(height));
                

                area  = Utils.CalculateArea(width, height);
                Console.WriteLine(MsgArea, area);

                // calcula la circumferencia d'un cercle
                Console.WriteLine(MsgRadi);
                do
                {
                    radius = Convert.ToDouble(Console.ReadLine());
                }while(!Utils.GraterThanZero(radius));
                
        
                Console.WriteLine(MsgCircum, Utils.CalculateCircum(radius));

                // Imprimeix basat en el valor de l'àrea

                Console.WriteLine(area > 50 ? MsgGran : area > 20 ? MsgMig : MsgPetit);
            }
            catch (FormatException)
            {
                Console.WriteLine(MsgError);
            }
        }
    }
}