A .Net CLI Tool to get weather update of a city

Please follow the below mentioned steps to run the Application as a .Net CLI tool:
===================================================================================

The application is done on .netcore 3.1

1. Open command prompt, and go to any location of your choice.
2. Run the below command: <br />
     C:\your path> git clone https://github.com/RajaChakraborty/WeatherUpdateDotNetCLITool1.git
     
3. After the project is downloaded, from the command prompt navigate to the project root directory.
4. Run the below command to build the project from the project root folder in the command prompt: <br/>
    C:\project root location>dotnet build
    
5. Run the below command from the project root folder in the command prompt, to make a CLI tool: <br/>
    C:\project root location>dotnet pack <br/>
    This will build a CLI tool in the folder named "nupkg" inside the project root folder.
    
6. In command prompt, run the below command to install the tool globally, from the project root directory: <br/>
    C:\project root location>dotnet tool install --global --add-source ./nupkg WeatherUpdate
    
7. Close the command prompt and reopen command prompt.
    
8. As the tool is installed globally in the system, go to any location in command prompt and run the application using the below command: <br/>
    C:\any location>weather <br/>
    
    Once you press 'enter', the application will ask to enter a city name to see weather details.
    
 9. To remove the installed tool, run the below command in the command prompt from any location: <br/>
    C:\any location>dotnet tool uninstall WeatherUpdate --global
