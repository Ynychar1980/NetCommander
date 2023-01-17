using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using JetBrains.Annotations;
using NetCommander.Shared.ViewModels.Commands;
using NetCommander.Shared.ViewModels.Core;
using NetCommander.Shared.ViewModels.FileEntities;
using NetCommander.Shared.ViewModels.FileEntities.Base;

namespace NetCommander.Shared.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region public Property

        public string FilePath { get; set; }

        public ObservableCollection<FileEntityViewModel> DirectoryAndFiles { get; set; } = new ObservableCollection<FileEntityViewModel>();

        public FileEntityViewModel SelectedFileEntity { get; set; }

        #endregion

        #region Commands

        public ICommand OpenCommand { get; }

        #endregion

        #region Events



        #endregion

        #region Constructor
        public MainViewModel()
        {
            OpenCommand = new DelegateCommand(Open);

            foreach (var logicalDrive in Directory.GetLogicalDrives())
            {
                DirectoryAndFiles.Add(new DirectoryViewModel(logicalDrive));
            }

            
        }
        #endregion

        #region Protected Methods



        #endregion

        #region Commands Methods

        private void Open(object parameter)
        {
            if (parameter is DirectoryViewModel directoryViewModel)
            {
                FilePath = directoryViewModel.FullName;

                DirectoryAndFiles.Clear();

                var directoryInfo = new DirectoryInfo(FilePath);

                foreach (var directory in directoryInfo.GetDirectories())
                {
                    DirectoryAndFiles.Add(new DirectoryViewModel(directory));
                }

                foreach ( var fileInfo in directoryInfo.GetFiles() )
                {
                    DirectoryAndFiles.Add( new FileViewModel(fileInfo));
                }
            }
        }

        #endregion

    }
}