using System;

namespace Decoder.Architecture.DomainLayer.Sensors
{
    public class Sensor<TEntity>
    {
        private readonly Guid id;
        private readonly string payload;

        #region Constructor:

        public Sensor(Guid id, string payload)
        {
            this.id = id;
            this.payload = payload;
        }

        #endregion

        public Guid Id => id;

        public string Payload => payload;

        public DateTime Timestamp => DateTime.Now;

        public int Device { get; set; }

        public TEntity Measurements { get; set; }
    }
}
