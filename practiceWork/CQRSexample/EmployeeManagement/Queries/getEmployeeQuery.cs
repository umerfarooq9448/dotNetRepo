using EmployeeManagement.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Queries
{
    public class getEmployeeQuery:IRequest<List<TEmployees>>
    {

    }
}
