using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AppAttribute Data Structure.
    /// </summary>
    public class AppAttribute : AlipayObject
    {
        /// <summary>
        /// 属性的Key，对于类目属性，支付宝侧约定属性编码，商户侧根据实际情况，按需传入。具体可以参见接口所在功能包的产品说明文档。
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 属性的Value，对于类目属性，如果值是枚举化的，支付宝测约会定具体的编码，商户侧根据实际情况，按需传入。具体可以参考接口所在功能包的产品说明文档。
        /// </summary>
        [JsonPropertyName("value")]
        public List<string> Value { get; set; }
    }
}
