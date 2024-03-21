using freelance.Auth.Models.DTO;
using freelance.Auth.service.Iservice;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace freelance.Auth.Controllers
{

    [Route("api/Auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        public readonly IAuthservice _autoService;
        public readonly ResponseDto _response;
        public AuthAPIController(IAuthservice autoService)
        {
            _autoService = autoService;
            _response = new();
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationReqiuestDto model)
        {
            var errorMessage = await _autoService.Register(model);
            if (errorMessage.User == null)
            {
                _response.IsSuccess = false;
                _response.Message = "username or passwor incorrect";
                return BadRequest(_response);
            }
            _response.Result = errorMessage;
            return Ok(_response.Result);
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto model)
        {
            var loginresponse = await _autoService.Login(model);
                if (loginresponse.User == null)
            {
                _response.IsSuccess = false;
                _response.Message = "username or passwor incorrect";
                return BadRequest(_response);
            }
                _response.Result = loginresponse;
                 return Ok(_response.Result);
        }

        [HttpPost("AssignRole")]
        public async Task<IActionResult> AssignRole([FromBody] RegistrationReqiuestDto model)
        {
            var assignrole = await _autoService.AssignRole(model.Email, model.Role.ToUpper());
            if (!assignrole)
            {
                _response.IsSuccess = false;
                _response.Message = "error encountered";
                return BadRequest(_response);
            }
            return Ok(_response);
        }

    }
}
