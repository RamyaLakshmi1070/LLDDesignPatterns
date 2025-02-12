LLD - Strategy Pattern vs Inheritance 🚀
This project demonstrates two approaches to implementing vehicle behaviors:

Without Strategy Pattern (Inheritance-Based Approach)
With Strategy Pattern (Flexible & Scalable Approach)
📌 Problem with Inheritance Approach
In the Inheritance-Based Approach, each vehicle type (SportyVehicle, PassengerVehicle, NormalVehicle) overrides the Drive() method. This leads to:

  Code duplication if multiple classes share the same logic.
  Tightly coupled code making modifications harder.
  Violation of the Open/Closed Principle – new behaviors require modifying existing classes.
  
✅ Strategy Pattern Solution
The Strategy Pattern resolves these issues by:

  Encapsulating driving behaviors in separate classes (FastDrive, NormalDrive).
  Using composition instead of inheritance – Vehicle has a DriveStrategy.
  Enabling dynamic behavior changes at runtime.
  
📂 Project Structure

/lld_demo
│── /InheritanceApproach        # Without Strategy Pattern
│   │── Vehicle.cs
│   │── SportyVehicle.cs
│   │── PassengerVehicle.cs
│   │── NormalVehicle.cs
│   │── Program.cs
│
│── /StrategyPatternDemo        # With Strategy Pattern
│   │── IDriveStrategy.cs
│   │── SpecialDrive.cs
│   │── NormalDrive.cs
│   │── Vehicle.cs
│   │── SportyVehicle.cs
│   │── PassengerVehicle.cs
│   │── NormalVehicle.cs
│   │── Program.cs
│
│── README.md
