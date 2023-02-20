using CQRS_Employee.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Employee.Queries
{
   public record getAllEmployeeQuery: IRequest<List<TEmployee>>;
    
}
