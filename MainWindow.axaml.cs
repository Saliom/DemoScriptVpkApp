using System.Diagnostics;
using System.IO;
using Avalonia.Controls;

namespace DemoScriptVpkApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        var scriptPath = string.Format("\"{0}\"", Path.Combine(System.AppContext.BaseDirectory, "script.sh"));
        Process.Start("pkexec", $"{scriptPath}").WaitForExit();
    }
}