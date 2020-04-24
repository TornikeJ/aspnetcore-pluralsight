using OdeToFood.Core;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestarantsByName(string name);
        Restaurant GetRestaurantById(int id);
        Restaurant UpdateRestaurant(Restaurant updatedRestaurant);

        Restaurant Delete(int id);

        Restaurant AddNewRestaurant(Restaurant newRestaurant);

        int GetCountOfRestaurants();
        int Commit();
    }
}
