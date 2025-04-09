using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Components.Routing;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotFormRecognizer
{
    internal static class Settings
    {
        public static string ConnectionString = "";
        public static string ContainerName = "formbotstorage";
        public static string Key = "";
        public static string Endpoint = "https://deakin19073460464.blob.core.windows.net/formbotstorage";

        public static string FormKey = "";
        public static string FormEndpoint = "https://formreconshane01.cognitiveservices.azure.com/";
        
    }
}
