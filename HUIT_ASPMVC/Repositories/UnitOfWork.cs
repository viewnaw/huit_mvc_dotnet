using HUIT_ASPMVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HUIT_ASPMVC.Data
{
    public class UnitOfWork
    {
        public HUIT_DbContext _context;
        public UnitOfWork(HUIT_DbContext context)
        {
            _context = context;
        }

        private VaiTroRepo _vaiTroRepo;
        public VaiTroRepo VaiTroRepo
        {
            get
            {
                if (_vaiTroRepo == null)
                {
                    _vaiTroRepo = new VaiTroRepo();
                    _vaiTroRepo.Context = _context;
                }
                return _vaiTroRepo;
            }
        }
    }
}