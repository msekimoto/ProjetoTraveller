using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_traveller.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public partial class HoteisController : ControllerBase
    {
        private readonly ILogger<HoteisController> _logger;

        private readonly GulliverContext _gulliverContext;

        public HoteisController(ILogger<HoteisController> logger, GulliverContext gulliverContext)
        {
            _logger = logger;
            _gulliverContext = gulliverContext;
        }

        [HttpGet]
        public IEnumerable<Hotel> GetTodos()
        {
            return _gulliverContext.Hoteis.Include(hotel => hotel.Disponibilidades);
        }

        [HttpGet("PorNome")]
        public IEnumerable<Hotel> GetHotelPorNome(string cidade)
        {
            return _gulliverContext.Hoteis
                .Include(hotel => hotel.Disponibilidades)
                .Where(hotel => hotel.Cidade.ToUpperInvariant().Contains(cidade.ToUpperInvariant()));
        }

        [HttpPost]
        public void PostHotel([FromBody]Hotel hotel)
        {
            _gulliverContext.Hoteis.Add(hotel);
            _gulliverContext.SaveChanges();
        }
    }
}
