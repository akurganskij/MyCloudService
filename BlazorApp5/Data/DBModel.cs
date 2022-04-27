
public class Image
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public List<Tasks>? Tasks { get; set; }

}

public class Tasks
{
    public int Id { get; set; }

    public int TaskNum { get; set; }

    public int x1 { get; set; }
    public int y1 { get; set; }
    public int x2 { get; set; }
    public int y2 { get; set; }

    public string question { get; set; }
    public string answer { get; set; }

    public int ImageId { get; set; }
    public Image Image { get; set; }
}
/*
public class Problems
{
    public int Id { get; set; }
    public string Name { get; set; }
    

    public int ImageId { get; set; }
}
*/