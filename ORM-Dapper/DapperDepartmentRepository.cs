using System.Data;
using Dapper;

namespace ORM_Dapper;

public class DapperDepartmentRepository : IDepartmentRepository
{
    //It is a variable declared directly inside a class, but outside any method or constructor
    //Private field with underscore to designate that it's private
    //Benefit of readonly is that you can't inadvertently change it from another part of the DeptRepo after it's initialized 
    //Otherwise, we cac only give _connection a value at the time of instantiation of DeptRepo
    private readonly IDbConnection _connection;

    // Constructor
    public DapperDepartmentRepository(IDbConnection connection)
    {
        _connection = connection;
    }

    public IEnumerable<Department> GetAllDepartments()
    {
        return _connection.Query<Department>("SELECT * FROM Departments;");
    }

    public void InsertDepartment(string newDepartmentName)
    {
        _connection.Execute("INSERT INTO DEPARTMENTS (NAME) VALUES (@departmentName);",
            new { departmentName = newDepartmentName });
    }
}