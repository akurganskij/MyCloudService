
public class Image
{
    public int Id { get; set; }
    public string Description { get; set; }

    public List<Tasks>? Tasks { get; set; }

}


public class Tasks
{
    public int Id { get; set; }

    public double x1 { get; set; }
    public double y1 { get; set; }
    public double x2 { get; set; }
    public double y2 { get; set; }

    public string question { get; set; }

    public int ImageId { get; set; }
    public Image Image { get; set; }
}

public class Problems
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Subject { get; set; }
    public string Topic { get; set; }
    public int Grade { get; set; }
    public int Complexity { get; set; }
    public int ImageId { get; set; }
    public Image Image { get; set; }
}