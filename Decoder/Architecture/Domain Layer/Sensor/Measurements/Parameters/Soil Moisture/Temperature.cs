using System;
namespace Decoder.Architecture.DomainLayer.Sensor.Measurements.Parameters.SoilMoisture
{
    public class Temperature : IParameter<double>
    {
        private readonly double measurement;
        private readonly string units;

        #region Constructor:

        public Temperature(double measurement, string units)
        {
            this.measurement = ((measurement - 32768) / 10);
            this.units = units;
        }

        #endregion

        public double Measurement => measurement;

        public string Units => units;
    }
}
