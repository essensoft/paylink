using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantShopcodeCategoryQueryResponse.
    /// </summary>
    public class AlipayMerchantShopcodeCategoryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 门店码一级类目列表
        /// </summary>
        [JsonPropertyName("categories")]
        public List<CategoryRootDTO> Categories { get; set; }
    }
}
