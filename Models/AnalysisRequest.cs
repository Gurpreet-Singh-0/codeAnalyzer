using System.ComponentModel.DataAnnotations;
namespace CodeAnalyzer.Models
{
    public class AnalysisRequest
    {
        [Required]
        [Display(Name = "Programming Language")]
        public string Language { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Code to Analyze")]
        public string Code { get; set; } = string.Empty;

        [Display(Name = "Analysis Type")]
        public AnalysisType Type { get; set; } = AnalysisType.General;
    }

    public class AnalysisResult
    {
        public bool Success { get; set; }
        public string Analysis { get; set; } = string.Empty;

        public string Error { get; set; } = string.Empty;

        public List<CodeSuggestion> Suggestions { get; set; } = new List<CodeSuggestion>();
        public CodeQuality Quality { get; set; } = new CodeQuality();
    }
}

public class CodeSuggestion
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;

    public int Priority { get; set; }
}


public class CodeQuality
{
    public int Score { get; set; }
    public string Grade { get; set; } = string.Empty;
    public List<string> Issues { get; set; } = new List<string>();
    public List<string> Strengths { get; set; } = new List<string>();
}

public enum AnalysisType
{
    General,
    Performance,
    Security,
    BestPractices,
    CodeStyle
}

public static class SupportedLanguages
{
    public static readonly Dictionary<string, string> Langauges = new Dictionary<string, string>
    {
        {"csharp", "C#"},
        {"java", "Java"},
        {"python","Python"},
        {"javascript", "JavaScript"},
        {"typescript","TypeScript"},
        {"cpp", "C++"},
        {"c","C"},
        {"php", "PHP"},
        {"ruby", "Ruby"},
        {"go", "Go"},
        {"rust", "Rust"},
        {"kotlin", "Kotlin"},
        {"swift", "Swift"},
        {"sql", "SQL"}
    };
}