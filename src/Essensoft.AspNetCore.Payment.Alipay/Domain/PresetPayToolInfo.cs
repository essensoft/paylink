using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PresetPayToolInfo Data Structure.
    /// </summary>
    public class PresetPayToolInfo : AlipayObject
    {
        /// <summary>
        /// 前置资产金额
        /// </summary>
        [JsonPropertyName("amount")]
        public List<string> Amount { get; set; }

        /// <summary>
        /// 前置资产类型编码，和收单支付传入的preset_pay_tool里面的类型编码保持一致。
        /// </summary>
        [JsonPropertyName("assert_type_code")]
        public string AssertTypeCode { get; set; }
    }
}
