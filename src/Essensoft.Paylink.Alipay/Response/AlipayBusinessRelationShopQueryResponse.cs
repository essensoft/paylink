using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBusinessRelationShopQueryResponse.
    /// </summary>
    public class AlipayBusinessRelationShopQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 代运营商业关系门店信息
        /// </summary>
        [JsonPropertyName("shop_infos")]
        public List<BusinessRelationShopInfo> ShopInfos { get; set; }
    }
}
