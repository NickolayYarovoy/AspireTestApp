namespace CommonClasses
{
    public class RemittanceJson
    {
        public Guid SenderAccount { get; set; }
        public Guid RecipientAccount { get; set; }
        public ulong Value { get; set; }
    }
}
