using ApiManagmement.Model;
using ApiManagmement.Service.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ApiManagmement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController: ControllerBase
    {
        private readonly ITodoService _todoService;
        public TodoController(ITodoService service) {
            _todoService = service;
        }

        [HttpGet("Todo")]
        public string TodoAction(string todo)
        {
           string response = _todoService.Todoasfd(todo);
          return response;
        }

        [HttpPost("login")]
        public string Login(LoginModel loginModel)
        {
            if(loginModel.Username == "admin" && loginModel.Password == "admin")
            {
                return "Successfully logged in";
            }
            return "login failed";
        }

    }
}
