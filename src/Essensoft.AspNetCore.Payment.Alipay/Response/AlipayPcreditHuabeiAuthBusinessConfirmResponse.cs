using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthBusinessConfirmResponse.
    /// </summary>
    public class AlipayPcreditHuabeiAuthBusinessConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 业务信息回执失败原因描述
        /// </summary>
        [JsonProperty("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，用于标示请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
