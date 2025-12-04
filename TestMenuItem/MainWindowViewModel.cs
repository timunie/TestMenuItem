using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TestMenuItem.Model;

namespace TestMenuItem;

public partial class MainWindowViewModel : ObservableObject
{
    public MainWindowViewModel()
    {
        
    }
    
    /// <summary>
    /// 语言列表
    /// </summary>
    public ObservableCollection<ItemModel> Languages { get; } =
    [
        new ItemModel()
        {
            Id = 1,
            Name = "English",
        },

        new ItemModel()
        {
            Id = 2,
            Name = "简体中文",
        }
    ];
    
    [RelayCommand]
    private void LanguageChanged(ItemModel  item)
    {
    }
}