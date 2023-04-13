namespace Noscito;

public interface IHttpRequester
{ 
    Task<T> GetFromJsonAsync<T>(Uri endpoint);
}