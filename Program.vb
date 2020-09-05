Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.Hosting
Imports Microsoft.Extensions.Logging

Namespace VBDotNetHW
    Module Program
    
        Public Sub Main(args As String())
            CreateHostBuilder(args).Build().Run()
        End Sub

        Public Function CreateHostBuilder(args As String()) As IHostBuilder
            Return Host.CreateDefaultBuilder(args).
                ConfigureWebHostDefaults(Function(webBuilder) webBuilder.UseStartup(of Startup)()) 
        End Function

    End Module
End Namespace