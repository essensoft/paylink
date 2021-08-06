using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBusinessRelationShopDeleteResponse.
    /// </summary>
    public class AlipayBusinessRelationShopDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 删除的商业关系门店id
        /// </summary>
        [JsonPropertyName("real_shop_id")]
        public string RealShopId { get; set; }
    }
}
