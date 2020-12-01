using System;

class Faculty : Person
{
  private string id;
  private string title;
  private DateTime dateOfEmployment;
  private string employer;
  private double yearlySalary;
  private bool tenured;

  public Faculty() : base() {
    this.title = "Instructor";
  }

  public Faculty(string first, string last) : base(first, last) {
    this.title = "Instructor";
  }

  public Faculty() {

  }

  public void GrantTenure() {
    if (DateTime.Today.Year - dateOfEmployment.Year >= 5 ) {
      this.tenured = true;
      return;
    }

    this.tenured = false;
  }

  public void Promote() {
    if (this.title = "Instructor" && DateTime.Today.Year - dateOfEmployment.Year > 2) {
      this.title = "Assistant Professor";
      Console.WriteLine("Faculty promoted to Assistant Professor.");
      return;
    }
    if (this.title = "Assistant Professor" && DateTime.Today.Year - dateOfEmployment.Year > 5) {
      this.title = "Associate Professor";
      Console.WriteLine("Faculty promoted to Associate Professor.");
      return;
    }
    if (this.title = "Associate Professor" && DateTime.Today.Year - dateOfEmployment.Year > 10) {
      this.title = "Professor";
      Console.WriteLine("Faculty promoted to Professor.");
      return;
    }
    if (this.title = "Professor") {
      Console.WriteLine("No more promotion possible.");
      return;
    }

    public override Intro() {
      Console.WriteLine("Title: " + title);
      Console.WriteLine("Year of Employment: " + dateOfEmployment.Year);
    }
  }


}