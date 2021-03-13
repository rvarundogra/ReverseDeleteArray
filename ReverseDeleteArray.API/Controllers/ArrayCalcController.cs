using ReverseDeleteArray.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReverseDeleteArray.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrayCalcController : ControllerBase
    {
        private readonly IProductService _productService;

        public ArrayCalcController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("reverse")]
        public IActionResult Reverse([FromQuery] int[] productIds)
        {
            return Ok(_productService.Reverse(productIds));
        }

        [HttpGet("deletepart")]
        public IActionResult DeletePart(int position, [FromQuery] int[] productIds)
        {
            return Ok(_productService.DeletePart(position, productIds));
        }
    }
}
