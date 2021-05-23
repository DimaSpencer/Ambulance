using System.ComponentModel;

namespace Ambulance
{
    public static class ListOfDiseases
    {
        private static BindingList<Illness> _diseases;
        public static BindingList<Illness> GetAll()
        {
            if (_diseases != null)
                return _diseases;

            _diseases = new BindingList<Illness>()
            {
                new Illness(name: "Covid-19", Priorities.High, healingTime: 35),
                new Illness(name: "Перелом", Priorities.High, healingTime: 15),
                new Illness(name: "Грип", Priorities.High, healingTime: 40),
                new Illness(name: "Опік", Priorities.Low, healingTime: 10),
                new Illness(name: "Простуда", Priorities.Low, healingTime: 5),
            };

            return _diseases;
        }
    }
}
