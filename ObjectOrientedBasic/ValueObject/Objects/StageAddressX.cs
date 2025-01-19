namespace ValueObject.Objects
{
    public sealed class StageAddressX
    {
        private readonly double _value_um;

        public StageAddressX(double value_um)
        {
            _value_um = value_um;
        }

        public double GetValue_um(int decimalPoint)
        { 
            return Math.Round(_value_um, decimalPoint);
        }

        public double GetValue_mm(int decimalPoint)
        {
            return Math.Round((_value_um/1000), decimalPoint);
        }
    }
}
