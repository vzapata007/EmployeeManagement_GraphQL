using EmployeeManagementGraphQL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementGraphQL.Data.Repositories
{
    // Class to handle CRUD operations for the Employee entity
    public class EmployeeRepository
    {
        // Database context to access the entities
        private readonly EntityDatabaseContext _context;

        // Constructor that receives the database context
        public EmployeeRepository(EntityDatabaseContext context)
        {
            _context = context;
        }

        // Method to get all employees, including their reviews
        public List<Employee> GetAllEmployees()
        {
            // Include the Reviews entity in the query to load the related reviews for each employee
            return _context.EmployeeEntity.Include(f => f.Reviews).ToList();
        }

        // Method to get an employee by their ID, including their reviews
        public Employee? GetEmployeeById(int id)
        {
            // Find the employee by ID and include their reviews in the query
            return _context.EmployeeEntity.Include(f => f.Reviews).Where(d => d.Id == id).FirstOrDefault();
        }

        // Method to add a new employee to the database
        public Employee AddEmployee(Employee employee)
        {
            // Add the employee to the EmployeeEntity set
            _context.EmployeeEntity.Add(employee);
            // Save the changes to the database
            _context.SaveChanges();
            return employee;
        }

        // Method to update an existing employee in the database
        public Employee? UpdateEmployee(int id, Employee employee)
        {
            // Find the employee by ID
            var _employee = _context.EmployeeEntity.Where(d => d.Id == id).FirstOrDefault();
            if (_employee != null)
            {
                // Update the employee's fields with the new values
                _employee.Email = employee.Email;
                _employee.FirstName = employee.FirstName;
                _employee.LastName = employee.LastName;
                // Save the changes to the database
                _context.SaveChanges();
            }
            return _employee;
        }

        // Method to delete an employee from the database by their ID
        public void DeleteEmployee(int id)
        {
            // Find the employee by ID
            var _employee = _context.EmployeeEntity.Where(d => d.Id == id).FirstOrDefault();
            if (_employee != null)
            {
                // Remove the employee from the EmployeeEntity set
                _context.EmployeeEntity.Remove(_employee);
                // Save the changes to the database
                _context.SaveChanges();
            }
        }
    }
}
