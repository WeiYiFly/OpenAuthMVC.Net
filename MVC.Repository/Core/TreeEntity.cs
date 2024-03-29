﻿using MVC.Repository.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Repository.Core
{
    /// <summary>
    /// 树状结构实体
    /// </summary>
    public abstract class TreeEntity : Entity
    {
        /// <summary>
        /// 父节点名称
        /// </summary>
        public string ParentId { get; set; }
        /// <summary>
        /// 父节点名称
        /// </summary>
        public string ParentName { get; set; }

        /// <summary>
        /// 节点语义ID
        /// </summary>
        public string CascadeId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
    }
}
