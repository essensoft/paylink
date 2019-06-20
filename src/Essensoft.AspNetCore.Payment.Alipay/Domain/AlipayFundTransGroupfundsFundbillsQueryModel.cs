using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransGroupfundsFundbillsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransGroupfundsFundbillsQueryModel : AlipayObject
    {
        /// <summary>
        /// 流水关联的批次号
        /// </summary>
        [JsonProperty("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 当前查询单据流水的用户支付宝账户ID
        /// </summary>
        [JsonProperty("current_user_id")]
        public string CurrentUserId { get; set; }

        /// <summary>
        /// 扩展参数，可选，业务扩展时使用
        /// </summary>
        [JsonProperty("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 查询类型，SINGLE: 表示仅查询当前用户流水，ALL: 表示查询所有流水，默认为SINGLE
        /// </summary>
        [JsonProperty("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 业务来源,对于聚会小程序统一透传"openParty"
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }
    }
}
