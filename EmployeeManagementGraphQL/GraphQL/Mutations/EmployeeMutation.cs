using EmployeeManagementGraphQL.Data.Models;
using EmployeeManagementGraphQL.Data.Repositories;
using EmployeeManagementGraphQL.GraphQL.Types;
using GraphQL;
using GraphQL.Types;

namespace EmployeeManagementGraphQL.GraphQL.Mutations
{
    // Class to define mutations for the Employee entity in the GraphQL schema
    public class EmployeeMutation : ObjectGraphType
    {
        // Constructor that sets up the mutation fields
        public EmployeeMutation(EmployeeRepository repository)
        {
            // Field for adding a new employee
            Field<EmployeeType>(
                "addEmployee",
                description: "Is used to add a new employee to the database",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<EmployeeInputType>> { Name = "employee", Description = "Employee input parameter." }
                ),
                resolve: context =>
                {
                    // Retrieve the employee argument from the context
                    var employee = context.GetArgument<Employee>("employee");
                    if (employee != null)
                    {
                        // Add the new employee using the repository
                        return repository.AddEmployee(employee);
                    }
                    return null;
                });

            // Field for updating an existing employee
            Field<EmployeeType>(
               "updateEmployee",
               description: "Is used to update an existing employee in the database",
               arguments: new QueryArguments(
                   new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id", Description = "ID of the employee that needs to be updated" },
                   new QueryArgument<NonNullGraphType<EmployeeInputType>> { Name = "employee", Description = "Employee input parameter." }
               ),
               resolve: context =>
               {
                   // Retrieve the ID and employee arguments from the context
                   var id = context.GetArgument<int>("id");
                   var employee = context.GetArgument<Employee>("employee");
                   if (employee != null)
                   {
                       // Update the employee using the repository
                       return repository.UpdateEmployee(id, employee);
                   }
                   return null;
               });

            // Field for deleting an existing employee
            Field<EmployeeType>(
              "deleteEmployee",
              description: "Is used to delete an existing employee from the database",
              arguments: new QueryArguments(
                  new QueryArgument<NonNullGraphType<IdGraphType>>
                  {
                      Name = "id",
                      Description = "ID of the employee that needs to be deleted"
                  }
              ),
              resolve: context =>
              {
                  // Retrieve the ID argument from the context
                  var id = context.GetArgument<int>("id");
                  // Delete the employee using the repository
                  repository.DeleteEmployee(id);
                  // Return true to indicate successful deletion
                  return true;
              });
        }
    }
}
