﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Codeworx.Rest.Client;
using Codeworx.Rest.Client.Formatters;
using Codeworx.Rest.UnitTests.Api.Contract;
using Codeworx.Rest.UnitTests.Data;
using Codeworx.Rest.UnitTests.Generated;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Codeworx.Rest.UnitTests
{
    public class RestOptionsBuilderTest
    {
        [Fact]
        public void WithHttpClientExpectsOK()
        {
            var client = new HttpClient();

            var services = new ServiceCollection();
            services.AddRestClient()
                .WithHttpClient(p => client);

            var provider = services.BuildServiceProvider();

            var options = provider.GetRequiredService<RestOptions<IPathService>>();
            Assert.Equal(client, options.GetHttpClient());
        }

        [Fact]
        public void WithUrlAndContractURlExpectsOK()
        {
            var services = new ServiceCollection();
            services.AddRestClient()
                .WithBaseUrl("http://localhost:1234/testurl")
                .Contract<IPathService>(p => p.WithBaseUrl("http://localhost:4321/testurl"));

            var provider = services.BuildServiceProvider();

            var options = provider.GetRequiredService<RestOptions<IFileStreamController>>();
            var pathOptions = provider.GetRequiredService<RestOptions<IPathService>>();
            Assert.Equal(new Uri("http://localhost:1234/testurl"), options.GetHttpClient().BaseAddress);
            Assert.Equal(new Uri("http://localhost:4321/testurl"), pathOptions.GetHttpClient().BaseAddress);
        }

        [Fact]
        public void WithUrlExpectsOK()
        {
            var services = new ServiceCollection();
            services.AddRestClient()
                .WithBaseUrl("http://localhost:1234/testurl");

            var provider = services.BuildServiceProvider();

            var options = provider.GetRequiredService<RestOptions<IPathService>>();
            Assert.Equal(new Uri("http://localhost:1234/testurl"), options.GetHttpClient().BaseAddress);
        }

        [Fact]
        public void AddOrReplaceServiceTest()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IContentFormatter, JsonContentFormatter>(sp => null);
            services.AddOrReplace<IContentFormatter, JsonContentFormatter>(ServiceLifetime.Singleton, sp => new JsonContentFormatter(new Newtonsoft.Json.JsonSerializerSettings()));

            var provider = services.BuildServiceProvider();

            var jsonFormatter = provider.GetRequiredService<IEnumerable<IContentFormatter>>();
            Assert.Single(jsonFormatter);
            Assert.NotNull(jsonFormatter.First());
        }
    }
}