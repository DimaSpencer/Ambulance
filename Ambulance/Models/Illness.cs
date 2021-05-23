using System;

namespace Ambulance
{
    [Serializable]
    public class Illness
    {
        /// <summary>
        /// Час в секундах
        /// </summary>
        public int HealingTime { get; set; }
        public string Name { get; set; }
        public Priorities Priority { get; set; }
        
        public Illness() { }
        public Illness(string name, Priorities priority, int healingTime)
        {
            Name = name;
            Priority = priority;
            HealingTime = healingTime;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
