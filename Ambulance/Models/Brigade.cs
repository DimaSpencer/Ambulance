using System;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ambulance
{
    [XmlInclude(typeof(HighQualityBrigade))]
    [XmlInclude(typeof(LowQualityBrigade))]
    [XmlInclude(typeof(Patient))]
    [Serializable]
    public abstract class Brigade
    {
        public int Id { get; set; }

        public abstract Specializations Specialization { get; set; }
        public Status Status { get; set; }

        public Patient Patient { get; set; }
        public int RecoveredPatients { get; set; } = 0;
        public abstract double AverageDrivingSpeed { get; set; }

        public abstract Task HealAsync();
        public abstract Task GoToPatientAsync(Patient patient);

        public Brigade() {}
        public Brigade(int id)
        {
            Id = id;
        }
    }
}
