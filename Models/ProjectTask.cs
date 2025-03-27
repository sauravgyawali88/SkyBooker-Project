using System.Text.Json.Serialization;

namespace SkyBooker_Project.Models;

public class ProjectTask
{
	public int ID { get; set; }
	public string Title { get; set; } = string.Empty;
	public bool IsCompleted { get; set; }

	[JsonIgnore]
	public int ProjectID { get; set; }
}