using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSL_Geocoder
{
    class GeocoderFactory
    {
        public Geocoder getGeocoder(String type)
        {
            //just add new types as needed
            switch (type)
            {
                case "MapQuestGeocoder":
                    return new MapQuestGeocoder();
                case "GoogleMapsGeocoder":
                    return new GoogleMapsGeocoder();
                default:
                    /* print to log file that we defaulted
                     * or maybe just crash if that would be better */
                    return new MapQuestGeocoder();
            }
        }
    }
}
