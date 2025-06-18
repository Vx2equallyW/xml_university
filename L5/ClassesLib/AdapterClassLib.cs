namespace ClassesLib
{
    public class AdapterClassPendulum : MathematicPendulum
    {
        public AdapterClassPendulum(double amplitude, double stringLength, int pendulumMass)
        {
            a = amplitude < 0.0 ? 0.0 : amplitude;
            b = stringLength < 0.0 ? 0.0 : stringLength;
            m = pendulumMass < 0 ? 0 : pendulumMass;
        }

        public void ModifMass(int dm)
        {
            m = dm < 0 ? 0 : dm;
        }
        public double CalculateW()
        {
            return (2.0 * Math.PI) / CalculateT();
        }
        public string GetData()
        {
            return ToString();
        }
    }
}
