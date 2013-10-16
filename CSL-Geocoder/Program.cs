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
            var testJson = new List<string>(){"stuff", "morestuff", "holyshitmorestuff"};

            /* geocode addresses
             * let user choose type of coder in config file
             * we could actually use more than one geocoder if we need
             * all coders implement Geocoder interface */
            GeocoderFactory factory = new GeocoderFactory();
            String coderType = ConfigurationManager.AppSettings["GeocoderType"];
            Geocoder geo = factory.getGeocoder(coderType);

            /* Jake, I checked it out and you were definitely right that we should use var here
             * since all we care about is that this is object is enumerable. Everywhere I looked said
             * that it was just a short cut for the dev so that he doesn't have to specify the type and perform Linq queries.
             * Apparently it's substituted at compile time for the correct type and has absolutely no
             * impact on performace though so we don't need to worry one way or the other if we are trying to speed things up. */
            var codedAddresses = geo.codeAsBatchJSON(testJson);

            /* load coded addresses into db */

            System.Console.WriteLine("Geocoding bitch!!");
            System.Console.ReadLine();
        }
    }
}
