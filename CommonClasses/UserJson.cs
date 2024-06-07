namespace CommonClasses
{
    public class UserJson
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public List<GuidNameClass> AccountsIds { get; set; }
    }
}
