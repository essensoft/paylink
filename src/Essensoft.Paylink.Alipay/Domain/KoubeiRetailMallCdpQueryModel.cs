using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailMallCdpQueryModel Data Structure.
    /// </summary>
    public class KoubeiRetailMallCdpQueryModel : AlipayObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [JsonPropertyName("mall_id")]
        public string MallId { get; set; }
    }
}
