# WordSearch
Word Search Repo 
These instruction are to build the WordSearch app outside of the environment. But you can also build it using visual studio 2017 and run the dotnet command to execute the app.

Here the instruction to build and deploy and the WordSearch application.

Open command window and cd to the WordSearchConsole.proj locate it should be in the directory
 cd (your path)\WordSearch\WordSearchConsole
 example:
 cd \user\blass\source\repos\WordSearch\WordSearchConsole
 
 run command dotnet build -o (where you want the files located)
 example:
 dotnet build -o c:/junk/test
 
 To execute the program run command dotnet (path where you put your files) (file the contains the word search data)
 example:
 dotnet c:\junk\test\WordSearchConsole.dll c:\WordSearchText.csv
 
 Output should be in the command windows.
 
 
 The code could be inmproved by using dependecy inject or factorys. Also there could be a better breakdown of responsiblity and reduce of duplicate code. But I have worked to many long nights on this and am tire.
 
 Thank you for the opportunity and I did have fun. I also learn alot about unit tests and TTD.
 
 Bill Blasses
