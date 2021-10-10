# Hair Salon
#### by Amerik Velasquez
#### Hair Salon
## technology used

* C#
* MySQL
* EntityCore Framework




## Description
A C# application that allows Eau Clair to see all of her stylists and clients associated with her hair salon.

## Setup
1. Download .NET 5.0 SDK for Windows:https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.102-windows-x64-installer

1. Download .NET 5.0 SDK for Mac: https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.100-macos-x64-installer

2. clone the repository by entering this in the command line : `git clone https://github.com/AmerikVelasquez/HairSalon` 
3. open the repository in editor 
4. import amerik_velasquez.sql database into MySql by folling these steps 
5. open MySql Workbench 
6. Select MySql intance in the middle under MySqlConnections
7. select Navigator>Administration then select DataImport/Restore 
8. select Import from Self- contained File 
9. click the 3 dots at the end of Self-Contained file and in the pop up choose the amerik_velasquez.sql file
10. In the Default Schema to be Imported to section select new and a pop up will appear name the schema amerik_velasquez 
11. Click start import within the import progress if on windows, if on mac it will be in the same window
12. once complete refresh all and it will appear
## Setup for appsettings.json
1. in your terminal cd into the file HairSalon
2. type in `touch appsettings.json` 
3. input the following code below where it says password means the password for MySql workbench that you have set up and uid is the user id you've set up in MySql workbench
4. 
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=amerik_velasquez;uid=[userid];pwd=[Password];"
  }
}
```  

5. after that is complete to run the application cd into HairSalon and imput `dotnet run` in your terminal 
6. when it finishes you should see `Now listenin on: http://localhost:5000 ` CTRL click that and view the application in the browser
## Known Bugs
no known bugs
## License
This is under the GNU GPLv3
## Contact Information
Amerik Velasquez : amerik.velasquez22@gmail.com