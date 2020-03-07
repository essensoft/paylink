using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniShopActivityCreateResponse.
    /// </summary>
    public class AlipayOpenMiniShopActivityCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 业务处理流水号，唯一，可以根据该流水号进行活动取消
        /// </summary>
        [JsonPropertyName("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
