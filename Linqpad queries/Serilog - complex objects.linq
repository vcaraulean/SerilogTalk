<Query Kind="Program">
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
</Query>

class User
{
	public int Id { get; set; }
	public string Name { get; set; }
	public DateTime Created { get; set; }
}

void Main()
{
	var log = new LoggerConfiguration()
	.WriteTo.LINQPad()
	.CreateLogger();

	var exampleUser = new User { Id = 1, Name = "Adam", Created = DateTime.Now };
	log.Information("Created {@User} on {Created}", exampleUser, DateTime.Now);
}
