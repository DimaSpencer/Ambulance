using System.ComponentModel;

namespace Ambulance
{
    public static class BaseObjectsInitializer
    {
        private static BindingList<Illness> _diseases;
        private static BindingList<Brigade> _brigades;

        public static BindingList<Illness> GetDefaultDiseases()
        {
            if (_diseases == null)
                return _diseases = new BindingList<Illness>()
                {
                    new Illness(name: "Covid-19", Priorities.High, healingTime: 35),
                    new Illness(name: "Перелом", Priorities.High, healingTime: 15),
                    new Illness(name: "Грип", Priorities.High, healingTime: 40),

                    new Illness(name: "Опік", Priorities.Low, healingTime: 10),
                    new Illness(name: "Простуда", Priorities.Low, healingTime: 5),
                };
            else
                return _diseases;
        }

        public static BindingList<Brigade> GetDefaultBrigades()
        {
            if (_brigades == null)
                return _brigades = new BindingList<Brigade>()
                {
                    new HighQualityBrigade { Id = 1, Status = Status.Free },
                    new HighQualityBrigade { Id = 2, Status = Status.Free },
                    new HighQualityBrigade { Id = 3, Status = Status.Free },

                    new LowQualityBrigade { Id = 4, Status = Status.Free },
                    new LowQualityBrigade { Id = 5, Status = Status.Free },
                    new LowQualityBrigade { Id = 6, Status = Status.Free }
                };
            else
                return _brigades;
        }
    }
}
