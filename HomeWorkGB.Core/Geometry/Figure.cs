namespace HomeWorkGB.Core.Geometry
{
    public enum Status
    {
        Видимый,
        Невидимый
    }
    public abstract class Figure
    {
        internal Logger log = new ConsoleLogger();
        private ConsoleColor _color;
        private Status _status;


        public Status Status { get { return _status; } set { _status = value; } }
        public ConsoleColor Color { get { return _color; } set { _color = value; }}


        public abstract void MoveGorizont(int value);
        public abstract void MoveVertical(int value);
        public abstract double GetArea();
        public abstract void GetInfo();

    }
}
