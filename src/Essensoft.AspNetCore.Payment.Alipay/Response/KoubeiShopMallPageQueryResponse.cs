using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiShopMallPageQueryResponse.
    /// </summary>
    public class KoubeiShopMallPageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商圈首页url地址
        /// </summary>
        [JsonPropertyName("mall_url")]
        public string MallUrl { get; set; }
    }
}
