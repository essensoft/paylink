using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
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
        /// 直联商户填写pid，  pid和smid必填其一
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 间联商户填写smid，pid和smid必填其一
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }
    }
}
