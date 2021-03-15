using System;
using Decoder.Architecture.DomainLayer.Sensor.Measurements.Parameters;
using Decoder.Architecture.DomainLayer.Sensor.Measurements.Parameters.WaterLevel;

namespace Decoder.Architecture.DomainLayer.Sensor.Measurements
{
    public class LevelSensor
    {
        public Distance Distance { get; set; }

        public Samples Samples { get; set; }

        public Voltage Voltage { get; set; }
    }
}
