using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosPracticeModifyModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosPracticeModifyModel : AlipayObject
    {
        /// <summary>
        /// 做法id
        /// </summary>
        [JsonPropertyName("practice_id")]
        public string PracticeId { get; set; }

        /// <summary>
        /// 做法名称
        /// </summary>
        [JsonPropertyName("practice_name")]
        public string PracticeName { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
