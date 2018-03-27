using Newtonsoft.Json;

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
        [JsonProperty("advert_id")]
        public string AdvertId { get; set; }
    }
}
