using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AutoMktTouchExtendInfoEntry Data Structure.
    /// </summary>
    [Serializable]
    public class AutoMktTouchExtendInfoEntry : AlipayObject
    {
        /// <summary>
        /// 扩展信息元素的Key值。
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 扩展字段的值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
