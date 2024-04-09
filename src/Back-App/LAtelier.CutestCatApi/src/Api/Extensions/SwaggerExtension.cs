using Microsoft.OpenApi.Models;
using System.Reflection;

namespace LAtelier.CutestCatApi.Api.Extensions
{
    public static class SwaggerExtension
    {
        /// <summary>
        /// Init and add LAtelier swagger configuration
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        public static IServiceCollection AddLAtelierSwaggerGen(this IServiceCollection service)
        {
            service.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "LAtelier.CutestCatApi",
                    Description = "LAtelier Api for vote and display the cutest cat",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "LAtelier amdin teams",
                        Url = new Uri("https://example.com/contact")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "License",
                        Url = new Uri("https://example.com/license")
                    }
                });

                // using System.Reflection;
                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });

            return service;
        }
    }
}
