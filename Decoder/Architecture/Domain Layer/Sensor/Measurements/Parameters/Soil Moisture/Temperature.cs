using System;
namespace Decoder.Architecture.DomainLayer.Sensor.Measurements.Parameters.SoilMoisture
{
    public class Temperature : IParameter<decimal>
    {
        private readonly decimal measurement;
        private readonly string units;

        #region Constructor:

        public Temperature(double measurement, string units)
        {
            this.measurement = (decimal)((measurement - 32768) / 10);
            this.units = units;
        }

        #endregion

        public decimal Measurement => measurement;

        public string Units => units;
    }
}
