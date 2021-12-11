namespace HomeWorkGB.Core.Geometry
{
    public class Point : Figure
    {
        private int _x;
        private int _y;


        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }


        public Point() : this(Status.Невидимый, ConsoleColor.White, 0, 0) { }
        public Point(Status status, ConsoleColor color, int x, int y)
        {
            Status = status;
            Color = color;
            X = x;
            Y = y;  
        }


        public override double GetArea() => 0;
        public override void MoveGorizont(int value) => X += value;

        public override void MoveVertical(int value) => Y += value;

        public override void GetInfo()
        {
            Console.WriteLine();
            log.ShowMessage("   Информация о точке");
            log.ShowMessage($"Цвет - {Color}");
            log.ShowMessage($"Статус - {Status}");
            log.ShowMessage($"Координаты центра- {X}, {Y}");
            Console.WriteLine();
        }
    }
}
