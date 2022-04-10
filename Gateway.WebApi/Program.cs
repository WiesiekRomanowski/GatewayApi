using Gateway.Core.Application;
using Gateway.DataAccess;
using Gateway.Scheduler;
using Gateway.Services;
using Gateway.WebApi.SoapEndpoints;
using Gateway.WebApi.Sync_ebIX_CombinerCode_Service;
using SoapCore;

// Add services to the container.
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddServices();
builder.Services.AddDataAccess();
builder.Services.AddScheduler();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSoapCore();
builder.Services.AddTransient<ebIX_CombinerCode_PortType, CombinerCodeEndpoint>();

// Configure the HTTP request pipeline.
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseScheduler();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.UseSoapEndpoint<ebIX_CombinerCode_PortType>("/CombinerCode.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});

app.Run();