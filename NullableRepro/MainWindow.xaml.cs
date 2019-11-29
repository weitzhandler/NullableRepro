using System;
using System.ComponentModel;
using ReactiveUI;



namespace WpfApp3
{
  public class Vm : IRoutableViewModel
  {
    public string UrlPathSegment { get; }
    public IScreen HostScreen { get; }

    public event PropertyChangedEventHandler PropertyChanged;
    public event PropertyChangingEventHandler PropertyChanging;

    public void RaisePropertyChanged(PropertyChangedEventArgs args) => throw new NotImplementedException();
    public void RaisePropertyChanging(PropertyChangingEventArgs args) => throw new NotImplementedException();
  }


  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : ReactiveWindow<Vm>
  {
    public MainWindow()
    {
      InitializeComponent();
    }
  }
}
