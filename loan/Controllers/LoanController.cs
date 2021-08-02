using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
//using System.Web.Http.Cors;

namespace loan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllHeaders")]
    public class LoanController : ControllerBase
    {

        // POST: api/Loan
        [HttpPost]
        public string Post(Loan loanData)
        { String status = "approved";
            return status;
        }
    }
}
