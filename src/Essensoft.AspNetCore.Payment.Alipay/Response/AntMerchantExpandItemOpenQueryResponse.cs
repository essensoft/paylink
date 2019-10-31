using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandItemOpenQueryResponse.
    /// </summary>
    public class AntMerchantExpandItemOpenQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [JsonProperty("item_list")]
        public List<CmItemInfo> ItemList { get; set; }
    }
}
