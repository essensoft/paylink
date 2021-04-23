using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoBizoptCloseResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoBizoptCloseResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻GO签约申请时生成的签约申请单据号
        /// </summary>
        [JsonPropertyName("biz_opt_no")]
        public string BizOptNo { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
