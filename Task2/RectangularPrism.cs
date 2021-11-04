namespace Task2
{
    public class RectangularPrism : Rectangle
    {
        protected int Height { get; set; }
        protected int Volume { get; set; }
        public RectangularPrism(int height, int edgeA, int edgeB) : base(edgeA, edgeB)
        {
            Height = height;
            GetSquare();
        }

        protected override void GetSquare()
        {
            Square = (EdgeA * Height) + 2 * (EdgeA * EdgeB) + 2 * (EdgeB * Height);
            Volume = EdgeA * EdgeB * Height;
        }

        public override string OutputToString()
        {
            return $"{EdgeA} и {EdgeB} и {Height} Площадь: {Square}  Объём: {Volume}";
        }

        public override string ToString()
        {
            return $"{EdgeA} и {EdgeB} и {Height} Площадь: {Square}  Объём: {Volume}";
        }
    }
}
