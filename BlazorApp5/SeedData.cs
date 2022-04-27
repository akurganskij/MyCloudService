namespace BlazorApp5;

public static class SeedData
{
    public static void Initialize(DBContext db)
    {
        var ts = new Tasks() { answer = "fsf", Id = 1, question = "hdfjbjk", x1 = 1, x2 = 1, y1 = 1, y2 = 1 };
        var ts_list = new List<Tasks>();
        ts_list.Add(ts);
        var images = new Image[]
        {
            new Image{
                Id = 1,
                Name = "Image1",
                Description = "hjfjkk",
                Tasks = ts_list,

            },
            new Image{
                Id = 2,
                Name = "Image2",
                Description = "ghdj",
                
                Tasks =  ts_list,
            }
        };
        db.tasks.Add(ts);
        db.images.AddRange(images);
        db.SaveChanges();
    }
}