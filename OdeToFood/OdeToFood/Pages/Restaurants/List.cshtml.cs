using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Data;
using OdeToFood.Core;
using Microsoft.Extensions.Logging;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        public string Message { get; set; }
        public IEnumerable<OdeToFood.Core.Restaurant> Restaurants { get; set; }

        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }

        private readonly IRestaurantData restaurantData;
        private readonly ILogger<ListModel> logger;

        public ListModel(IRestaurantData restaurantData, ILogger<ListModel> logger)
        {
            this.restaurantData = restaurantData;
            this.logger = logger;
        }
        public void OnGet()
        {
            logger.LogError("Executing ListModel");
            Message = "Hello World";
            Restaurants = restaurantData.GetRestarantsByName(SearchTerm);
        }
    }
}