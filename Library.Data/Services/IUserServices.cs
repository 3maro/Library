using Library.API.Identity;
using Microsoft.AspNetCore.Identity;

namespace Library.API.Services
{
    public interface IUserServices
    {
        Task<UserMangerResponse> RegistertUserAsync(RegisterUser model);
    }

    public class UserServices : IUserServices
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UserServices(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }
        public async Task<UserMangerResponse> RegistertUserAsync(RegisterUser model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            var identityUser = new IdentityUser
            {
                Email = model.Email,
                UserName = model.Email,
            };

            var userToCreate = await _userManager.CreateAsync(identityUser, model.Password);

            if (!userToCreate.Succeeded)
            {
                return new UserMangerResponse
                {
                    Message = "User did not create",
                    IsSuccess = false,
                    Erorrs = userToCreate.Errors.Select(e => e.Description)
                };
            }

            return new UserMangerResponse
            {
                Message = "User created successfully",
                IsSuccess = true,
            };
        }
    }
}