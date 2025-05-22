namespace Fiszki.Models
{
    public class List
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Word> Words { get; set; }
    }
}
