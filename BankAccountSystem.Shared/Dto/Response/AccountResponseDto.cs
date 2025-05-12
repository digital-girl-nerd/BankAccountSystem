namespace BankAccountSystem.Shared.Dto.Response
{
    public class AccountResponseDto
    {
        public string? AccountName { get; set; }
        public string? AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string AccountStatus { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
