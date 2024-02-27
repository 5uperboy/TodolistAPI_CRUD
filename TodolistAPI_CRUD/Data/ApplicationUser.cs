using Microsoft.AspNetCore.Identity;

namespace TodolistAPI_CRUD.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
