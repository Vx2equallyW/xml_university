namespace ClassesLib
{
    public class MathematicPendulum
    {
        protected double a { get; set; }

        protected double b { get; set; }

        protected int m { get; set; }

        public double X(int t)
        {
            return this.a * Math.Cos( ((2.0 * Math.PI) / CalculateT()) * (double)t + (double)0 );
        }
        public double CalculateT()
        {
            return 2.0 * Math.PI * Math.Sqrt(b / 9.8);
        }
        public string ToString()
        {
            return string.Format(
                "Амплитуда колебаний: {0}\n" +
                "Длина нерастяжимой нити: {1}\n" +
                "Масса маятника: {2}.",
                this.a, this.b, this.m
                );
        }
    }
}
