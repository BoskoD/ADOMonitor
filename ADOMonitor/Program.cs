using ADOMonitor.Models.ADOBuilds;
using ADOMonitor.Models.ADOReleases;
using ADOMonitor.Models.ADOServiceHealth;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace ADOMonitor
{
    public class Program
    {
        public static IConfigurationRoot Configuration { get; set; }

        static async Task Main(string[] args)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            var PAT = Configuration.GetSection("PAT").Value;
            var orgName = Configuration.GetSection("Org").Value;
            var project = Configuration.GetSection("Project").Value;

            var serviceHealth = await GetServiceHealth();
            var builds = GetBuilds(orgName, project, PAT);
            var releases = GetReleases(orgName, project, PAT);

            GetProjects(orgName, PAT);
            GetDeployments(orgName, project, PAT);
        }

        public static async Task<ServiceRoot> GetServiceHealth()
        {
            ServiceRoot serviceRoot = null;
            try
            {
                //use the httpclient
                using (var client = new HttpClient())
                {
                    //connect to the REST endpoint            
                    HttpResponseMessage response = client.GetAsync("https://status.dev.azure.com/_apis/status/health?api-version=7.1-preview.1").Result;

                    //check to see if we have a successful response
                    if (response.IsSuccessStatusCode)
                    {
                        var responseBody = await response.Content.ReadAsStringAsync();
                        serviceRoot = JsonConvert.DeserializeObject<ServiceRoot>(responseBody);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return serviceRoot;
        }

        public static async void GetProjects(string orgName, string personalAccessToken)
        {
            //encode your personal access token                   
            string credentials = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", "", personalAccessToken)));

            try
            {
                //use the httpclient
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"https://dev.azure.com/{orgName}/");  //url of your organization
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);

                    //connect to the REST endpoint            
                    HttpResponseMessage response = client.GetAsync("_apis/projects?stateFilter=All&api-version=1.0").Result;

                    //check to see if we have a successful response
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(responseBody);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }

        public static async Task<BuildRoot> GetBuilds(string orgName, string project, string personalAccessToken)
        {
            BuildRoot root = null;
            try
            {
                using (HttpClient client = new())
                {
                    client.DefaultRequestHeaders.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(
                            System.Text.ASCIIEncoding.ASCII.GetBytes(
                                string.Format("{0}:{1}", "", personalAccessToken))));

                    using (HttpResponseMessage response = client.GetAsync(
                                $"https://dev.azure.com/{orgName}/{project}/_apis/build/builds?api-version=5.0").Result)
                    {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();
                        root = JsonConvert.DeserializeObject<BuildRoot>(responseBody);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return root;
        }

        public static async Task<ReleaseRoot> GetReleases(string orgName, string project, string personalAccessToken)
        {
            ReleaseRoot root = null;
            int definitionId = 2; // -> Infrastructure definition
            string searchText = "master"; //filter master pipelines

            try
            {
                using (HttpClient client = new())
                {
                    client.DefaultRequestHeaders.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(
                            System.Text.ASCIIEncoding.ASCII.GetBytes(
                                string.Format("{0}:{1}", "", personalAccessToken))));

                    using (HttpResponseMessage response = client.GetAsync(
                                $"https://vsrm.dev.azure.com/{orgName}/{project}/_apis/release/releases?view=all&_a=releases&searchText={searchText}&definitionId={definitionId}").Result)
                    {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();
                        root = JsonConvert.DeserializeObject<ReleaseRoot>(responseBody);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return root;
        }

        public static async void GetDeployments(string orgName, string project, string personalAccessToken)
        {
            try
            {
                using (HttpClient client = new())
                {
                    client.DefaultRequestHeaders.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(
                            System.Text.ASCIIEncoding.ASCII.GetBytes(
                                string.Format("{0}:{1}", "", personalAccessToken))));

                    using (HttpResponseMessage response = client.GetAsync(
                                $"https://vsrm.dev.azure.com/{orgName}/{project}/_apis/release/deployments?api-version=7.1-preview.2").Result)
                    {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(responseBody);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}