using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSL_Geocoder
{
    class Program
    {
        static void Main(string[] args)
        {
            /* connect to db. make sure to use 'using' to automatically dispose of connections */

            /* check for entries younger than limit */

            /* pull entries and create parsable file (xml or json) */

            /* geocode addresses
             * think about letting user choose type of coder in config file
             * all coders implement Geocoder interface */
            Geocoder geo = new MapQuestGeocoder();

            /* load coded addresses into db */

            System.Console.WriteLine("Geocoding bitch!!");
            System.Console.ReadLine();
        }
    }
}
