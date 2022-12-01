# Application Name

PierresBakery.Solution

#### Brief Description

PierresBakery.Solution is a console application that accepts Bread and Pastry orders. After the user enters the number of loaves of bread and/or Pastries, the application will print out the order and total cost.

#### Contributor

By Bai Jaitrong

## Technologies Used
  * Visual Studio code 1.73.1
  * .NET 6 SDK
  * C# 10
  
## Description

The application will present the user with the following message:

                        WELCOME TO PIERRE'S BAKERY


                                    BREAD
                              Three Loaves: $10
                              Two Loaves: $10
                              Single Loaf: $5


                                   PASTRIES
                                  Six: $10
                                  Five: $9
                                  Four: $7
                                  Three: $5
                                  One: $2

It will then ask the user to enter how many Pastries and Loaves of bread they would like to order. afterwards, it will print out the order and the total price. It will automatically add a 3rd loaf of bread if the bread order is a multiple of twos and the user has forgotten about the special deal.

## Setup/Installation Requirements

  1. Create a repository in your GitHub account for this project by selecting the green New button on the upper left side of the screen and follow the instruction. The button is across from Recent Repositories. You will need the URL in step in step 7.

  2. Clone PierresBakery.Solution repository to your desktop or a subdirectory in your desktop by running the command: 
  
    git clone https://github.com/bjaitrong22/PierresBakery.Solution.git

    * Be careful not to clone the repository inside a local repository. Otherwise, you will have a nested git respository.

### Removing the original remote repository and adding your remote repository

  3. Navigate to the top level/root of the currency-exchanger directory using your command line.

  4. Run the following command to find the name of the remote repository attached to this project so that it can be removed before adding your remote repository:

    git remote -v

    bj	https://github.com/bjaitrong22/currency-exchanger.git (fetch)
    bj	https://github.com/bjaitrong22/currency-exchanger.git (push)

    * you will get a response above, and the remote repository's nick name/identifier is bj or you may see it as origin.

 5. Enter the command: 
 
    git remote rm origin 
    
    If the identifier is origin. Replace origin if the identifier is something else. So if the identifier is bj, you would enter git remote rm bj. 
      
6. Confirm that the prior remote repository has been removed by running the command below:

    git remote -v  
      
    * Nothing should show up. That means the remote has been removed. If it hasn't been removed correctly, return to step 4. & 5. 
      
7. Enter 

    git remote add origin [your-project-url-here]. 
      
    * You can use an identifier other than origin. Copy the URL from your GitHub project repository by clicking the green CODE drop down menu on your GitHub repository and put it at the end of the command above.
      
8. You can confirm that the new remote is correctly linked by running the command: 

    git remote -v

### Pushing .gitignore file from the clone PierresBakery.Solution
    
9. Before pushing any changes to your remote repository,run the command 

    git add .gitignore 
    git commit -m "Add .gitignore file."
    git push [your-remote-Identifier] main
    
  This will let GitHub know what files not to upload to GitHub from your local repository.

### You are now ready to work on the project

10. Open the project using your text editor of your choosing.

12. Interacting with PierresBakery test cases:

    * Navigate to the subdirectroy PierresBakery.Solution/PierresBakery.Tests using your command line.
    * To install the required packages listed in PierresBakery.Tests.csproj file, run the command "dotnet restore".
     
    note: the command will automtically create new obj directories in the PierresBakery and PierresBakery.Tests subdirectories. Do not touch these files. If they are deleted by accident or updates are made to one of .csproj files or both , you can follow step 12 and run the "dotnet restore" again to restore the files or apply the updates form the .csproj file.  

    Also, leave out the quotes when running the terminal commands. The quotes are just for emphasis.

    * You can now run the test that has already been put in place by running the command "dotnet test" in the subdirectory PierresBakery.Solution/PierresBakery.Tests. 
  
11. To build and run the project using MSBuild:

     * Navigate to the subdirectroy PierresBakery.Solution/PierresBakery using your command line.
     * First, run the command "dotnet build".
     * Afterwards,run the command "dotnet run".
    
## Known Bugs

  * No known bugs

# License
 * Portfolio is licensed under the terms of GNU AFFERO GENERAL PUBLIC LICENS Version 3, 19 November 2007 ( change if you are using a different license)


 