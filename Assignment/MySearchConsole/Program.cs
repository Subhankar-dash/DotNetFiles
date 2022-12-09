using MySearchConsole.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Eshopping2Context context = new Eshopping2Context();

DataAccess dataAccess = new DataAccess(context);

var products = dataAccess.GetProduct();



Console.WriteLine("enter search");
string? searchterm = Console.ReadLine();
Console.WriteLine();

Searching(products, searchterm);



static void Searching(IEnumerable<ProductDetail> products, string? searchterm )
{
    Dictionary<int, string> data = new Dictionary<int, string>();

    List<int> results = new List<int>();



    products.ToList().ForEach(p =>  
    data.Add(p.ProductId,(p.Seller + p.ManufracturerName + p.ProductName + p.Description)));
   
    
    
    Char[] separator = { ' ' };
    StringSplitOptions options = System.StringSplitOptions.RemoveEmptyEntries;
    String[] searchArray = searchterm.Split(separator, options);








    for (int i = 0; i < searchArray.Length; i++)
    {
        foreach (var D in data)
        {
            if (i == 0 && D.Value.Contains(searchArray[i]))
            results.Add(D.Key);
            
           if (i!=0 && !(D.Value.Contains(searchArray[i])) && results.Contains(D.Key))
           results.Remove(D.Key);
            
        }
        
    }



    var searchResult = products.ToList().Where(p => results.Contains(p.ProductId));

    foreach (var item in searchResult)
    {
        Console.Write(item.ProductId);
        Console.Write($"\t{item.ProductName}");
        Console.Write($"\t{item.ManufracturerName}");
        Console.Write($"\t{item.Description}");
        Console.Write($"\t{item.Seller}");
        Console.Write($"\t{item.Price}\n");
    }
}

public class DataAccess
    {
    Eshopping2Context _context;
    public DataAccess(Eshopping2Context context)
    {
       this._context  = context;
    }

    public  IEnumerable<ProductDetail> GetProduct()
    {
        return  _context.ProductDetails.ToList();
    }
}


//var a = from D in data
//        where D.Value.Contains(searchArray[0])
//        select D.Key;
//a.ToList().ForEach(s => results.Add(s));



//searchArray.Where(s => data.ToList().Where(D => D.Value.Contains(s)));

//  data.ToList().Where(D => searchArray.ToList().ForEach(s => D.Value.Contains(s)));
