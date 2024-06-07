namespace CommonClasses
{
    public class BankAccountJson
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ulong Balance { get; set; }
        public ulong UserId { get; set; }
    }
}
