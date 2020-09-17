using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeOrganizerAPI.Model;
using Infrastructure.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HomeOrganizerAPI.Controllers
{
    [ApiController]
    [Route("v1/ShopProducts")]
    public class ShopProductController : ControllerBase
    {

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<ShopProduct>>> Get([FromServices] DataContext context)
        {
            var shopProducts = await context.ShopProducts.ToListAsync();
            return shopProducts;
        }
    }
}
