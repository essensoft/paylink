using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeUserContractUnsignResponse.
    /// </summary>
    public class ZhimaCreditPeUserContractUnsignResponse : AlipayResponse
    {
        /// <summary>
        /// 解约时间，格式：yyyy-MM-dd hh:mm:ss
        /// </summary>
        [JsonPropertyName("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 服务签约号，解约成功后，接口返回
        /// </summary>
        [JsonPropertyName("sign_id")]
        public string SignId { get; set; }
    }
}
