using Employee_Cqrs_CL.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Cqrs_CL.Queries
{
    public class getEmployeeQuery:IRequest<List<TEmployees>>
    {

    }
}
