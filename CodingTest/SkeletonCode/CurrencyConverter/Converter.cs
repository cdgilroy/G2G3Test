namespace SkeletonCode.CurrencyConverter
{
	public class Converter
	{
		public decimal Convert(string inputCurrency, string outputCurrency, decimal amount)
		{
			// Validate input
			if (inputCurrency != "GBP" && inputCurrency != "USD")
			{
				throw new System.ArgumentException("Invalid input currency code!");
			}

			if (outputCurrency != "GBP" && outputCurrency != "USD")
			{
				throw new System.ArgumentException("Invalid output currency code!");
			}

			// Case 1: GBP to USD
			if (inputCurrency == "GBP" && outputCurrency == "USD")
			{
				amount *= (decimal)1.25;
			}

			// Case 2: USD to GBP
			if (inputCurrency == "USD" && outputCurrency == "GBP")
			{
				amount *= (decimal)0.8;
			}

			return amount;
		}
	}
}
