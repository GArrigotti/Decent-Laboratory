namespace Decoder.Architecture.DomainLayer.Sensor.Measurements.Parameters
{
    public class Voltage
    {
        private readonly decimal measurement;
        private readonly string units;

        #region Constructor:

        public Voltage(double measurement, string units)
        {
            this.measurement = (decimal)(measurement / 1000);
            this.units = units;
        }

        #endregion

        public decimal Measurement => measurement;

        public string Units => units;
    }
}
