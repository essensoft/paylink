using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
