using Persistence;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;  //  reads the passed in data context

        // struct to load up our datacontext from our db
        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        //  create a get entrypoint for our API for 'ap/activites' route for all activities
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _context.Activities.ToListAsync();
        }

        //  create GET entrypoint when param of id is passed to retrieve that activity w/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }
    }
}