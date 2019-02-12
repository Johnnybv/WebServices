using System.Linq;
using Modas.Models.ViewModels;

namespace Modas.Models
{
    public class EFEventRepository : IEventRepository
    {
        private ApplicationDbContext context;

        public EFEventRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Event> Events => context.Events;
        public IQueryable<Location> Locations => context.Locations;
    }
}