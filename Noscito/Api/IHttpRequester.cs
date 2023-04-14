namespace Noscito.Api;

public interface IHttpRequester
{ 
    Task<T> GetFromJsonAsync<T>(Uri endpoint);
}