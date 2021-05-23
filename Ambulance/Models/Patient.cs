using System;

namespace Ambulance
{
    [Serializable]
    public class Patient
    {
        public string CallTime { get; set; }
        public string FullName { get; set; }
        public double Distance { get; set; }
        public Illness Illness { get; set; }
        public Priorities Priority { get => Illness.Priority; }

        public Patient()
        {
            CallTime = DateTime.Now.ToString("dd/MM H:mm:ss");
        }

        public override string ToString()
        {
            return $"{FullName}";
        }
    }
}
