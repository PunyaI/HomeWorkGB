
using System.Collections;

namespace HomeWorkGB.Core
{
    public sealed class Сreator
    {
        private static Hashtable _buildings = new Hashtable();
        public static Hashtable Buildings { get { return _buildings; } }

        private Сreator() {}      


        public static Building CreateBuild()
        {
            Building building = new Building()
            {
                High = 0,
                Floor = 0,
                Apartments = 0,
                Entrances = 0,
             };
            _buildings.Add(building.Number, building);
            return building;
        }
        public static Building CreateBuild(float high, uint floor, uint apartments, uint entrances)
        {
            Building building = new Building()
            {
                High = high,
                Floor = floor,
                Apartments = apartments,
                Entrances = entrances,
            };
            _buildings.Add(building.Number, building);
            return building;
        }
        public static void DeleteBuild(int number)
        {
            if (_buildings.ContainsKey(number))
            {
                Building.ClearBuild(number);
                _buildings.Remove(number);
            }    
            
        }
    }
}
