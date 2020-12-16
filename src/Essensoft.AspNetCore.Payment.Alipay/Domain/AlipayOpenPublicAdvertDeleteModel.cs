using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicAdvertDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicAdvertDeleteModel : AlipayObject
    {
        /// <summary>
        /// 待删除的广告位分组标识
        /// </summary>
        [JsonPropertyName("advert_group")]
        public string AdvertGroup { get; set; }

        /// <summary>
        /// 待删除的广告位id
        /// </summary>
        [JsonPropertyName("advert_id")]
        public string AdvertId { get; set; }
    }
}
