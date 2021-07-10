using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment.Application.Entities;
using Assessment.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Assessment.Api.Responses;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assessment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly IApplicationUserService _applicationUserService;

        public ApplicationUserController(IApplicationUserService applicationUserService)
        {
            _applicationUserService = applicationUserService;
        }
        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post(ApplicationUser applicationUser)
        {
            await _applicationUserService.RegisterApplicationUser(applicationUser);

            var response = new ApiResponse<ApplicationUser>(applicationUser);
            return Ok(response);
        }

    }
}
