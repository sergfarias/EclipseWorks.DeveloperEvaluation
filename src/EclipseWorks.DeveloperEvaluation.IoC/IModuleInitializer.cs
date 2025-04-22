using Microsoft.AspNetCore.Builder;

namespace EclipseWorks.DeveloperEvaluation.IoC;

public interface IModuleInitializer
{
    void Initialize(WebApplicationBuilder builder);
}
