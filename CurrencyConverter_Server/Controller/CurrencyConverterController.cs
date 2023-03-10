using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter_Server.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class CurrencyConverterController : ControllerBase
    {

        private readonly CurrencyManager _currencyManager;
        public CurrencyConverterController()
        {
            _currencyManager = new CurrencyManager();
        }

        [HttpGet]
        public string ConvertCurrency(string currency)
        {
            return  _currencyManager.ConvertCurrency(currency);
        }

    }
}
