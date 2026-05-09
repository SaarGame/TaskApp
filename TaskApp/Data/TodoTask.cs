namespace TaskApp.Data;

public enum Category
{
    כללי,
    חשמל,
    גננות,
    ניקיון,
    נגרות,
    אינסטלציה,
    קניות,
}

public enum Location
{
    כללי,
    הורים,
    סלון,
    מטבח,
    מטבחון,
    עמית,
    סער,
    סטודיו,
    גינה,
    שירותיהורים,
    שירותיםסער,
    שירותיםעמית,
    שירותיאורחים,
}

public class TodoTask
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int Priority { get; set; } = 0;
    public Category Category { get; set; } = Category.כללי;
    public Location Location { get; set; } = Location.כללי;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsDone { get; set; }
}
