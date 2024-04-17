namespace MauiApp2;

public class Item
{
    public string TimeRange { get; set; }
    public int Subject { get; set; }
    public int Teacher { get; set; }
}

public class Groups
{
    public Days Current { get; set; }
    public List<Days> Other { get; set; }
}


public class Days
{
    public Days()
    {
        Monday = new Schedule();
        Tuesday = new Schedule();
        Wednesday = new Schedule();
        Thursday = new Schedule();
        Friday = new Schedule();
    }
    public Schedule Monday { get; set; }
    public Schedule Tuesday { get; set; }
    public Schedule Wednesday { get; set; }
    public Schedule Thursday { get; set; }
    public Schedule Friday { get; set; }
    
}


public class Schedule
{
    public Schedule()
    {
        First = new Discipline();
        Second = new Discipline();
        Third = new Discipline();
    }
    public Discipline First { get; set; }
    public Discipline Second { get; set; }
    public Discipline Third { get; set; }
}


public class Discipline
{
    public string TimeRange { get; set; }
    public int Subject { get; set; }
    public int Teacher { get; set; }
}