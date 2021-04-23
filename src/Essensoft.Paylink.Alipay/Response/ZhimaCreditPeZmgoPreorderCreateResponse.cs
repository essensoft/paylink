using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoPreorderCreateResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoPreorderCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 芝麻GO预创建单号
        /// </summary>
        [JsonPropertyName("preorder_no")]
        public string PreorderNo { get; set; }
    }
}
