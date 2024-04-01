Demo Avalonia C# app showcasing issue with running pkexec scripts after packaging with Velopack.

Steps to reproduce:
1. Clone the repository
2. Publish the project with msbuild: ```dotnet publish -c Release --self-contained -r linux-x64 -o ./publish```
3. Package the publish folder with velopack: ```vpk pack -u DemoScriptVpkApp -v 1.0.0 -o ./release -p ./publish```
4. Run DemoScriptVpkApp.AppImage from the terminal
