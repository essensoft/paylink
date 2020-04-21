using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerCampaignauditQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerCampaignauditQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 外部订单号,商户端唯一
        /// </summary>
        [JsonPropertyName("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
