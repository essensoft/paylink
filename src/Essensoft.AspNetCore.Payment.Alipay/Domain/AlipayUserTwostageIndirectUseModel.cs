using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserTwostageIndirectUseModel Data Structure.
    /// </summary>
    public class AlipayUserTwostageIndirectUseModel : AlipayObject
    {
        /// <summary>
        /// 商户扫描用户的付款码值。18~24位，25~30开头，例如28开头的18位的数字；或人脸支付的ftoken等。
        /// </summary>
        [JsonPropertyName("dynamic_id")]
        public string DynamicId { get; set; }

        /// <summary>
        /// 进件信息中，SMID对应的银行机构的PID信息，一般为2088开头的16位数字。
        /// </summary>
        [JsonPropertyName("org_pid")]
        public string OrgPid { get; set; }

        /// <summary>
        /// 进件信息中，二级商户ID（ sub_merchant_id)信息，一般为2088开头的16位数字。
        /// </summary>
        [JsonPropertyName("pay_smid")]
        public string PaySmid { get; set; }

        /// <summary>
        /// 外部业务号，用于标识这笔解码请求，对同一个码的重复解码请求，sence_no必须与上一次保持一致，每次请求的sence_no必须不一样，如alipay.user.twostage.common.use接口配合alipay.trade.pay（统一收单交易支付接口）一并使用时，alipay.trade.pay接口的extend_params属性中必须设置DYNAMIC_TOKEN_OUT_BIZ_NO，且值必须与sence_no保持一致
        /// </summary>
        [JsonPropertyName("sence_no")]
        public string SenceNo { get; set; }

        /// <summary>
        /// 进件信息中，SMID对应渠道的PID信息，一般为2088开头的16位数字。
        /// </summary>
        [JsonPropertyName("source_pid")]
        public string SourcePid { get; set; }
    }
}
