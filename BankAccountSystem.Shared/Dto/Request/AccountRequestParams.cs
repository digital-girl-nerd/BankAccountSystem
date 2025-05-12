namespace BankAccountSystem.Shared.Dto.Request
{
    public class AccountRequestParams
    {
        public string Id { get; set; }
        public string? AccountName { get; set; }
        public string? AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string AccountStatus { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
