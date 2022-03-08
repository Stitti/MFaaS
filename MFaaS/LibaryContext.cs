using MFaaS.Models;
using Newtonsoft.Json;

namespace MFaaS
{
    public class LibaryContext
    {
        private readonly string _QutationsPath = AppDomain.CurrentDomain.BaseDirectory + "Ressources/quotes.json";
        private static LibaryContext _Instance = null;

        public List<Quotation> Quotations { get; private set; }
        
        private LibaryContext()
        {
            string quotationsJson = File.ReadAllText(_QutationsPath);
            if (string.IsNullOrWhiteSpace(quotationsJson))
                Quotations = new List<Quotation>();
            else
                Quotations = JsonConvert.DeserializeObject<List<Quotation>>(quotationsJson);
        }

        public static LibaryContext Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new LibaryContext();
                }
                return _Instance;
            }
        }
    }
}
