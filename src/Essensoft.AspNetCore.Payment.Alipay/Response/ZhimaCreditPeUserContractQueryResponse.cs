using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeUserContractQueryResponse.
    /// </summary>
    public class ZhimaCreditPeUserContractQueryResponse : AlipayResponse
    {
        /// <summary>
        /// true: 用户开通 false: 用户未开通
        /// </summary>
        [JsonPropertyName("open")]
        public bool Open { get; set; }

        /// <summary>
        /// 签约时间，格式：yyyy-MM-dd hh:mm:ss,未开通时值为空
        /// </summary>
        [JsonPropertyName("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 签约成功时对应的服务签约号,未开通时值为空
        /// </summary>
        [JsonPropertyName("sign_id")]
        public string SignId { get; set; }
    }
}
