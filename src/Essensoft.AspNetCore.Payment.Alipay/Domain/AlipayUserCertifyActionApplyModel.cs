using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertifyActionApplyModel Data Structure.
    /// </summary>
    public class AlipayUserCertifyActionApplyModel : AlipayObject
    {
        /// <summary>
        /// 表示申请认证信息的业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，用于代表申请认证信息的商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }
    }
}
