using MySearchMVC.Models;
namespace MySearchMVC.DataAccess
{
    public class ProductDetailDataAccess
    {
        
    Eshopping2Context _context;
        public ProductDetailDataAccess(Eshopping2Context context)
        {
            this._context = context;
        }

        public IEnumerable<ProductDetail> GetProduct()
        {
            return _context.ProductDetails.ToList();
        }
    }
}
