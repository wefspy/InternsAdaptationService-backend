namespace InternsAdaptationService.Data.Models;

public class Intern: User
{
    public required Guid MentorID { get; set; }

    public virtual Mentor Mentor { get; set; }
}
