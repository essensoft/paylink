using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SkuPropertyInfo Data Structure.
    /// </summary>
    public class SkuPropertyInfo : AlipayObject
    {
        /// <summary>
        /// sku属性key值,可发邮件到lei.mao@antfin.com,联系支付宝获取已支持的key.支付宝在收到邮件后三个工作日内回复
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 商家sku属性值列表
        /// </summary>
        [JsonProperty("value")]
        public List<SkuPropertyValue> Value { get; set; }
    }
}
