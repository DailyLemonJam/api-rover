using APIRover.Services.HttpService;

namespace APIRover.Models;

public class MainWindowModel
{
    private readonly IHttpService _httpService;

    public MainWindowModel(IHttpService httpService)
    {
        _httpService = httpService;
    }

    public void HandleHttpRequest()
    {
        // use HttpService
        
        // get Response from HttpService

        // return needed values (in DTO), save in history and etc
    }
}
