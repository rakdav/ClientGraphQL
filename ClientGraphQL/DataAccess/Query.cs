using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using ModernHttpClient;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ClientGraphQL.DataAccess
{
    public class Query
    {
        private static GraphQLHttpClient graphQLHttpClient;
        static Query()
        {
            var uri = new Uri("http://localhost:5000/graphgl/");
            var graphQLOptions = new GraphQLHttpClientOptions
            {
                EndPoint=uri,
                HttpMessageHandler=new NativeMessageHandler(),
            };
            graphQLHttpClient = new GraphQLHttpClient(graphQLOptions,
                new NewtonsoftJsonSerializer());
        }
        public static async Task<List<T>> ExecuteQueryReturnListAsync<T>(string graphQLQueryType,
            string completeQueryString)
        {
            try
            {
                var request = new GraphQLRequest
                {
                    Query=completeQueryString
                };
                var response = await graphQLHttpClient.SendQueryAsync<object>(request);
                var stringResult = response.Data.ToString();
                stringResult = stringResult!.Replace($"\"{graphQLQueryType}\":", string.Empty);
                stringResult = stringResult.Remove(0, 1);
                stringResult = stringResult.Remove(stringResult.Length - 1, 1);
                var result = JsonConvert.DeserializeObject<List<T>>(stringResult);
                return result!;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static async Task<T> ExecuteQueryAsync<T>(string graphQLQueryType,
           string completeQueryString)
        {
            try
            {
                var request = new GraphQLRequest
                {
                    Query = completeQueryString
                };
                var response = await graphQLHttpClient.SendQueryAsync<object>(request);
                var stringResult = response.Data.ToString();
                stringResult = stringResult!.Replace($"\"{graphQLQueryType}\":", string.Empty);
                stringResult = stringResult.Remove(0, 1);
                stringResult = stringResult.Remove(stringResult.Length - 1, 1);
                var result = JsonConvert.DeserializeObject<T>(stringResult);
                return result!;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
