using ReactiveUI.Fody.Helpers;

namespace RabbitControl.ViewModels;

public class MainWindowViewModel : ViewModelBase {
    [Reactive] public bool IsAutoRefresh { get; set; }
    [Reactive] public int AutoRefreshFrequency { get; set; } = 10;
}