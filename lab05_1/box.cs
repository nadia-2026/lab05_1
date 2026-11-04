namespace lab05_1
{
    internal class Box
    {
        private double l;
        private double w;
        private double h;

        public double L
        {
            get { return l; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Длина должна быть больше 0.");
                l = value;
            }
        }

        public double W
        {
            get { return w; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ширина должна быть больше 0.");
                w = value;
            }
        }

        public double H
        {
            get { return h; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Высота должна быть больше 0.");
                h = value;
            }
        }
        public Box(double l, double w, double h)
        {
            L = l;
            W = w;
            H = h;
        }

        public double Volume()
        {
            return L * W * H;
        }

        public bool IsFit(double v)
        {
            return v <= Volume();
        }

        public void PrintBox()
        {
            Console.WriteLine($"Коробка: длина = {L}, ширина = {W}, высота = {H}");
            Console.WriteLine($"Объём: {Volume()}");
        }
    }
}