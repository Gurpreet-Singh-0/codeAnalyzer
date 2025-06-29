using Microsoft.AspNetCore.Identity;

namespace CodeAnalyzer.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastLoginAt { get; set; }

        public virtual ICollection<AnalysisHistory> AnalysisHistories { get; set; } = new List<AnalysisHistory>();

    }

    public class AnalysisHistory
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;
        public string Analysis { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public virtual User User { get; set; } = null!;
    }
}