﻿using System;


namespace MVC.Repository.Domain
{
    /// <summary>
    /// 工作流实例流转历史记录
    /// </summary>
    public partial class FlowInstanceTransitionHistory : Entity
    {
        public FlowInstanceTransitionHistory()
        {
            this.InstanceId = string.Empty;
            this.FromNodeId = string.Empty;
            this.FromNodeName = string.Empty;
            this.ToNodeId = string.Empty;
            this.ToNodeName = string.Empty;
            this.TransitionSate = 0;
            this.IsFinish = 0;
            this.CreateDate = DateTime.Now;
            this.CreateUserId = string.Empty;
            this.CreateUserName = string.Empty;
        }

        /// <summary>
	    /// 实例Id
	    /// </summary>
        public string InstanceId { get; set; }
        /// <summary>
	    /// 开始节点Id
	    /// </summary>
        public string FromNodeId { get; set; }
        /// <summary>
	    /// 开始节点类型
	    /// </summary>
        public int? FromNodeType { get; set; }
        /// <summary>
	    /// 开始节点名称
	    /// </summary>
        public string FromNodeName { get; set; }
        /// <summary>
	    /// 结束节点Id
	    /// </summary>
        public string ToNodeId { get; set; }
        /// <summary>
	    /// 结束节点类型
	    /// </summary>
        public int? ToNodeType { get; set; }
        /// <summary>
	    /// 结束节点名称
	    /// </summary>
        public string ToNodeName { get; set; }
        /// <summary>
	    /// 转化状态
	    /// </summary>
        public int TransitionSate { get; set; }
        /// <summary>
	    /// 是否结束
	    /// </summary>
        public int IsFinish { get; set; }
        /// <summary>
	    /// 转化时间
	    /// </summary>
        public System.DateTime CreateDate { get; set; }
        /// <summary>
	    /// 操作人Id
	    /// </summary>
        public string CreateUserId { get; set; }
        /// <summary>
	    /// 操作人名称
	    /// </summary>
        public string CreateUserName { get; set; }

    }
}
