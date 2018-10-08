using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
  
   Muista kommentoida toiminnalliset funktiot!

   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx

    1. Luokassa Hevonen ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Hevonen -luokasta olio
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5.Tulosta olion tiedot nyt näytölle.
  
   
**/
namespace Hevonen
{
    class Program
    {
        static void Main(string[] args)
        {
            Hevonen Hevoinen = new Hevonen();
            Console.WriteLine("Hevosen nimi on " + Hevoinen.nimi + " Ja se painaa " + Hevoinen.paino + " kiloa");
            Console.WriteLine("Anna hepalle uusi nimi");
            Hevoinen.nimi = Console.ReadLine();
            Console.WriteLine("Hepan uusi paino on");
            Hevoinen.paino = int.Parse(Console.ReadLine());
            Console.WriteLine("Hevosen uusi nimi on " + Hevoinen.nimi + " Ja se painaa " + Hevoinen.paino + " kiloa");
            Console.ReadKey();
        }
    }
}