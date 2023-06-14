using System.Collections.ObjectModel;

namespace testLb.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public ObservableCollection<DViewModel> DViewModels { get; set; }

        public MainWindowViewModel()
        {
            DViewModels =  new ObservableCollection<DViewModel>();

            DViewModels.Add(new DViewModel { Name = "One" });
            DViewModels.Add(new DViewModel { Name = "Two" });
        }
    }
}