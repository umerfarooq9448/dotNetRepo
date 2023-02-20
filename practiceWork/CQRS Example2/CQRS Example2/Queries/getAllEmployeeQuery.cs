using CQRS_Example2.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Example2.Queries
{
   public record getAllEmployeeQuery: IRequest<List<TEmployee>>;
    
}
