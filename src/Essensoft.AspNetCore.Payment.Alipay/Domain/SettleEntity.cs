using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SettleEntity Data Structure.
    /// </summary>
    public class SettleEntity : AlipayObject
    {
        /// <summary>
        /// 结算主体账号 当结算主体类型为SecondMerchant，本参数为二级商户的SecondMerchantID；当结算主体类型为MerchantStore，本参数为商户门店ID。
        /// </summary>
        [JsonPropertyName("settle_entity_id")]
        public string SettleEntityId { get; set; }

        /// <summary>
        /// 结算主体类型 SecondMerchant：结算主体为二级商户；MerchantStore：结算主体为商户门店
        /// </summary>
        [JsonPropertyName("settle_entity_type")]
        public string SettleEntityType { get; set; }
    }
}
