using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayItemGoodsList Data Structure.
    /// </summary>
    public class AlipayItemGoodsList : AlipayObject
    {
        /// <summary>
        /// 外部单品的描述信息（此字段暂时无用）
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 外部单品id列表，传入服务商、商户系统中的商品id。
        /// </summary>
        [JsonPropertyName("goods_list")]
        public List<string> GoodsList { get; set; }
    }
}
