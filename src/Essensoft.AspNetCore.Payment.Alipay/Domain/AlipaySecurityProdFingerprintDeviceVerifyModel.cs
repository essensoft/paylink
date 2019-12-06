using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdFingerprintDeviceVerifyModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdFingerprintDeviceVerifyModel : AlipayObject
    {
        /// <summary>
        /// IFAA协议的版本，目前为2.0;建议填写此字段，随着业务发展后面可能会强制要求传递;
        /// </summary>
        [JsonPropertyName("ifaa_version")]
        public string IfaaVersion { get; set; }

        /// <summary>
        /// ifaf_message:注册阶段客户端返回的协议体数据，对应《IFAA本地免密技术规范》中的IFAFMessage，内容中包含客户端的校验数据。
        /// </summary>
        [JsonPropertyName("ifaf_message")]
        public string IfafMessage { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单，用于核对与问题排查。原则上来说需要保持唯一性。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
