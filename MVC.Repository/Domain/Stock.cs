﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Repository.Domain
{
    /// <summary>
    /// 出入库信息表
    /// </summary>
    public partial class Stock : Entity
    {
        public Stock()
        {
            this.Name = string.Empty;
            this.Number = 0;
            this.Price = 0;
            this.Status = 0;
            this.Viewable = string.Empty;
            this.User = string.Empty;
            this.Time = DateTime.Now;
            this.OrgId = string.Empty;
        }

        /// <summary>
	    /// 产品名称
	    /// </summary>
        public string Name { get; set; }
        /// <summary>
	    /// 产品数量
	    /// </summary>
        public int Number { get; set; }
        /// <summary>
	    /// 产品单价
	    /// </summary>
        public decimal Price { get; set; }
        /// <summary>
	    /// 出库/入库
	    /// </summary>
        public int Status { get; set; }
        /// <summary>
	    /// 可见范围
	    /// </summary>
        public string Viewable { get; set; }
        /// <summary>
	    /// 操作人
	    /// </summary>
        public string User { get; set; }
        /// <summary>
	    /// 操作时间
	    /// </summary>
        public System.DateTime Time { get; set; }
        /// <summary>
	    /// 组织ID
	    /// </summary>
        public string OrgId { get; set; }

    }
}
