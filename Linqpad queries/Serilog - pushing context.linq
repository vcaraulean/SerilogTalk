<Query Kind="Statements">
  <NuGetReference>Serilog.Formatting.Compact</NuGetReference>
  <NuGetReference>Serilog.Sinks.Console</NuGetReference>
  <NuGetReference>Serilog.Sinks.LINQPad</NuGetReference>
  <NuGetReference>Serilog.Sinks.Seq</NuGetReference>
  <Namespace>Serilog</Namespace>
  <Namespace>Serilog.Context</Namespace>
  <Namespace>Serilog.Formatting.Compact</Namespace>
  <Namespace>Serilog.Formatting.Display</Namespace>
  <Namespace>Serilog.Formatting.Json</Namespace>
  <Namespace>Serilog.Formatting.Raw</Namespace>
  <Namespace>Serilog.Sinks.LINQPad</Namespace>
  <Namespace>Serilog.Sinks.SystemConsole.Themes</Namespace>
</Query>

var log = new LoggerConfiguration()
	.WriteTo.LINQPad()
	.Enrich.FromLogContext()
	.WriteTo.Seq("http://localhost:5341")
	.CreateLogger();

for (var i = 0; i < 10; i++)
{
	using (LogContext.PushProperty("CurrentNumber", new {i = i}))
	{
		log.Information("Calculating square of {Number}", i);
		var result = i * i;
		log.Information("The result is {Result}", result);
	}
}