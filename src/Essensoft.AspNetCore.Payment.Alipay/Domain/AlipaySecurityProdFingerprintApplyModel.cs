using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdFingerprintApplyModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdFingerprintApplyModel : AlipayObject
    {
        /// <summary>
        /// IFAA协议的版本，目前为2.0
        /// </summary>
        [JsonPropertyName("ifaa_version")]
        public string IfaaVersion { get; set; }

        /// <summary>
        /// ifaf_message:注册阶段客户端返回的协议体数据，对应《IFAA本地免密技术规范》中的IFAFMessage，内容中包含客户端的校验数据。
        /// </summary>
        [JsonPropertyName("ifaf_message")]
        public string IfafMessage { get; set; }

        /// <summary>
        /// 外部业务号，商户的业务单据号，用于核对与问题排查。原则上来说需要保持唯一性。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// IFAA协议客户端静态信息，调用IFAA客户端SDK接口获取secData，透传至本参数。此参数是为了兼容IFAA1.0而设计的，接入方可根据是否需要接入IFAA1.0来决定是否要传(只接入IFAA2.0不需要传)
        /// </summary>
        [JsonPropertyName("sec_data")]
        public string SecData { get; set; }
    }
}
