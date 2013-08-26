using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using ADevsLife.BingGoogle.SearchAgent;

namespace ADevsLife.BingGoogle.Web
{
    [ServiceContract(Namespace = "ADevsLife")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Search
    {
        [OperationContract]
        [WebGet]
        public CombinedSearchResults DoSearch(string q)
        {
            if (!string.IsNullOrWhiteSpace(q))
            {
                var search = new CallSearchEngine();
                return search.Search(q);
            }
            return null;
        }

    }
}
