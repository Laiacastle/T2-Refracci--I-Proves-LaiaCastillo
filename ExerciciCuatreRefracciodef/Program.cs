using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        //Constant afegides
        const string MsgAmp = "Introdueix l'amplada del rectangle:",
            MsgAlt = "Introdueix l'altura del rectangle:",
            MsgArea = "L'àrea del rectangle és: {0} ",
            MsgRadi = "Introdueix el radi del cercle:",
            MsgCircum = "La circumferència del cercle és: {0}",
            MsgGran = "L'àrea és més gran de 50",
            MsgMig = "L'àrea és entre 20 i 50",
            MsgPetit = "L'àrea és menor o igual a 20";

        //variables afegides
        double width, height, radius, area, circumference;

        // Sol·licita l'entrada de l'usuari per calcular l'àrea d'un rectangle
        Console.WriteLine(MsgAmp);
        width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(MsgAlt);
        height = Convert.ToDouble(Console.ReadLine());

        // Calcula l'àrea
        area = width * height;
        Console.WriteLine(MsgArea, area);

        // Sol·licita l'entrada de l'usuari per calcular la circumferència d'un cercle
        Console.WriteLine(MsgRadi);
        radius = Convert.ToDouble(Console.ReadLine());
        circumference = 2 * Math.PI * radius;

        Console.WriteLine(MsgCircum, circumference);

        // Imprimeix un missatge basat en el valor de l'àrea
        if (area > 50)
        {
            Console.WriteLine(MsgGran);
        }
        else if (area > 20)
        {
            Console.WriteLine(MsgMig);
        }
        else
        {
            Console.WriteLine(MsgPetit);
        }
    }
}