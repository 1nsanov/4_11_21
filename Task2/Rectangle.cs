namespace Task2
{
    public class Rectangle
    {
        protected int EdgeA { get; set; }
        protected int EdgeB { get; set; }
        protected int Square { get; set; }

        public Rectangle(int edgeA, int edgeB)
        {
            EdgeA = edgeA;
            EdgeB = edgeB;
            GetSquare();
        }

        protected virtual void GetSquare()
        {
            Square = EdgeA * EdgeB;
        }

        public virtual string OutputToString()
        {
            return $"{EdgeA} и {EdgeB} Площадь: {Square}";
        }

        public override string ToString()
        {
            return $"{EdgeA} и {EdgeB} Площадь: {Square}";
        }
    }
}
