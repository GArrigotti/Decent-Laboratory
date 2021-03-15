using System;
using Decoder.Architecture.DomainLayer.Sensor.Measurements.Parameters;
using Decoder.Architecture.DomainLayer.Sensor.Measurements.Parameters.SoilMoisture;

namespace Decoder.Architecture.DomainLayer.Sensor.Measurements
{
    public class SoilSensor
    {
        public Permittivity Permittivity { get; set; }

        public WaterContent WaterContent { get; set; }

        public Temperature Temperature { get; set; }

        public Voltage Voltage { get; set; }
    }
}
