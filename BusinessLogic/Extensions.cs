﻿using BusinessLogic.ServiceInterfaces;
using BusinessLogic.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic;

public static class Extensions
{
    public static IServiceCollection AddBusinessLogic(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IDoctorService, DoctorService>();
        serviceCollection.AddScoped<IPatientService, PatientService>();
        serviceCollection.AddScoped<IDictionaryService, DictionaryService>();
        serviceCollection.AddSingleton<ITokenService, TokenService>();
        return serviceCollection;
    }
}