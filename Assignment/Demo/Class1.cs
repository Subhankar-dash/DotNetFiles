using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Myclass
    {
        public static void Myfunch(int a)
        {
            Console.WriteLine("print" + a);
        }
    }
}

internal interface IDbAccess<TEntity,in TPk> 
{
    IEnumerable<TEntity> GetAll();
    TEntity Get(TPk id);
    TEntity Create(TEntity entity);
    TEntity Update(TPk id, TEntity entity);
    TEntity Delete(TPk id);
}

class subhankar : IDbAccess<string, int>
{
    public string Create(string entity)
    {
       return entity+"hell";
    }

    public string Delete(int id)
    {
        throw new NotImplementedException();
    }

    public string Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<string> GetAll()
    {
        throw new NotImplementedException();
    }

    public string Update(int id, string entity)
    {
        throw new NotImplementedException();
    }
}
