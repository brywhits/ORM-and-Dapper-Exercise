namespace ORM_Dapper;

public interface IDepartmentRepository // template for behavior; contract
{
    //Stubbed out method for Interface
    IEnumerable<Department> GetAllDepartments();
    
    void InsertDepartment(string newDepartmentName);
}