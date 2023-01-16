using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace NetCommander.Shared.ViewModels;

public class BaseViewModel : INotifyPropertyChanged
{
    #region Events

    public event PropertyChangedEventHandler? PropertyChanged;

    #endregion
        
    #region Protected Methods

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged( [CallerMemberName] string? propertyName = null )
    {
        PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
    }

    #endregion
}