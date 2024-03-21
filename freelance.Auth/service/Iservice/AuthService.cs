using freelance.Auth.Data;
using freelance.Auth.Models;
using freelance.Auth.Models.DTO;
using Microsoft.AspNetCore.Identity;

namespace freelance.Auth.service.Iservice
{
    public class AuthService : IAuthservice
    {
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<ApplicationUser> _usermanager;
        private readonly RoleManager<IdentityRole> _rolemanager;
        private readonly Itest _test;
        public AuthService(AppDbContext appDbContext, UserManager<ApplicationUser> usermanager, RoleManager<IdentityRole> rolemanager, Itest test)
        {
            _appDbContext = appDbContext;
            _usermanager = usermanager;
            _rolemanager = rolemanager;
            _test = test;
        }

        public async Task<bool> AssignRole(string email, string roleName)
        {
            var user = _appDbContext.ApplicationUsers.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
            if(user != null)
            {
                if (!_rolemanager.RoleExistsAsync(roleName).GetAwaiter().GetResult())
                {
                    _rolemanager.CreateAsync(new IdentityRole(roleName)).GetAwaiter().GetResult();

                }
                await _usermanager.AddToRoleAsync(user, roleName);
                return true;
            }
            return false;

        }

        public async Task<LoginResponceDto> Login(LoginRequestDto loginRequestDto)
        {
            var user = _appDbContext.ApplicationUsers.FirstOrDefault(u=>u.UserName.ToLower() == loginRequestDto.UserName.ToLower());
            bool isvalid = await _usermanager.CheckPasswordAsync(user, loginRequestDto.Password);
            if(user == null || isvalid==false)
            {
                return new LoginResponceDto() { User = null, Token = "" };

            }
            // Récupérer le rôle de l'utilisateur
            var userRoles = await _usermanager.GetRolesAsync(user);
            var userRole = userRoles.FirstOrDefault(); // Supposons qu'un utilisateur a un seul rôle ici

            //if the user found generate the JWT token
            var token = _test.generateToken(user);
            UserDto userDTO = new()
            {
                Email = user.Email,
                Id = user.Id,
                Name = user.Name,
            };
            LoginResponceDto loginResponse = new LoginResponceDto()
            {
                User = userDTO,
                Token = token,
                userRole = userRole

            };
            return loginResponse;
        }

        public async Task<ResponseDto> Register(RegistrationReqiuestDto registrationReqiuestDto)
        {
            ApplicationUser user = new()
            {
                UserName = registrationReqiuestDto.Email,
                Email = registrationReqiuestDto.Email,
                NormalizedEmail = registrationReqiuestDto.Email.ToUpper(),
                Name = registrationReqiuestDto.userName,

            };
            
                var result = await _usermanager.CreateAsync(user, registrationReqiuestDto.Password);
                if (result.Succeeded)
                {
                    var userToReturn = _appDbContext.ApplicationUsers.First(u => u.UserName == registrationReqiuestDto.Email);
                    UserDto userdto = new()
                    {
                        Email = userToReturn.Email,
                        Id = userToReturn.Id,
                        Name = userToReturn.Name,

                    };
                    var token = _test.generateToken(userToReturn);
                    ResponseDto registreResponse = new ResponseDto()
                    {
                        User = userdto,
                        Token = token,
                        IsSuccess = true,
                        Message = ""

                    };
                    return registreResponse;
                }else
                {
                    ResponseDto registreResponse = new ResponseDto()
                    {
                        
                        IsSuccess = false,
                        Message = "error"

                    };

                    return registreResponse;
                }
            
        }
    }
}
