namespace Decoder.Architecture.DomainLayer.Sensor.Measurements.Parameters
{
    public interface IParameter<TType>
    {
        public TType Measurement { get; }

        public string Units { get; }
    }
}
