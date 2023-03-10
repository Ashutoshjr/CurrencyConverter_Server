namespace CurrencyConverter_Server
{
    public class CurrencyManager
    {

        private readonly DollerConverter _converter;

        public CurrencyManager()
        {

          _converter = new DollerConverter();
        }



        public string ConvertCurrency(string currency)
        {

            try
            {
                string finalResult = string.Empty;

                if (currency.Contains(','))
                {
                    string[] data = currency.Split(',');
                    string doller = data[0];
                    string cent = data[1];

                    var resultdoller = _converter.ConvertToDollar(Convert.ToInt32(doller));
                    var resultcent = _converter.ConvertToCent(Convert.ToInt32(cent));

                    finalResult = $" {resultdoller} dollars and {resultcent} cent";
                }
                else
                {
                    var resultdoller = _converter.ConvertToDollar(Convert.ToInt32(currency));
                    finalResult = $" {resultdoller} dollars";
                }


                return finalResult;

            }
            catch (Exception ex)
            {

                throw;
            }


        }

    }
}
