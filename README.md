# Objects
Objects are instances of a class. 

An object can be created from a normal class (not an abstract class) by triggering a constructor call.

A constructor is the means by which a class can create an instance of itself.

A class can have no constructors (abstract), one or several constructors.

A constructor should have the same name as the class in which it is created.
e.g.
public class Car
{
  public Car()
  {}
}

A class can have many constructors but each constructor must be differentiated from the other by its signature i.e. the parameters it accepts
This signature must differ in terms of the parameter:
- **order** i.e. sequence of parameter types
- **type of paramater** i.e. string, int etc
- **number of parameters**

e.g.
public class Car
{
  public Car()
  {  }

  public Car(string make, string model, int numSeats)
  { }
}

A object of a class can be defined by it's **Instance Variables** (attributes) or **Properties**. These are mutually exclusive and should not co-exist in the same class.

Properties are much easier to maintain and are much more efficient than instance variables. The following example demonstrates attributes stored as both instance variables and properties in the same class. Not the capital first letter of the property to dsinguish it from the instance variable of the same name. 

//These are instance variables which means if i create an object of the class dog, each dog object will automatically have access to these instance variables
private string name;
private string breed;

//The following are property equivalents to each instance variable of the same name
//Please note you should only use one or the other never both 
//The properties have been capitalised to distinguish between variables of the same name
//The notation for Properties is much simpler to use than getter/setter  methods
public string Name
{
    get;
    set;
}

public string Breed
{
    get;
    set;

}
