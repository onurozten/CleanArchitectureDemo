using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Commands.Delete;
using Application.Features.Brands.Commands.Update;
using Application.Features.Brands.Queries.GetById;
using Application.Features.Brands.Queries.GetList;
using Core.Applcation.Requests;
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

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery]PageRequest pageRequest)
        {
            var query = new GetListBrandQuery() { PageRequest = pageRequest};
            var response = await Mediator!.Send(query);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetByIdBrandQuery() { Id = id };
            var response = await Mediator!.Send(query);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateBrandCommand updateBrandCommand)
        {
            var command = new UpdateBrandCommand() { Id = updateBrandCommand.Id, Name = updateBrandCommand.Name };
            var response = await Mediator!.Send(command);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteBrandCommand deleteBrandCommand)
        {
            var command = new DeleteBrandCommand() { Id = deleteBrandCommand.Id };
            var response = await Mediator!.Send(command);
            return Ok(response);
        }
    }
}
