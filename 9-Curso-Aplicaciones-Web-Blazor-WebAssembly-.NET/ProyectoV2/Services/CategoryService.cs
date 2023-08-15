using System.Text.Json;
using System.Net.Http.Json;

namespace ProyectoV2.Service;

public class CategoryService : ICategoryService
{

    private readonly HttpClient client;
    private readonly JsonSerializerOptions option;

    public CategoryService(HttpClient httpClient)
    {
        client=httpClient;
        option=new JsonSerializerOptions{PropertyNameCaseInsensitive =true};
      }  
    public async Task<List<Category>?> Get(){
        var response=await client.GetAsync("/v1/Categories");
        var content= await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }
        return JsonSerializer.Deserialize<List<Category>>(content,option);
        
    }
    
}

public interface ICategoryService
{
    Task<List<Category>?> Get();
}