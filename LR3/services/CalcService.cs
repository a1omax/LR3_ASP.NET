namespace ASP.NET.services
{
    public class CalcService: interfaces.ICalcService
    {
      
        public Double Add(Double value1, Double value2)
        {
            return value1+ value2;
        }
        public Double Subtract(Double value1, Double value2)
        {
            return value1 - value2;
        }
        public Double Multiply(Double value1, Double value2)
        {
            return value1 * value2;
        }
        public Double Divide(Double value1, Double value2)
        {
            return value1 / value2;
        }

    }
}

