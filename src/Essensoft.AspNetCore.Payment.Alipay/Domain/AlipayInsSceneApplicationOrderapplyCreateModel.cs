using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneApplicationOrderapplyCreateModel Data Structure.
    /// </summary>
    public class AlipayInsSceneApplicationOrderapplyCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务字段
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 赔付政策类型
        /// </summary>
        [JsonPropertyName("claim_strategy_list")]
        public List<ClaimStrategy> ClaimStrategyList { get; set; }

        /// <summary>
        /// havana_id
        /// </summary>
        [JsonPropertyName("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// 订单信息
        /// </summary>
        [JsonPropertyName("order_info")]
        public InsOrderInfo OrderInfo { get; set; }

        /// <summary>
        /// 外部业务号(幂等单号)
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [JsonPropertyName("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 产品号
        /// </summary>
        [JsonPropertyName("prod_code")]
        public string ProdCode { get; set; }
    }
}
