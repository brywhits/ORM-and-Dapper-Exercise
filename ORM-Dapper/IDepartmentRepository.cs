namespace ORM_Dapper;

public interface IDepartmentRepository // template for behavior; contract
{
    //Stubbed out method for Interface ecause it has no scope or parameter
    IEnumerable<Department> GetAllDepartments();
    
    void InsertDepartment(string newDepartmentName);
}