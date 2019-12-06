using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMarketShopPublicBindResponse.
    /// </summary>
    public class AlipayOfflineMarketShopPublicBindResponse : AlipayResponse
    {
        /// <summary>
        /// 绑定失败的店铺ID列表
        /// </summary>
        [JsonPropertyName("error_binding_shop_ids")]
        public List<string> ErrorBindingShopIds { get; set; }

        /// <summary>
        /// 数字类型，标示总的绑定错误总数
        /// </summary>
        [JsonPropertyName("total_error")]
        public long TotalError { get; set; }

        /// <summary>
        /// 绑定店铺总成功数
        /// </summary>
        [JsonPropertyName("total_success")]
        public long TotalSuccess { get; set; }
    }
}
