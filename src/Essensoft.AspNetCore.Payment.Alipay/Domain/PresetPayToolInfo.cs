using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PresetPayToolInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PresetPayToolInfo : AlipayObject
    {
        /// <summary>
        /// 前置资产金额
        /// </summary>
        [JsonProperty("amount")]
        [XmlArray("amount")]
        [XmlArrayItem("price")]
        public List<string> Amount { get; set; }

        /// <summary>
        /// 前置资产类型编码，和收单支付传入的preset_pay_tool里面的类型编码保持一致。
        /// </summary>
        [JsonProperty("assert_type_code")]
        [XmlElement("assert_type_code")]
        public string AssertTypeCode { get; set; }
    }
}
