using System;
using System.Collections.Generic;
using System.Configuration;
using Newtonsoft.Json;

namespace CSL_Geocoder
{
    class Program
    {
        static void Main(string[] args)
        {
            /* connect to db. make sure to use 'using' to automatically dispose of connections */

            /* check for entries younger than limit */

            /* pull entries as userinfo objects and create json */
            List<string> testJson = new List<string>(){"stuff", "morestuff", "holyshitmorestuff"};

            /* geocode addresses
             * let user choose type of coder in config file
             * we could actually use more than one geocoder if we need
             * all coders implement Geocoder interface */
            GeocoderFactory factory = new GeocoderFactory();
            String coderType = ConfigurationManager.AppSettings["GeocoderType"];
            Geocoder geo = factory.getGeocoder(coderType);

            List<string> codedAddresses = geo.codeAsBatchJSON(testJson);

            /* load coded addresses into db */

            System.Console.WriteLine("Geocoding bitch!!");
            System.Console.ReadLine();
        }
    }
}
