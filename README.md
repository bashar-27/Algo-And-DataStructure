# Challenge 12: stack-queue-animal-shelter

The Animal Shelter Management System is a console application designed to manage the intake, adoption, and count of dogs and cats in an animal shelter.
It provides functionality to enqueue animals, dequeue animals based on user preference, and display the current count of dogs and cats in the shelter.

<hr>
<h3>Whiteboard :</h3>

![Untitled - Frame 4](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/9c3f0e29-820d-4f8f-89e2-894e37c0eda8)


## Features

### Add Animals

The Enqueue method allows users to add dogs and cats to the shelter. Users can specify the species (either "dog" or "cat") and the name of the animal. The system will add the animal to the appropriate queue based on its species.

### Remove Animals

The Dequeue method enables users to remove animals for adoption from the shelter based on their preference. Users can provide the preferred species ("dog" or "cat"), and the system will dequeue and display the oldest animal of the specified species.

### Count and Display

The system provides methods to count and display the current number of dogs and cats in the shelter. The countDog method shows the number and names of dogs, while the countCat method displays the number and names of cats.

## Usage

1. Add Animals:
   - When prompted, add dogs and cats to the shelter by providing their species and names.
   - Example:
     ```
     Add Dogs
     The Number Of DOGS Is: 2
     1-Hasky
     2-pitBull
     
     Add Cats
     The Number Of CATS Is: 3
     1-shirazi
     2-siami
     3-Britch
     ```

Console Run Code: 

![Screenshot 2023-07-19 172247](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/0fc63d92-7923-4065-b985-14201cb5a2ae)

