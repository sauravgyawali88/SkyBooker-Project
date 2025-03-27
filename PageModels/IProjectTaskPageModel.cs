using CommunityToolkit.Mvvm.Input;
using SkyBooker_Project.Models;

namespace SkyBooker_Project.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}