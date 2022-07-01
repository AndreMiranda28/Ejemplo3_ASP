using AutoMapper;
using System;
using System.Linq;
using System.Reflection;


namespace Almacen.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ApplyMappingsFromAssembly();
        }

        private void ApplyMappingsFromAssembly()
        {
            var types = Assembly.GetExecutingAssembly().GetExportedTypes()
                        .Where(t => t.GetInterfaces().Any(i =>
                        i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<,>)
                        )).ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);

                var methodInfo = type.GetMethod("Mapping")
                            ?? type.GetInterface("IMapFrom`2").GetMethod("Mapping");

                methodInfo?.Invoke(instance, new object[] { this });
            }

        }
    }
}