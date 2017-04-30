﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using Unity;
using Unity.AutoRegistration;
using Microsoft.Practices;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Contracts;
using TestRepository;
using TestProvider;
using MongoRepository;
using Newtonsoft.Json;



namespace DOTNetHost
{
    public static class WebApiConfig
    {
        public static UnityContainer container;

        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //Define Formatters
            var formatters = GlobalConfiguration.Configuration.Formatters;
            var jsonFormatter = formatters.JsonFormatter;
            var settings = jsonFormatter.SerializerSettings;
            settings.Formatting = Formatting.Indented;
            // settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var appXmlType = formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);

            IUnityContainer container = new UnityContainer();
             
            container.RegisterType<IRepository<object>, SQLRepository<object>>();
            container.RegisterType<IRepository<object>, MongoRepository<object>>();
            container.RegisterType<IProvider, ServiceProvider>();
            container.Resolve<IRepository<object>>(); 
            
        }
    }
}
