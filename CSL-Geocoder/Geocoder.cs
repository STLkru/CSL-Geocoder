using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSL_Geocoder
{
    public interface Geocoder
    {
        //json is recommended in both cases and has smaller overhead
        String codeAsJSON(string inputJSON);

        IEnumerable<String> codeAsBatchJSON(IEnumerable<string> inputBatch); 
    }
}
