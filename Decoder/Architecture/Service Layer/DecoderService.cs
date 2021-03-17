using System;
using System.IO;
using System.Reflection;
using Decoder.Architecture.DomainLayer.Sensor.Measurements;
using Decoder.Architecture.DomainLayer.Sensor.Measurements.Parameters;
using Decoder.Architecture.DomainLayer.Sensor.Measurements.Parameters.SoilMoisture;
using Decoder.Architecture.DomainLayer.Sensor.Measurements.Parameters.WaterLevel;
using Decoder.Architecture.DomainLayer.Sensors;

namespace Decoder.Architecture.ServiceLayer
{
    public class DecoderService
    {
        public Sensor<dynamic> Decode(string payload)
        {
            var values = new byte[payload.Length / 2];
            for (int index = 0, iterator = 0; index < payload.Length; index += 2, iterator++)
                values[iterator] = (byte)int.Parse(payload.Substring(index, 2), System.Globalization.NumberStyles.HexNumber);

            var stream = new MemoryStream(values);
            int version = stream.ReadByte();
            int device = Read(stream);
            int flags = Read(stream);

            switch(device)
            {
                case 5346:
                    PropertyInfo[] properties = typeof(LevelSensor).GetProperties();
                        if((flags & 1) == 1)
                        {
                            var parameters = new double[properties.Length];
                            for (var index = 0; index < properties.Length; index++)
                                parameters[index] = Read(stream);

                        var sensor = new Sensor<dynamic>(Guid.NewGuid(), payload)
                        {
                            Device = device,
                            Measurements = new LevelSensor()
                            {
                                Distance = new Distance(parameters[0], "mm"),
                                Samples = new Samples((int)parameters[1]),
                                Voltage = new Voltage(parameters[2], "V")
                            }
                        };

                        return sensor;
                    }

                    break;

                case 5347:
                    properties = typeof(SoilSensor).GetProperties();
                    if ((flags & 1) == 1)
                    {
                        var parameters = new double[properties.Length];
                        for (var index = 0; index < properties.Length; index++)
                            parameters[index] = Read(stream);

                        var sensor = new Sensor<dynamic>(new Guid(), payload)
                        {
                            Device = device,
                            Measurements = new SoilSensor()
                            {
                                Permittivity = new Permittivity(parameters[0]),
                                WaterContent = new WaterContent(parameters[0], "m³⋅m⁻³"),
                                Temperature = new Temperature(parameters[1], "°C"),
                                Voltage = new Voltage(parameters[2], "V")
                            }
                        };

                        return sensor;
                    }
                    
                    break;

                default:
                    break;
            }

            return null;
        }

        #region Private:

        private static int Read(Stream stream) => (stream.ReadByte() << 8) + stream.ReadByte();

        #endregion
    }
}
