﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HYWMS.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        SqlSugarScope GetDbClient();

        void BeginTran();

        void CommitTran();
        void RollbackTran();
    }
}
