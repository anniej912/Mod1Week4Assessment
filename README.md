# Mod1 Week4 Assessment
This assessment has two parts - some questions about this week's lessons, and an exercise focused on our Testing lesson. Work on the Questions first, then move on to the Exercise!

During this assessment, you may use most other resource besides your fellow students.  Feel free to google, look back at your notes, lessons, labs, etc... **you may not use Chat GPT or any other AI tool**

## Set Up

Fork this repository! (Don't clone it yet!!)

## Questions (12 Points Possible)
Edit this `README.md` file - answer the 6 questions before moving on to the exercise.  Make sure to save your changes to the README before moving on to the exercises!

To Edit the README:
* click the pencil icon in the upper right corner.
* make changes in the text editor.
* save your changes by clicking 'Commit Changes'
    * on the confirmation screen, click 'Commit Changes'
 
</br>
</br>

1. Review the class definition below:
    ```c#
    public class Chair
    {
        public int Height { get; }
        public bool HasBack { get; }

        public Chair(int height, bool hasBack)
        {
            Height = height;
            HasBack = hasBack;
        }
    }
    ```
    Which of the following is NOT a valid way to create an instance of Chair? And why does this option not work?  
    A. `var bench = new Chair(24, true);`  
    B. `Chair bench = new Chair(24, true);`  
    C. `var bench = new(24, true);`  
    D. `Chair bench = new(24, true);`  

    My Answer: C is invalid because the var doesn't implicitly give the Chair type to 'bench' so the bench could represent "anything" at this point.
    
2. Imagine you are interviewing for your first job.  The interviewer asks "What can you tell me about OOP?".  Write your response below:
      Object Oriented Programming uses classes to better organize a code and store reusable methods. This makes your code easier to read and reuse not only for you, but other coders as well.

3. What is Automated Testing?
      Automated Testing is a seperate project written along with your main code that tests for expected outcomes of methods built in your main code.

4. What are some benefits of creating tests for our projects?
      Creating automated tests for our projects allows easy testing as our projects grow. If someone were to add to or change a spefic class in the program later on, you could simply go to the test to make sure it didn't become broken. It becomes more helpful as the project gets larger.

6. When you create a test project, you do not immediately have access to the class(es) in the project that you are testing.  What do you need to do in order to have access to those classes?
      You need to right click on the file for the test project, place your mouse over the Add option and from there click on Project Reference... A window will pop open with file options. You check the box of the options that contain the class(es) you are running tests on and click 'Ok.' This should now allow you to test methods from those classes.
7. Take a look at the class below.  Write out the **names** of each test you would write to verify that this class is working. You do not need to write the whole test, just what you would **name** the test methods. Ex: `IsCreatedWithTwoArguments()`
```c#
    public class Vehicle
    {
        public int NumberOfWheels { get; }
        public string Color { get; private set;  }
        public int MilesDriven { get; private set; }

        public Vehicle(int numberOfWheels, string color)
        {
            NumberOfWheels = numberOfWheels;
            Color = color;
            MilesDriven = 0;
        }

        public string Summary()
        {
            string summary = $"This {Color} vehicle has {NumberOfWheels} wheels, and has driven {MilesDriven} miles.";
            return summary;
        }

        public void Drive()
        {
            MilesDriven += 5;
        }

        public void Paint(string newColor)
        {
            Color = newColor;
        }
    }
```
      
      - Vehichle() = CreatesNewVehicle_WithTwoArguments
      - Summary() = ReturnsSummaryOfVehicle
      - Drive() = AddsMilesDriven_ToVehicle
      - Paint() = UpdatesPaintColorOfVehicle

## Exercise (8 Points Possible)
In Visual Studio, clone your forked repository.  
In this solution, there is a `Vehicle` project and a `Vehicle.UnitTests` project.  The class in `Vehicle.cs` is complete, but the tests for that class are not yet finished.  Add tests to the `VehicleTests.cs` file so that all the methods and properties for the `Vehicle` class have tests.  When finished, there should be a minimum of 4 tests (one is already completed for you!).

### Submission

When the assessment is due, your instructors will show you how to commit the code you worked on in Visual Studio and push it up to GitHub :) 

### Rubric

This assessment has a total of **20 Points**.  Earning **10 or more** points is a **pass** and will indicate that you are progressing well with the material.

As a reminder, this assessment is for students and instructors to determine if there are any areas that need additional reinforcement!
