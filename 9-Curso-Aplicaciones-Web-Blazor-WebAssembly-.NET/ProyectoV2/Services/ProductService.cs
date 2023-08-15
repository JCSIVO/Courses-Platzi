using System.Text.Json;
using System.Net.Http.Json;

namespace ProyectoV2.Service;

public class ProductService : IProductService
{
    private readonly HttpClient client;

    private readonly JsonSerializerOptions options;

    public ProductService(HttpClient httpclient)
    {
        client = httpclient;
        options = new JsonSerializerOptions{PropertyNameCaseInsensitive =true};
    }

    public async Task<List<Product>?> Get(){
        var response=await client.GetAsync("/v1/products");
        var content= await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }
        return JsonSerializer.Deserialize<List<Product>>(content,options);
        
    }

    public async Task Add(Product product){
        var response=await client.PostAsync("v1/products", JsonContent.Create(product));
        var content= await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }
    }

    public async Task Delete(int productId){
        var response=await client.DeleteAsync($"v1/products/{productId}");
        var content= await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        } 
    }
    
}

public interface IProductService
{
    Task<List<Product>?> Get();
    Task Add(Product product);
    Task Delete(int productId);   
}