using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataItemGoodsList Data Structure.
    /// </summary>
    public class AlipayDataItemGoodsList : AlipayObject
    {
        /// <summary>
        /// 单品的描述信息
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 单品id列表
        /// </summary>
        [JsonPropertyName("goods_list")]
        public List<string> GoodsList { get; set; }
    }
}
