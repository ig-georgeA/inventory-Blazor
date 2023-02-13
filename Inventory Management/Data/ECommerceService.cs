using System.Net.Http.Json;

namespace Inventory_Management.ECommerce
{
    public class ECommerceService: IECommerceService
    {
        private readonly HttpClient _http;

        public ECommerceService(HttpClient http)
        {
            this._http = http;
        }

        public async Task<List<SalesType>?> GetSales()
        {
            return await this._http.GetFromJsonAsync<List<SalesType>>("https://excel2json.io/api/share/f9942c71-b172-4060-4381-08da496bf5f2");
        }

        public async Task<List<RevenueType>?> GetRevenue()
        {
            return await this._http.GetFromJsonAsync<List<RevenueType>>("https://excel2json.io/api/share/03e74dde-d2e1-4fee-437d-08da496bf5f2");
        }
    }
}