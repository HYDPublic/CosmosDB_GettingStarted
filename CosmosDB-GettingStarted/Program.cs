using System;

using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;

namespace CosmosDB_GettingStarted
{
    class Program
    {
        private const string EndpointUri = "https://core-cosmo-cs-sql.documents.azure.com:443/";
        private const string PrimaryKey = "MktS98Vx9ge5G1s6nf7Sc3Ipkuifb88aKG18CNUvhmmy4AOWDhm8ocWmCkt6DXI8NnX3zvmG39ojzi6AfT6CVw==";
        private DocumentClient client;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}