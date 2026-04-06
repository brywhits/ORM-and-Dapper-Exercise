namespace ORM_Dapper;

public interface IDepartmentRepository
{
    //Stubbed out method for Interface
    public IEnumerable<Department> GetAllDepartments();
    
    public void InsertDepartment(string newDepartmentName);
}