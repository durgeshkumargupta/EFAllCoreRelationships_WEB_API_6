namespace EFCoreRelationships
{
    public class User
    {
        public int Id { get; set; }
        public string username { get; set; } = String.Empty;

        public List<Character> Characters { get; set; }
    }
}
