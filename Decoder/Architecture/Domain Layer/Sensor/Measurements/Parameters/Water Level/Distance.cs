namespace Decoder.Architecture.DomainLayer.Sensor.Measurements.Parameters.WaterLevel
{
    public class Distance : IParameter<decimal>
    {
        private readonly decimal measurement;
        private readonly string units;

        #region Constructor:

        public Distance(double measurement, string units)
        {
            this.measurement = (decimal)measurement;
            this.units = units;
        }

        #endregion

        public decimal Measurement => measurement;

        public string Units => units;
    }
}
