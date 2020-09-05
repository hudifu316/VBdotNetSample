Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports Microsoft.AspNetCore.Mvc
Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.AspNetCore.HttpsPolicy
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting

Namespace VBDotNetHW
    Public Class Startup
        
        Public Sub New(configuration As IConfiguration)
            _Configuration = configuration
        End Sub
        
        Private _Configuration As IConfiguration
        
        Public ReadOnly Property Configuration As IConfiguration
            Get
                Return _Configuration
            End Get
        End Property

        Public Sub ConfigureServices(services As IServiceCollection)
            services.AddControllers()
        End Sub

        Public Sub Configure(app As IApplicationBuilder, env As IWebHostEnvironment)
            If env.IsDevelopment() Then
                app.UseDeveloperExceptionPage()
            End If

            app.UseHttpsRedirection()
            app.UseRouting()
            app.UseAuthorization()
            app.UseEndpoints(Function(endpoints) endpoints.MapControllers())

        End Sub
        
    End Class
End Namespace