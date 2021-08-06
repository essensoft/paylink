using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBusinessRelationShopModifyResponse.
    /// </summary>
    public class AlipayBusinessRelationShopModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 基于商业关系的代运营门店id
        /// </summary>
        [JsonPropertyName("real_shop_id")]
        public string RealShopId { get; set; }
    }
}
