using System;
namespace Decoder.Architecture.DomainLayer.Sensor.Measurements.Parameters.SoilMoisture
{
    public class Permittivity : IParameter<double>
    {
        private readonly double measurement;

        #region Constructor:

        public Permittivity(double measurement) =>
            this.measurement = Math.Pow(
                0.000000002887 * Math.Pow(
                    measurement / 10, 3) - 0.0000208 * Math.Pow(
                        measurement / 10, 2) + 0.05276 * (measurement / 10) - 43.39, 2);

        #endregion

        public double Measurement => measurement;
        public string Units => null;
    }
}
