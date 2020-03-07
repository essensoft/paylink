using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingPassShopBindResponse.
    /// </summary>
    public class AlipayMarketingPassShopBindResponse : AlipayResponse
    {
        /// <summary>
        /// 本次调用绑定的门店数量
        /// </summary>
        [JsonPropertyName("binded")]
        public long Binded { get; set; }

        /// <summary>
        /// 绑定门店数的总计
        /// </summary>
        [JsonPropertyName("total_binded")]
        public long TotalBinded { get; set; }
    }
}
