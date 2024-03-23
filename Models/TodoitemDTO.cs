namespace TodoApi.Models
{
    public class TodoitemDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }//se va a verificar con un true o un false
    }
}
