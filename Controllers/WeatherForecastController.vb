Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports Microsoft.AspNetCore.Mvc
Imports Microsoft.Extensions.Logging
 
Namespace VBDotNetHW.Controllers
    <[ApiController]>
    <Route("[controller]")>
    Public Class WeatherForecastController
        Inherits ControllerBase
    
        Private Shared ReadOnly Summaries() As String = {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        }
        
        Private ReadOnly _logger As ILogger(Of WeatherForecastController) 

        Sub New(logger As ILogger(Of WeatherForecastController))
            _logger = logger
        End Sub

        <HttpGet>
        Public Function [Get]() As IEnumerable(Of WeatherForecast)
            Dim rng = new Random()
            Return Enumerable.Range(1, 5).
                Select (Function(index) new WeatherForecast With
                {   .Datetime = DateTime.Now.AddDays(index),
                    .TemperatureC = rng.Next(-20, 55),
                    .Summary = Summaries(rng.Next(Summaries.Length))
                }).
                ToArray()
        End Function

    End Class
End Namespace