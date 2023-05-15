# OOP Machine Class

This project demonstrates the implementation of object-oriented programming (OOP) concepts through the creation of a machine class hierarchy. The project includes the definition of a base `Machine` class and two subclasses: `Desktop` and `Laptop`. The classes showcase the principles of inheritance, method overriding, and polymorphism.

## Project Overview

The goal of this project is to design a machine class hierarchy that represents different types of machines, specifically desktops and laptops. Each machine has common properties such as CPU type, CPU speed, RAM capacity, and secondary drive capacity. The `Machine` class serves as the base class, containing these shared properties.

The `Desktop` class inherits from the `Machine` class and introduces additional properties such as desktop type, form factor, and secondary drive type. The `Laptop` class also inherits from `Machine` and includes properties like wifi card type and touchscreen availability.

To ensure flexibility and code reusability, the `GetDescription` method is defined as an abstract method in the `Machine` class. This allows each subclass (`Desktop` and `Laptop`) to override the method and provide a customized description of the specific machine.

The `Program` class serves as the driver class, demonstrating the usage of polymorphism. It creates instances of `Desktop` and `Laptop` objects, stores them in an array of `Machine` objects, and calls the `GetDescription` method on each object to obtain a description of the respective machine.

## Usage

To run the project and see the descriptions of the machines, follow these steps:

1. Clone the project repository to your local machine.
2. Open the solution file (`Lucas___MachineProject.sln`) in an integrated development environment (IDE) like Visual Studio.
3. Build the solution to ensure all dependencies are resolved.
4. Run the program by executing the `Program` class.

## Project Inspiration

This project was inspired by an analogy that explains OOP concepts using the Avatar movie. The analogy showcases the superclass as the "Being" and subclasses as "Human" and "Na'vi," which inherit common attributes but add their own unique values. The project extends this analogy to machines, where the `Machine` class represents the common attributes and the `Desktop` and `Laptop` classes represent specific machine types.

## Project Structure

The project structure is organized as follows:

- `Machine.cs`: Contains the definition of the `Machine` abstract base class.
- `Desktop.cs`: Defines the `Desktop` class, which inherits from `Machine`.
- `Laptop.cs`: Defines the `Laptop` class, which inherits from `Machine`.
- `Program.cs`: Serves as the entry point of the program, demonstrating the usage of the machine classes.

## Contributions

This project was developed by Tamires Lucas as a final project in OOP class. 



