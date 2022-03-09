using MFaaS.Shared.Models;
using Newtonsoft.Json;
using System.Web;

namespace MFaaS.Server
{
    public class LibaryContext
    {
        private readonly string _QutationsPath = AppDomain.CurrentDomain.BaseDirectory + "Resources/quotes.json";
        private readonly string _ActorsPath = AppDomain.CurrentDomain.BaseDirectory + "Resources/actors.json";
        private static LibaryContext _Instance = null;

        public List<Quotation> Quotations { get; private set; }
        public List<Actor> Actors { get; private set; }
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

        private LibaryContext()
        {
            string quotationsJson = File.ReadAllText(_QutationsPath);
            if (string.IsNullOrWhiteSpace(quotationsJson))
                Quotations = new List<Quotation>();
            else
                Quotations = JsonConvert.DeserializeObject<List<Quotation>>(quotationsJson);

            string actorsJson = File.ReadAllText(_ActorsPath);
            if (string.IsNullOrWhiteSpace(actorsJson))
                Actors = new List<Actor>();
            else
                Actors = JsonConvert.DeserializeObject<List<Actor>>(actorsJson);
        }
    }
}
