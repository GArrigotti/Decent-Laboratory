using System;
using System.Collections.Generic;
using Decoder.Architecture.ServiceLayer;
using Newtonsoft.Json;

namespace Decoder
{
    public class Startup
    {
        private static readonly IList<string> payloads;

        #region Constructor:

        static Startup() => payloads = new List<string>()
        {
            "0214e3000370c580540c01",
            "0214e3000370ac80550c04",
            "0214e3000370a780570c01",
            "0214e3000370bb80580bff",
            "0214e3000370c380590bff",
            "0214e3000370b1805a0bff",
            "0214e2000301f400000bd3"
        };

        #endregion

        public static void Main()
        {
            foreach(var payload in payloads)
            {
                var sensor = new DecoderService().Decode(payload);
                var json = JsonConvert.SerializeObject(sensor);

                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine(json);
                Console.WriteLine("---------------------------------------------------------------------");
            }

            Console.WriteLine("Completed decoding...");
        }
    }
}
