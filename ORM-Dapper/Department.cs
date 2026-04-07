namespace ORM_Dapper;

public class Department
{
   
    public Department() //empty constructor
    {
    }
    
    //properties matching dB column names for mapping purposes
    public int DepartmentID  { get; set; }
    public string Name { get; set; }
}