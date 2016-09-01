my c# project.

this display the use of sql lite to save text on the device and I retreive the text back to frontend using linq

# I used sqlite database to store data on the device.
then I query the the data using ling and bind it on Gridviews, TextBlock and TextBox

the Database contains tables called Customer and Project.

# Customer table contains 
primary key int Id 
        string Name 
        string City
        string Contact
        

# And Project table contains
       Primary key int Id 
      Foreign Key int CustomerId { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime DueDate { get; set; }
        
    # So every each Customer there is a project. I used unique foreign key of the project table to add a new project for each customers.
    
        # To run the project
        in Manage NuGet Pakage install sqlite-net v1.0.8
        install SQLITE for windows Runtime(Windows 8.1)
        Then run the project using Solution platform x86.
        
