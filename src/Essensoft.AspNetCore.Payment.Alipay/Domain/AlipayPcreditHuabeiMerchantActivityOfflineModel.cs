using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantActivityOfflineModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiMerchantActivityOfflineModel : AlipayObject
    {
        /// <summary>
        /// 商家活动ID，用于唯一确定一个活动
        /// </summary>
        [JsonPropertyName("aggr_id")]
        public string AggrId { get; set; }

        /// <summary>
        /// 外部请求号,用于幂等管理
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
