
namespace HomeWorkGB.Core
{
    public sealed class Building
    {
        private static int _lastNumber = 0;

        private readonly Logger _logger = new ConsoleLogger();
        private int _number;
        private float _high;
        private uint _floor;
        private uint _apartments;
        private uint _entrances;

        internal Building()
        {
            _lastNumber++;
            _number = _lastNumber;
        }



        public int Number
        {
            get
            {
                return _number;
            }
        }
        public float High
        {
            get
            {
                return _high;
            }
            set
            {
                if (value < 0)
                {
                    _logger.ShowMessage("Ошибка ввода!Высота здания не может быть меньше 0 метров");
                }
                else
                {
                    _high = value;
                }
            }
        }
        public uint Floor { get { return _floor; } set { _floor = value; } }
        public uint Apartments { get { return _apartments; } set { _apartments = value; } }
        public uint Entrances { get { return _entrances; } set { _entrances = value; } }

        public float GetFloorHigh()
        {
            float res = 0;
            if (Floor != 0)
            {
                res = High / Floor;
                _logger.ShowMessage($"В этом доме высота этажа -  {res:f0} метра(-ов).");
            }
            else
            {
                _logger.ShowMessage("Ошибка! Не указано количество этажей в этом доме!");
            }
            return res;
        }
        public uint GetApartmentsPerEntrances()
        {
            uint res = 0;
            if (Entrances > 0)
            {
                res = Apartments / Entrances;
                _logger.ShowMessage($"В этом доме {res} квартир(ы) в каждом подъезде.");
            }
            else
            {
                _logger.ShowMessage("Ошибка! Не указано количество подъездов в этом доме!");
            }
            return res;
        }
        public uint GetApartmentsPerFloor()
        {
            uint res = 0;
            if (Floor == 0 )
            {
                _logger.ShowMessage("Ошибка! Не указано количество этажей в этом доме!");
            }
            else if (Entrances == 0)
            {
                _logger.ShowMessage("Ошибка! Не указано количество подъездов в этом доме!");
            }
            else
            {
                res = Apartments / Entrances / Floor;
                _logger.ShowMessage($"В этом доме {res} квартир(ы) на каждом этаже.");
            }
            return res;
        }

        internal static void ClearBuild(int number)
        {
            Building build = (Building)Сreator.Buildings[number];
            build._number = 0;
            build._apartments = 0;
            build._entrances = 0;
            build._floor = 0;
            build._high = 0;
        }
        public void Info()
        {
            _logger.ShowMessage($"");
            _logger.ShowMessage($"    Паспорт дома № {Number}");
            _logger.ShowMessage($"Высота               - {High:f0} метров");
            _logger.ShowMessage($"Количество этажей    - {Floor}");
            _logger.ShowMessage($"Количество квартир   - {Apartments}");
            _logger.ShowMessage($"Количество подъездов - {Entrances}");
            _logger.ShowMessage($"");
        }
    }
}
