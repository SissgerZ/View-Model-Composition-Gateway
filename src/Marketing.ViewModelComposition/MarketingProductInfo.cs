namespace Marketing.ViewModelComposition;

public class MarketingProductInfo : ICompositionRequestsHandler
{
    [HttpGet("/product/{id}")]
    public Task Handle(HttpRequest request)
    {
        var vm = request.GetComposedResponseModel();

        //retrieve product details from the marketing database or service
        vm.ProductName = "Sample product";
        vm.ProductDescription = "This is a sample product";

        return Task.CompletedTask;
    }
}
