using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoAutoaftermarketOutorderSyncResponse.
    /// </summary>
    public class AlipayInsAutoAutoaftermarketOutorderSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 蚂蚁生成的订单号，跟服务商的订单号做一一映射
        /// </summary>
        [JsonPropertyName("ant_order_no")]
        public string AntOrderNo { get; set; }
    }
}
