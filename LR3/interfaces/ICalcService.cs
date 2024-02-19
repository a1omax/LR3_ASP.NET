namespace ASP.NET.interfaces
{
	public interface ICalcService
	{
		public Double Add(Double value1, Double value2);
        public Double Subtract(Double value1, Double value2);
        public Double Multiply(Double value1, Double value2);
        public Double Divide(Double value1, Double value2);
    }
}