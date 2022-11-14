# 21stMortgageInterviewApplication
This is a sample project for my 21st Century Mortgage application

## The Assigment
Create a Windows Presentation Foundation application.
Create a Label named (User Input) and a Textbox to accept user input of comma separated
numbers. A textbox should show the result and it should be read-only.
Create a ViewModel with properties to bind to Textboxes.
Create three buttons, 'Find Largest value',  'Find total of Even Numbers, and 'Find total of Odd numbers'. Each of these buttons should update the result in the result textbox when it is clicked
Create a style for the Result textbox to show result in green if the sum or largest value is
positive or red (if negative) The font size should be 16 and font should be Arial.

I was given a wireframe image of a sample UI to match.

## My Choices
First off, this was going to be a C# application as that is what I am most familiar with.  Actually, I could have also used VB.NET, but I am showing my age enough as it is.

I used MS Visual Studio Community Edition to write the project.  **WE ARE MICROSOFT.  YOU WILL BE ASSIMILATED.  RESISTANCE IS FUTILE.**  

The application is built on .NET 6.

I added three Nuget packages to the project:  
- Microsoft.Toolkit.Mvvm

##  Where are my unit tests?
This is a VERY simple application, and has no classes other than the MainWindow and the ViewModel itself.  The test cases are few and can be run manually very quickly.  In addition, setting up MSTest would require exposing the calculation methods in the ViewModel which in actual practice could be a security risk.

## Compling and Running the Application
You should be able to open this solution in Visual Studio 2022 and compile "out of the box".  Everything is pure Microsoft.  If you are set to the "Release" configuration in Visual Studio or VS Code, then the binaries should be output to {SOLUTION_DIRECTORY}\SnappTest\bin\Release\net6.0-windows  Scoop everthing into a *.ZIP file.  You don't have to have the *.PDB file in there (it is for debugging)Unzip your archive in a directory on your target machine, double click on the _SnappTest.exe_ file in that target directory, and you should see the main window come up.

If this were a real contract, then someone other than myself would have paid for WixTools, this would be packaged into a self-installing SETUP.EXE.

I hope this meets your needs for assessing my skills, coding style, and problem solving approaches.

Matthew Snapp  
Matthew.Snapp@Outlook.com