# SWE201_235060006
This project demonstrates a film and series tracking system using a custom C# class.
The purpose is to create Media objects, manage their properties safely, and display their details consistently.

The Media class contains three main member variables: title, type, and releaseYear.
These are private to enforce encapsulation, so they cannot be directly modified from outside the class.

Properties provide controlled access to these variables, allowing safe reading and writing of values.
For example, if you wanted to validate the release year or restrict the type to “Film” or “Dizi”, you could do it in the property definitions without changing other parts of the code.

The class has two constructors. The default constructor allows creating a Media object without initial values, giving flexibility when the details are not immediately available.
The parameterized constructor allows initializing all properties at the time of object creation, making the object ready to use instantly.

The class includes a member function to get a formatted string describing the media object.
This method provides a consistent way to display information such as the title, release year, and type.
Additionally, the ToString() function is overridden to allow easy printing of the object directly, which demonstrates object-oriented principles like encapsulation and code reuse.

In the Main function, objects can be created using either constructor.
Default constructor objects can have their properties set later, while parameterized constructor objects are initialized immediately.
Displaying the objects through the member function or ToString() demonstrates how constructors, properties, and methods work together to manage object state effectively.


Code Reuse: Display logic is implemented in methods so it can be reused anywhere.

Flexible Object Creation: Both default and parameterized constructors allow safe and convenient creation of objects.
