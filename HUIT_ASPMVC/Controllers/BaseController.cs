using HUIT_ASPMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HUIT_ASPMVC.Controllers
{
    public class BaseController : Controller
    {
        public UnitOfWork unitOfWork = new UnitOfWork(new HUIT_DbContext());
       

    }
}