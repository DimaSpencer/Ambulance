using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Ambulance
{

    public static class PatientsGenerator
    {
        public static int MinValue { get; set; } = 15;
        public static int MaxValue { get; set; } = 30;

        private static readonly BindingList<Illness> _diseases = ListOfDiseases.GetAll();

        public static Patient Generate()
        {
            int endIndexOfFirstNames = Enum.GetNames(typeof(FirstNames)).Length - 1;
            int endIndexOfLastNames = Enum.GetNames(typeof(FirstNames)).Length - 1;

            var firstNameGenerator = new Random();
            var lastNameGenerator = new Random();

            string firstName = Enum.GetName(typeof(FirstNames), firstNameGenerator.Next(0, endIndexOfFirstNames));
            string lastName = Enum.GetName(typeof(LastNames), lastNameGenerator.Next(0, endIndexOfLastNames));

            return new Patient()
            {
                FullName = $"{lastName} {firstName}",
                Illness = GenerateIllness(),
                Distance = new Random().Next(5, 50),
            };
        }

        private static Illness GenerateIllness()
        {
            Random random = new Random();
            int randomValue = random.Next(0, _diseases.Count - 1);
            return _diseases[randomValue];
        }

        public static int GetRandomTime()
        {
            return new Random().Next(MinValue, MaxValue);
        }
    }
}
