namespace HomeWorkGB.Core
{
    public abstract class Logger
    {
        public abstract void ShowMessage(string message);
    }
    public sealed class ConsoleLogger : Logger
    {
        public override void ShowMessage(string message)
        {
            if (message != "")
            System.Console.Write(System.DateTime.Now + "  ");
            System.Console.WriteLine(message);
        }
    }
}