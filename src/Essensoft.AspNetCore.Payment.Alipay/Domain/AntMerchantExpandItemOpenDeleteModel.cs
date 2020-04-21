using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemOpenDeleteModel Data Structure.
    /// </summary>
    public class AntMerchantExpandItemOpenDeleteModel : AlipayObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }
    }
}
