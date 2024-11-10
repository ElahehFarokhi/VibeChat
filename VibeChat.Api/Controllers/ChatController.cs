using Microsoft.AspNetCore.Mvc;
using VibeChat.Api.DTOs;
using VibeChat.Api.Services;

namespace VibeChat.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController(ChatService chatService) : ControllerBase
    {
        private readonly ChatService _chatService = chatService;

        [HttpPost("register-user")]
        public IActionResult RegisterUser(UserDto model)
        {
            if (_chatService.AddUserToList(model.Name))
            {
                return NoContent();
            }
            return BadRequest("This name is taken, please choose another name");
        }
    }
}
