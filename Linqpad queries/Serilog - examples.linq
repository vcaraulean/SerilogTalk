<Query Kind="Statements">
  <NuGetReference>Serilog.Formatting.Compact</NuGetReference>
  <NuGetReference>Serilog.Sinks.Console</NuGetReference>
  <NuGetReference>Serilog.Sinks.LINQPad</NuGetReference>
  <Namespace>Serilog</Namespace>
  <Namespace>Serilog.Formatting.Compact</Namespace>
  <Namespace>Serilog.Formatting.Display</Namespace>
  <Namespace>Serilog.Formatting.Json</Namespace>
  <Namespace>Serilog.Formatting.Raw</Namespace>
  <Namespace>Serilog.Sinks.LINQPad</Namespace>
  <Namespace>Serilog.Sinks.SystemConsole.Themes</Namespace>
  <Namespace>Serilog.Context</Namespace>
</Query>

var log = new LoggerConfiguration()
	.WriteTo.LINQPad()
//	.WriteTo.Console()
//	.WriteTo.Console(new CompactJsonFormatter())
	.WriteTo.Console(new JsonFormatter())
	.CreateLogger();

var who = "world";
log.Information("Hello, {0}", who);

log.Information("Hello, {name}", who);

var person = new {Name = "Me", Age = 32};
log.Information("Hello {Person}", person);
log.Information("Hello {@Person}", person);



var array = new[] {"red", "green"};
log.Information("Array: {Colors}", array);



var dict = new Dictionary<int, string> {
	[1] = "one",
	[2] = "two"
};
log.Information("Dict: {Numbers}", dict);
