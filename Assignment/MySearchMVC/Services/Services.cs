using MySearchMVC.Models;
using MySearchMVC.DataAccess;


namespace MySearchMVC.Services
{
    public class Services : iserv<ProductDetail>
    {
        Eshopping2Context _context;
        public Services(Eshopping2Context context)
        {
            _context = context;
        }




        public List<ProductDetail> Searching( string? searchterm)
        {
            
            var products = _context.ProductDetails.ToList();

            Dictionary<int, string> data = new Dictionary<int, string>();




            products.ToList().ForEach(p => data.Add(p.ProductId, (p.Seller + p.ManufracturerName + p.ProductName + p.Description)));



            Char[] separator = { ' ' };
            StringSplitOptions options = System.StringSplitOptions.RemoveEmptyEntries;
            String[] searchArray = searchterm.Split(separator, options);

            List<int> results = new List<int>();

            int word_count = searchArray.Length;



            for (int i = 0; i < word_count; i++)
            {
                foreach (var D in data)
                {
                    if (i == 0 && D.Value.Contains(searchArray[i]))
                        results.Add(D.Key);

                    if (i != 0 && !(D.Value.Contains(searchArray[i])) && results.Contains(D.Key))
                        results.Remove(D.Key);

                }

            }



            var searchResult = products.ToList().Where(p => results.Contains(p.ProductId)).ToList();

            foreach (var item in searchResult)
            {
                Console.Write(item.ProductId);
                Console.Write($"\t{item.ProductName}");
                Console.Write($"\t{item.ManufracturerName}");
                Console.Write($"\t{item.Description}");
                Console.Write($"\t{item.Seller}");
                Console.Write($"\t{item.Price}\n");
            }


            return searchResult;
        }

       
    }

   
    
}
