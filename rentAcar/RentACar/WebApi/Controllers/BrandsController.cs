﻿using Application.Features.Brands.Commands.Create;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add(CreateBrandCommand createBrandCommand)
        {
            var response = await Mediator.Send(createBrandCommand);
            return Ok(response);
        }
    }
}
