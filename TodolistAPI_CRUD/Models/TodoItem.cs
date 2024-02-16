namespace TodolistAPI_CRUD.Models
{
    public class TodoItem
    {
        private DateTime dateModified;

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsComplete { get; set; }
        public DateTime DateModified { get; set; }  

    }
}
