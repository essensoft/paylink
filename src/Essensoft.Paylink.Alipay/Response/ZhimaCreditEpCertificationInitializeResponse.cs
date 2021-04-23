using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpCertificationInitializeResponse.
    /// </summary>
    public class ZhimaCreditEpCertificationInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 一次认证的唯一标识
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 商户唯一业务流水号，由大小写字母和数字构成
        /// </summary>
        [JsonPropertyName("org_biz_no")]
        public string OrgBizNo { get; set; }
    }
}
