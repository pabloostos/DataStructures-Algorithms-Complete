// We create a class for storing data of a car
internal class Car 
{
    public string Brand = "Porsche";
    public string NumberPlate = "1825XYZ"; 
    public int YearBuilt = 1937; 
    public string Location = "Madrid"; 
    public bool SetLocation(string newLocation){
        if (newLocation == "Sevilla" || newLocation == "Madrid" || newLocation == "Valencia"){
            Location = newLocation;
            return true;
        }
        else {
            return false;
        }
    }
    public void WriteConsole(){
        Console.WriteLine("This is the information for the car: " + "Brand: " + Brand + " Location: " + Location +" NumberPlate: " + NumberPlate);
    }

    public int GetYearBuilt(){
        return YearBuilt;
    }
}