using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiRpacrawlerQueryModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiRpacrawlerQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 功能类型，区分接口内部业务类型（queryInitDeliveryList,updateDeliveryPublish,updateDeliveryOffline）
        /// </summary>
        [JsonPropertyName("function_type")]
        public string FunctionType { get; set; }

        /// <summary>
        /// 记录offset，function_type=queryInitDeliveryList参数有值
        /// </summary>
        [JsonPropertyName("offset")]
        public long Offset { get; set; }

        /// <summary>
        /// 外部业务号，更新任务状态时赋值为投放单元code值
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 查询列表最大返回记录数，function_type=queryInitDeliveryList参数有值
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询条件列表
        /// </summary>
        [JsonPropertyName("query_criteria")]
        public List<RpaCrawlerQueryCriteriaVO> QueryCriteria { get; set; }

        /// <summary>
        /// 同步任务结果状态
        /// </summary>
        [JsonPropertyName("sync_task_status")]
        public string SyncTaskStatus { get; set; }

        /// <summary>
        /// 任务ID，同步单元成功和下线单元成功后需要传该参数
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
