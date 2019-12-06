using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCplifeCommunityBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayEcoCplifeCommunityBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 分页查询的当前页码数，分页从1开始计数。  该参数不传入的时候，默认为1。
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询的每页最大数据条数，取值范围1-500。  不传该参数默认为200。
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 如传入该参数，则返回指定状态的小区，支持的状态值：  PENDING_ONLINE 待上线  ONLINE - 上线  MAINTAIN - 维护中  OFFLINE - 下线    不传该值则默认返回所有状态的小区。
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
