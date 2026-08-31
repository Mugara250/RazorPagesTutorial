namespace BlazorServerTutorial.Services;

public class ClientPreferencesService
{
    public bool ShowActiveOnly { get; set; } = false;
    public event Action? OnStateChanged;
    public void SetShowActiveOnly(bool showActive)
    {
        ShowActiveOnly = showActive;
        OnStateChanged?.Invoke();
    }
}