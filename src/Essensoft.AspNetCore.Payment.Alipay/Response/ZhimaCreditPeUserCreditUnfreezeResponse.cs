using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeUserCreditUnfreezeResponse.
    /// </summary>
    public class ZhimaCreditPeUserCreditUnfreezeResponse : AlipayResponse
    {
        /// <summary>
        /// 解冻成功额度，单位为元，取值范围[0.01,100000000]，精确到小数点后2位
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 外部请求幂等号，即接口入参的out_request_no，接口处理完之后回传
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 业务处理是否成功标记，成功返回true，其他情况下返回false
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
