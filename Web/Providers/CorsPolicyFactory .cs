using System.Net.Http;
using System.Web.Http.Cors;

namespace Web.Providers
{
    public class CorsPolicyFactory : ICorsPolicyProviderFactory
    {
        ICorsPolicyProvider _provider = new MyCorsPolicyAttribute();

        public ICorsPolicyProvider GetCorsPolicyProvider(HttpRequestMessage request)
        {
            return _provider;
        }
    }
}