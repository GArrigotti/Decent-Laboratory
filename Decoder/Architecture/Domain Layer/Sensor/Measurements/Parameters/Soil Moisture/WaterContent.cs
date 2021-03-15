using System;
namespace Decoder.Architecture.DomainLayer.Sensor.Measurements.Parameters.SoilMoisture
{
    public class WaterContent : IParameter<decimal>
    {
        private readonly decimal measurement;
        private readonly string units;

        #region Constructor:

        public WaterContent(double measurement, string units)
        {
            this.measurement = (decimal)(measurement / 10 * 0.0003879 - 0.6956);
            this.units = units;
        }

        #endregion

        public decimal Measurement => measurement;

        public string Units => units;
    }
}
