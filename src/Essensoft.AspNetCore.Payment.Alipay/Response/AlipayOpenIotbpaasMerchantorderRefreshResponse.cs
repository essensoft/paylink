using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenIotbpaasMerchantorderRefreshResponse.
    /// </summary>
    public class AlipayOpenIotbpaasMerchantorderRefreshResponse : AlipayResponse
    {
        /// <summary>
        /// 订单列表
        /// </summary>
        [JsonPropertyName("order_list")]
        public List<IoTBPaaSMerchantOrderInfo> OrderList { get; set; }
    }
}
