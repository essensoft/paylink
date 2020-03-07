using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiShopExternalDataSyncResponse.
    /// </summary>
    public class KoubeiShopExternalDataSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 流水结果描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 申请流水Id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 流水处理成功  SUCESS(成功)  PROCESS(处理中)
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }
    }
}
