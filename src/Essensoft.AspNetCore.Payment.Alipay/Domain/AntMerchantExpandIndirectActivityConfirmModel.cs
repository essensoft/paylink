using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectActivityConfirmModel Data Structure.
    /// </summary>
    public class AntMerchantExpandIndirectActivityConfirmModel : AlipayObject
    {
        /// <summary>
        /// 活动报名id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
