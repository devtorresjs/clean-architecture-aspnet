namespace Tec.ProductCatalog.GetProduct.Rest.Endpoints
{
    public static class Patterns
    {
        const string GetProductRouteBase = "getproduct";

        public const string GetProduct = $"{GetProductRouteBase}/{{id}}";

        public static string BuildGetProductUri(int productId) =>
            $"{GetProductRouteBase}/{productId}";
    }
}
