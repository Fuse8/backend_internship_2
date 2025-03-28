using Fuse8.BackendInternship.PublicApi;

var webHost = Host
	.CreateDefaultBuilder(args)
	.ConfigureWebHostDefaults(webHostBuilder => webHostBuilder.UseStartup<Startup>())
	.Build();

await webHost.RunAsync();