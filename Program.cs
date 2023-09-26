class Car {

  public string Name { get; set; }
  public string Make { get; set; }
  public string Model { get; set; }
  public string NumSeats { get; set; }

  public Car() {
      // Code here
  }

  public Car(string make, string model, int numSeats) {
      Make = make;
      Model = model;
      NumSeats = numSeats;
  }

}

    
