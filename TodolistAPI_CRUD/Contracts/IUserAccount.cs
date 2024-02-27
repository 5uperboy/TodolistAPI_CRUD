using TodolistAPI_CRUD.DTOs;
using static TodolistAPI_CRUD.DTOs.ServiceResponses;

namespace TodolistAPI_CRUD.Contracts
{
    public interface IUserAccount
    {
        Task<GeneralResponse> CreateAccount(UserDTO userDTO);
        Task<LoginResponse> LoginAccount(LoginDTO loginDTO);
    }
}
