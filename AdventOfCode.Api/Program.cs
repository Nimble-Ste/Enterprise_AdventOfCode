namespace AdventOfCode.Api
{
    using AdventOfCode.CalorieReaderService;
    using AdventOfCode.CalorieReaderService.Providers;
    using AdventOfCode.Common;
    using AdventOfCode.ElfCalorieService.Factories;
    using AdventOfCode.ElfCalorieService.Provider;
    using AdventOfCode.FileReaderService.Providers;
    using ElfCalorieService;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using ChunkerService;

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddTransient<IElfCalorieService, ElfCalorieService>();
            builder.Services.AddTransient<ICalorieReaderProvider, CalorieReaderProvider>();

            builder.Services.AddTransient<IElfCalorieBuilderFactoryProvider, ElfCalorieBuilderFactoryProvider>();
            builder.Services.AddTransient<ICalorieReaderService, CalorieReaderService>();

            //file reading
            builder.Services.AddTransient<IReaderTypeProvider, ReaderTypeProvider>();
            builder.Services.AddTransient<IFileReaderProviderService, FileReaderProviderService>();

            builder.Services.AddTransient<IChunkerService, ChunkerService>();

            builder.Services.AddTransient<ICalorieReaderProvider, CalorieReaderProvider>();
            builder.Services.AddTransient<IBlankEntryProvider, BlankEntryProvider>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapGet("/MaxElf", async ([FromServices] IElfCalorieService elfCalorieService) =>
            {
                var result = await elfCalorieService.GetElfByMaxCaloriesAsync();
                return Results.Ok(result);
            });

            app.MapGet("/TopElves", async (int number, [FromServices] IElfCalorieService elfCalorieService) =>
            {
                var result = await elfCalorieService.GetTopElves(number);
                return Results.Ok(result);
            });

            app.Run();
        }
    }
}