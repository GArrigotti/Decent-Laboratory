using System;
namespace Decoder.Architecture.DomainLayer.Sensor.Measurements.Parameters.WaterLevel
{
    public class Samples : IParameter<int>
    {
        private readonly int measurement;

        #region Constructor:

        public Samples(int measurement) => this.measurement = measurement;

        #endregion

        public int Measurement => measurement;

        public string Units => String.Empty;
    }
}
