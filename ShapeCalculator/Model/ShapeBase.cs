namespace ConsoleApp1.Model
{
    abstract class ShapeBase
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }

        public abstract double GetPerimeter();

        public abstract double GetSquare();
    }
}
