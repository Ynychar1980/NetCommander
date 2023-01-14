using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace NetCommander.Shared.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region public Property
        public string MainDiskName { get; set; }
        #endregion

        #region Events

        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion

        #region Constructor
        public MainViewModel()
        {
            MainDiskName = Environment.SystemDirectory;
        }
        #endregion

        #region Protected Methods

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged( [CallerMemberName] string? propertyName = null )
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
        }

        #endregion

        

        
        
    }
}