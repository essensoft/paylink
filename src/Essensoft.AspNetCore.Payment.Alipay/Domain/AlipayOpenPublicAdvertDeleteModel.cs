using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicAdvertDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicAdvertDeleteModel : AlipayObject
    {
        /// <summary>
        /// 待删除的广告位id
        /// </summary>
        [JsonPropertyName("advert_id")]
        public string AdvertId { get; set; }
    }
}
