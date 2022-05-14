namespace TodoApi.Models
{
    public class TodoItem
    {
        public TodoItem(string name, bool IsComplete)
        {
          this.Name = name;
          this.IsComplete = IsComplete;
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
