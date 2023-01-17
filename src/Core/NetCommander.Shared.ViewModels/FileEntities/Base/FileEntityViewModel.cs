﻿using NetCommander.Shared.ViewModels.Core;

namespace NetCommander.Shared.ViewModels.FileEntities.Base;

public abstract class FileEntityViewModel : BaseViewModel
{
    public string Name { get; }

    public string FullName { get; set; }

    protected FileEntityViewModel(string name)
    {
        Name = name;
    }
}