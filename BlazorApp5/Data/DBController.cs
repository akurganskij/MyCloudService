﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp5;

[Route("cloud")]
[ApiController]
public class SpecialsController : Controller
{
    private DBContext _db;

    public SpecialsController(DBContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<Image>>> GetImage()
    {
        return (await _db.images.ToListAsync()).OrderByDescending(s => s.Id).ToList();
    }
    [HttpGet]
    public async Task<ActionResult<List<Tasks>>> GetTasks(int imId)
    {
        return (from tasks in _db.tasks.Include(p => p.Image)
                where tasks.ImageId == imId
                select tasks).ToList();
    }
    [HttpPost]
    public async void PostImage(Image dm)
    {
        if (_db.images.Contains(dm)) return;
        await _db.images.AddAsync(dm);
        await _db.SaveChangesAsync();
    }
    [HttpPost]
    public async void PostTask(Tasks dm)
    {
        if (_db.tasks.Contains(dm)) return;
        await _db.tasks.AddAsync(dm);
        await _db.SaveChangesAsync();
    }
}