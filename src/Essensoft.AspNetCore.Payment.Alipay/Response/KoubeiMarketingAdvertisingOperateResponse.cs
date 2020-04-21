using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingAdvertisingOperateResponse.
    /// </summary>
    public class KoubeiMarketingAdvertisingOperateResponse : AlipayResponse
    {
        /// <summary>
        /// 正常操作返回当前操作的广告id。如果操作失败，返回的广告id为空
        /// </summary>
        [JsonPropertyName("ad_id")]
        public string AdId { get; set; }
    }
}
