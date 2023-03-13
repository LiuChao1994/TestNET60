using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace TestNET60
{
    internal partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        public string title = "你好，世界！";

        partial void OnTitleChanged(string value)
        {
            
        }


        [RelayCommand]
        public void TestBtn()
        {
            MessageBox.Show("点击了按钮。。。。");

            Title = "修改了Title的值！";
        }


    }
}
