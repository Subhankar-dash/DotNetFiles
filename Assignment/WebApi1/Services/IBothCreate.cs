namespace WebApi1.Services
{
    public interface IBothCreate<Tentity , Tentity2 > where Tentity  : class   
    {
        Task<string> CreateBothAsync(Tentity entity , Tentity2 tentity2);
    }
}
