# challenge 28 :Movie Sort
## explanation
This code organizes movies, sorts them by title and year, and then outputs the sorted lists. It also contains a Movie class to define the movie structure and a Sorting class with methods for sorting movies. The CompareTitles method helps with title comparisons while ignoring common articles.
## whiteboard:


![Screenshot 2023-09-09 205242](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/6e7591c2-4b8a-4dcd-a008-eb83b519f553)

## Step by Step :

Walkthrough of the Code:

**List of Movies:**
This section initializes a list of Movie objects. Each movie has properties such as Title, Year, and Genres.

**Sorting and Output:**
Here, the Sorting class is used to sort the list of movies by year and title. The sorted lists are stored in `sortedByYear` and `sortedByTitle`, and then they are printed to the console.

**Output Formatting:**
This section prints the sorted movie lists to the console with proper formatting.

**Sorting Class:**
The Sorting class contains methods for sorting movies by name and year. It also has a helper method, `CompareTitles`, used for comparing movie titles.

**CompareTitles Method:**
The `CompareTitles` method compares two movie titles while ignoring common articles like "The," "A," and "An."

**SortByName Method:**
The `SortByName` method sorts a list of movies by their titles, using the `CompareTitles` method for comparisons.

**SortByYear Method:**
The `SortByYear` method sorts a list of movies by their release years.

**Movie Class:**
The `Movie` class defines the structure of a movie, including properties for Title, Year, and Genres.

**FirstPart Method:**
The `FirstPart` method checks if a given string is one of the common articles: "The," "A," or "An."


## Run Code:
![run](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/9acf2a7e-ebc8-4e3d-8b7e-3cbd360279fe)




## Test unit:


![test](https://github.com/bashar-27/Algo-And-DataStructure/assets/83985765/cf17b381-d55e-4de3-9973-8d68dfdadb4f)
