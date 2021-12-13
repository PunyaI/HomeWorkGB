namespace HomeWorkGB.Core.Geometry
{
    public sealed class Circle : Point
    {
        private double _radius;

        public Circle():base() { }
        public Circle(Status status, ConsoleColor color, int x, int y, double radius):base(status, color, x, y) => Radius = radius;
        public double Radius 
        { 
            get { return _radius; } 
            set
            {
                if (value <= 0)
                {
                    log.ShowMessage("Ошибка! Радиус не может быть равен или меньше нуля.");
                    _radius = -1;
                    return;
                }
                _radius = value; 
            } 
        }


        public override double GetArea()=> Math.PI * (Radius * Radius);
        public override void GetInfo()
        {
            Console.WriteLine();
            log.ShowMessage("   Информация о круге");
            log.ShowMessage($"Цвет - {Color}");
            log.ShowMessage($"Статус - {Status}");
            log.ShowMessage($"Координаты центра- {X}, {Y}");
            log.ShowMessage($"Радиус - {Radius}");
            log.ShowMessage($"Площадь - {GetArea()}");
            Console.WriteLine();
        }
    }
}
