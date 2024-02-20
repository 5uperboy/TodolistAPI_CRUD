using System.ComponentModel.DataAnnotations;

namespace TodolistAPI_CRUD.Models
{
    public class Users
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }
    }
}
