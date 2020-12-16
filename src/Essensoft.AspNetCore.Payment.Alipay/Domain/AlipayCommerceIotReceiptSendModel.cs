using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotReceiptSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotReceiptSendModel : AlipayObject
    {
        /// <summary>
        /// 用户支付宝uid
        /// </summary>
        [JsonPropertyName("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 电子小票详情信息
        /// </summary>
        [JsonPropertyName("biz_data")]
        public ReceiptBizData BizData { get; set; }

        /// <summary>
        /// 机具身份id
        /// </summary>
        [JsonPropertyName("biztid")]
        public string Biztid { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
