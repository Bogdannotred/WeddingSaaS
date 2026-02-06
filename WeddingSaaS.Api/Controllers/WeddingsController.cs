using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeddingSaaS.Core.Entities;
using WeddingSaas.Infrastructure.Data;

namespace WeddingSaaS.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeddingsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public WeddingsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Create (Wedding wedding)
    {
        if (wedding.Id == Guid.Empty) wedding.Id = Guid.NewGuid();
        _context.Weddings.Add(wedding);
        await _context.SaveChangesAsync();
        return Ok(wedding);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Wedding>>> GetAll()
    {
        return await _context.Weddings.Include(w => w.Photos).ToListAsync();
    }
}