using Microsoft.EntityFrameworkCore;

public class SurveyContext : DbContext
{
    public DbSet<Survey> Surveys { get; set; }

    public SurveyContext(DbContextOptions<SurveyContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=survey.db");
    }
}
