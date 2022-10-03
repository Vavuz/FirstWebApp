using FirstWebApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.ViewComponents
{
    public class RestaurantCountViewComponent : ViewComponent
    {
        public IRestaurantData restaurantData;

        public RestaurantCountViewComponent(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }

        public IViewComponentResult Invoke()
        {
            var count = restaurantData.GetCOuntOfRestaurants();
            return View(count);
        }
        
    }
}
