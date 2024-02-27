namespace TodolistAPI_CRUD.DTOs
{
    public class UserSession
    {
        public string? Id { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }

        public UserSession(string? id, string? userName, string? email, string? role)
        {
            Id = id;
            UserName = userName;
            Email = email;
            Role = role;
        }
    }
}
