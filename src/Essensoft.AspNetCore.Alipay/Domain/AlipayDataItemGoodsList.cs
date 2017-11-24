using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayDataItemGoodsList Data Structure.
    /// </summary>
    public class AlipayDataItemGoodsList : AlipayObject
    {
        /// <summary>
        /// 单品的描述信息
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 单品id列表
        /// </summary>
        [JsonProperty("goods_list")]
        public List<string> GoodsList { get; set; }
    }
}
