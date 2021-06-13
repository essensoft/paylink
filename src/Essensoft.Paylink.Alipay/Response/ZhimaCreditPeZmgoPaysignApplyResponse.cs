using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoPaysignApplyResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoPaysignApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 如果签约幂等了，这个就是签约协议号
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 是否签约幂等,如果签约幂等的话 就需要继续走签约确认流程了。
        /// </summary>
        [JsonPropertyName("idempotent")]
        public bool Idempotent { get; set; }

        /// <summary>
        /// 签约申请生成的操作单号，签约确认的时候需要将该字段回传回来
        /// </summary>
        [JsonPropertyName("zmgo_opt_no")]
        public string ZmgoOptNo { get; set; }
    }
}
