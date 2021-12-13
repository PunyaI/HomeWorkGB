namespace HomeWorkGB.Core.Geometry
{
    public sealed class Rectangle : Point
    {
        private double _width;
        private double _height;

        public Rectangle() :base() { }

        public Rectangle(Status status, ConsoleColor color, int x, int y, double width, double height) : base(status, color, x, y)
        {
            Width = width;
            Height = height;
        }
        public double Width 
        { 
            get { return _width; } 
            set 
            { 
                if (value <= 0)
                {
                    log.ShowMessage("Ошибка! Ширина не может быть равна или меньше нуля.");
                    return;
                }
                _width = value;
            } 
        }
        public double Height 
        { 
            get { return _height; } 
            set 
            {
                if (value <= 0)
                {
                    log.ShowMessage("Ошибка! Высота не может быть равна или меньше нуля.");
                    return;
                }
                _height = value; 
            } 
        }



        public override double GetArea()=>(Width*Height);
        public override void GetInfo()
        {
            Console.WriteLine();
            log.ShowMessage("   Информация о прямоугольнике");
            log.ShowMessage($"Цвет - {Color}");
            log.ShowMessage($"Статус - {Status}");
            log.ShowMessage($"Координаты центра- {X}, {Y}");
            log.ShowMessage($"Ширина - {Width}, высота - {Height}");
            log.ShowMessage($"Площадь - {GetArea()}");
            Console.WriteLine();
        }
    }
}
