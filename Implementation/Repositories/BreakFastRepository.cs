using AkiinsBreakfast.Context;
using AkiinsBreakfast.Entities;

namespace AkiinsBreakfast.Implementation.Repositories
{
    public class BreakfastRepository
    {
        private readonly ApplicationDbContext _context;

        public BreakfastRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool BreakFastExist(int id)
        {
            return _context.Breakfasts.Any(bf => bf.Id == id);
        }

        public bool BreakFastExist(string name)
        {
            return _context.Breakfasts.Any(bf => bf.Name == name);
        }

        public Breakfast Create(Breakfast breakfast)
        {
            _context.Breakfasts.Add(breakfast);
            _context.SaveChanges();
            return breakfast;
        }
    }
}
