using System;


namespace MVC.Repository.Domain
{
    /// <summary>
    /// 多对多关系集中映射
    /// </summary>
    public partial class Relevance : Entity
    {
        public Relevance()
        {
            this.Description = string.Empty;
            this.Key = string.Empty;
            this.Status = 0;
            this.OperateTime = DateTime.Now;
            this.OperatorId = string.Empty;
            this.FirstId = string.Empty;
            this.SecondId = string.Empty;
        }

        /// <summary>
	    /// 描述
	    /// </summary>
        public string Description { get; set; }
        /// <summary>
	    /// 映射标识
	    /// </summary>
        public string Key { get; set; }
        /// <summary>
	    /// 状态
	    /// </summary>
        public int Status { get; set; }
        /// <summary>
	    /// 授权时间
	    /// </summary>
        public System.DateTime OperateTime { get; set; }
        /// <summary>
	    /// 授权人
	    /// </summary>
        public string OperatorId { get; set; }
        /// <summary>
	    /// 第一个表主键ID
	    /// </summary>
        public string FirstId { get; set; }
        /// <summary>
	    /// 第二个表主键ID
	    /// </summary>
        public string SecondId { get; set; }

    }
}
