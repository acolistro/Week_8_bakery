# _Pierre's Fresh Out the Coven_

#### _C# Console App for a Bakery, March 2020_

#### By _**Alyssa Colistro**_

## Description

_Console application where a user can view a "menu" of a bakery, choose what breads and pastries they would like to order, and view the order and cost of the items they have chosen, including special pricing._

## Project Specifications

| Behavior | Input | Output |
|---|:---:|:---:|
|User can enter a string of breads they would like to order | French, Italian, Rye | "French, Italian, Rye" |
|User can enter a string of breads they would like to order | Croissant, Danish |  "Croissant, Danish"|
|Application returns the user-entered strings back to user as a list to review with estimated cost, taking into account special pricing. |  "French, Italian, Rye" | Bread: French; Bread: Italian; Bread: Rye; Cost of BREADS: $10.00; Total Order Cost: $10.00 |
|Application allows user to re-enter order if corrections are needed (is this correct (y/n))  | "n" | "Please enter the BREADS you would like:"|
|Application allows user to "confirm" their order (y/n), returning the order summary | "y" | "Your order: Breads: French, Italian, Rye; Total Cost: $10.00" |


## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/acolistro/Week_8_bakery.git ```
* Open file in your preferred text editor
* On Mac: ```open -a {your text editor} ```
* On Windows: ```Week_8_bakery```
* Navigate to main file directory and run ```dotnet build``` to build
* Once successfully built, run ```dotnet run``` to run program

_Download Manually:_

* Navigate to https://github.com/acolistro/Week_8_bakery.git.
* Click the green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder called "Week_8_bakery".


_Note For Editors:_ 
* Download the .NET Core SDK **VERSION 2.2.207** [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal

* Install dotnet script, run the ```$ dotnet tool install -g dotnet-script``` command in your terminal
* Restart your terminal to complete installation, and run the ```$ dotnet run``` command to run application within your terminal - Note: To exit, simply press ```Ctrl + C```
## Known Bugs

_This program will not build and run if the incorrect version of .NET is installed/used. Also, in it's current state, there is no input validation of user input._

## Support and contact details

_If you find a bug or have a solution to the current bugs I highly encourage you to contact me at arcolistro@gmail.com and/or submit a pull request to this repository. Please note that this application is not built to be compatible with web-accessibility tools or be viewed on any browser other than the current version of the Chrome browser._

## Technologies Used

* C#
* .Net Core
* VSCode

### License

*There are no licensed materials used in this app in its current state.*

Copyright (c) 2020 **_MallSoft95 LLC_**