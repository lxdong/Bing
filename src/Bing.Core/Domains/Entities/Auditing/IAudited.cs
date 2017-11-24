﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Domains.Entities.Auditing
{
    /// <summary>
    /// 操作审计
    /// </summary>
    public interface IAudited : ICreationAudited, IModificationAudited
    {
    }

    /// <summary>
    /// 操作审计
    /// </summary>
    /// <typeparam name="TKey">操作人编号类型</typeparam>
    public interface IAudited<TKey> : ICreationAudited<TKey>, IModificationAudited<TKey>
    {

    }
}
