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
            "0214e2000301f400000be1",
            "0214e3000357ce80c30bf7",
            "0214e2000301f400000bee",
            "0214e3000357b880c30bf7",
            "0214e2000301f400000bee",
            "0214e3000357ba80c20bf7",
            "0214e2000301f400000bee",
            "0214e3000357dc80c20bf7",
            "0214e2000301f400000bee",
            "0214e3000357c080c20bf7"
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
