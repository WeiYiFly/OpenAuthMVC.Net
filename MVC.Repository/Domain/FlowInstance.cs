﻿using System;

namespace MVC.Repository.Domain
{
    /// <summary>
    /// 工作流流程实例表
    /// </summary>
    public partial class FlowInstance : Entity
    {
        public FlowInstance()
        {
            this.InstanceSchemeId = string.Empty;
            this.Code = string.Empty;
            this.CustomName = string.Empty;
            this.ActivityId = string.Empty;
            this.ActivityName = string.Empty;
            this.PreviousId = string.Empty;
            this.SchemeContent = string.Empty;
            this.SchemeId = string.Empty;
            this.DbName = string.Empty;
            this.FrmType = 0;
            this.FrmData = string.Empty;
            this.FrmContentData = string.Empty;
            this.FrmContentParse = string.Empty;
            this.FrmId = string.Empty;
            this.SchemeType = string.Empty;
            this.Disabled = 0;
            this.CreateDate = DateTime.Now;
            this.CreateUserId = string.Empty;
            this.CreateUserName = string.Empty;
            this.FlowLevel = 0;
            this.Description = string.Empty;
            this.IsFinish = 0;
            this.MakerList = string.Empty;
        }

        /// <summary>
	    /// 流程实例模板Id
	    /// </summary>
        public string InstanceSchemeId { get; set; }
        /// <summary>
	    /// 实例编号
	    /// </summary>
        public string Code { get; set; }
        /// <summary>
	    /// 自定义名称
	    /// </summary>
        public string CustomName { get; set; }
        /// <summary>
	    /// 当前节点ID
	    /// </summary>
        public string ActivityId { get; set; }
        /// <summary>
	    /// 当前节点类型 -1无法运行,0会签开始,1会签结束,2一般节点,4流程运行结束
	    /// </summary>
        public int? ActivityType { get; set; }
        /// <summary>
	    /// 当前节点名称
	    /// </summary>
        public string ActivityName { get; set; }
        /// <summary>
	    /// 前一个ID
	    /// </summary>
        public string PreviousId { get; set; }
        /// <summary>
	    /// 流程模板内容
	    /// </summary>
        public string SchemeContent { get; set; }
        /// <summary>
	    /// 流程模板ID
	    /// </summary>
        public string SchemeId { get; set; }
        /// <summary>
	    /// 数据库名称
	    /// </summary>
        public string DbName { get; set; }
        /// <summary>
	    /// 表单类型
	    /// </summary>
        public int FrmType { get; set; }
        /// <summary>
	    /// 表单中的字段数据
	    /// </summary>
        public string FrmContentData { get; set; }
        /// <summary>
	    /// 表单内容
	    /// </summary>
        public string FrmContentParse { get; set; }
        /// <summary>
	    /// 表单ID
	    /// </summary>
        public string FrmId { get; set; }
        /// <summary>
	    /// 流程类型
	    /// </summary>
        public string SchemeType { get; set; }
        /// <summary>
	    /// 有效标志
	    /// </summary>
        public int Disabled { get; set; }
        /// <summary>
	    /// 创建时间
	    /// </summary>
        public System.DateTime CreateDate { get; set; }
        /// <summary>
	    /// 创建用户主键
	    /// </summary>
        public string CreateUserId { get; set; }
        /// <summary>
	    /// 创建用户
	    /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
	    /// 等级
	    /// </summary>
        public int FlowLevel { get; set; }
        /// <summary>
	    /// 实例备注
	    /// </summary>
        public string Description { get; set; }
        /// <summary>
	    /// 是否完成 0未完成，1完成并同意，2被召回，3完成但不同意， 4被驳回需要重新提交
	    /// </summary>
        public int IsFinish { get; set; }
        /// <summary>
	    /// 执行人
	    /// </summary>
        public string MakerList { get; set; }

        public string FrmData { get; set; }

    }
}
