using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DefaultSettleRule Data Structure.
    /// </summary>
    public class DefaultSettleRule : AlipayObject
    {
        /// <summary>
        /// 默认结算目标。当默认结算类型为bankCard时填写银行卡卡号，其值需在进件填写的结算银行卡范围内；当默认结算类型为alipayAccount时填写支付宝账号登录号，其值需在进件填写的结算支付宝账号范围内。
        /// </summary>
        [JsonPropertyName("default_settle_target")]
        public string DefaultSettleTarget { get; set; }

        /// <summary>
        /// 默认结算类型，可选值有bankCard/alipayAccount。bankCard表示结算到银行卡；alipayAccount表示结算到支付宝账号
        /// </summary>
        [JsonPropertyName("default_settle_type")]
        public string DefaultSettleType { get; set; }
    }
}
