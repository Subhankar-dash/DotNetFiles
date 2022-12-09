using MySearchMVC.Models;

namespace MySearchMVC.Services
{
    public interface iserv<TEntity> where TEntity : class
    {
        public List<ProductDetail> Searching(string? searchterm);
    }
}
