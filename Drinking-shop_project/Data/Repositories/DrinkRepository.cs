
using Drinking_shop_project.Models;
using Microsoft.EntityFrameworkCore;

namespace Drinking_shop_project.Data
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public DrinkRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Drink> Drinks => _appDbContext.Drinks.Include(c => c.Category);

        public IEnumerable<Drink> PreferredDrinks => _appDbContext.Drinks.Where(p => p.IsPreferredDrink).Include(c => c.Category);

        public Drink GetDrinkById(int drinkId) => _appDbContext.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
    }
}
