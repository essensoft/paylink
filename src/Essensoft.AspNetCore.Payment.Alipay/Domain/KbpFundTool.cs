using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbpFundTool Data Structure.
    /// </summary>
    public class KbpFundTool : AlipayObject
    {
        /// <summary>
        /// 非现金类支付明细抵扣金额；单位：分；字符类型必须为正整数格式
        /// </summary>
        [JsonPropertyName("f_fee")]
        public string FFee { get; set; }

        /// <summary>
        /// 资金处理中，第三方支付工具ID；  比如：在支付中使用的红包ID；
        /// </summary>
        [JsonPropertyName("f_id")]
        public string FId { get; set; }

        /// <summary>
        /// 非现金类支付明细类型；标识：红包、代金券：比如：CASH：带资金红包、代金券；NO_CASH：不带资金红包、代金券；
        /// </summary>
        [JsonPropertyName("f_type")]
        public string FType { get; set; }
    }
}
