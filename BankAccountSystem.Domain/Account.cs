using System.Security.Principal;
using BankAccountSystem.Domain.Enum;
using NetUlid;

namespace BankAccountSystem.Domain
{
    public class Account:BaseEntity
    {
      public string Id { get; set; }= string.Concat("ACT-", Ulid.Generate().ToString().AsSpan(16));
        public string? AccountName { get; set; }
        public string? AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public AccountType AccountType { get; set; }
        public AccountStatus AccountStatus { get; set; }
        
    }
}
