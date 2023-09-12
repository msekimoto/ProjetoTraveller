using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace api_traveller.Controllers
{
    public partial class HoteisController
    {
        public class Disponibilidade
        {
            public int Id { get; set; }
            public DateTime Data { get; set; }
            public decimal Preco { get; set; }

            [JsonIgnore]
            public virtual Hotel Hotel { get; set; }
        }
    }
}
