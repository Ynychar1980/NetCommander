using NetCommander.Shared.ViewModels.FileEntities.Base;

namespace NetCommander.Shared.ViewModels.FileEntities;

public sealed class DirectoryViewModel : FileEntityViewModel
{
    public DirectoryViewModel(string directoryName) : base(directoryName)
    {
        FullName = directoryName;
    }

    public DirectoryViewModel(DirectoryInfo directoryName) : base(directoryName.Name)
    {
        FullName = directoryName.FullName;
    }
}