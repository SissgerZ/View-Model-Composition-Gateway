namespace Sales.ViewModelComposition;

public class SalesProductInfo : ICompositionRequestsHandler
{
    [HttpGet("/product/{id}")]
    public Task Handle(HttpRequest request)
    {
        var vm = request.GetComposedResponseModel();

        //retrieve product details from the sales database or service
        vm.ProductId = request.HttpContext.GetRouteValue("id")?.ToString() ?? string.Empty;
        vm.ProductPrice = 100;

        return Task.CompletedTask;
    }
}
