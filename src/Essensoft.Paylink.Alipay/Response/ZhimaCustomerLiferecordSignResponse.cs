using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCustomerLiferecordSignResponse.
    /// </summary>
    public class ZhimaCustomerLiferecordSignResponse : AlipayResponse
    {
        /// <summary>
        /// 业务处理是否成功
        /// </summary>
        [JsonPropertyName("process_success")]
        public bool ProcessSuccess { get; set; }

        /// <summary>
        /// 结果code
        /// </summary>
        [JsonPropertyName("sub_code")]
        public new string SubCode { get; set; }

        /// <summary>
        /// code对应的数值码
        /// </summary>
        [JsonPropertyName("sub_code_number")]
        public long SubCodeNumber { get; set; }

        /// <summary>
        /// 异常码说明
        /// </summary>
        [JsonPropertyName("sub_message")]
        public string SubMessage { get; set; }

        /// <summary>
        /// 接口调用是否成功
        /// </summary>
        [JsonPropertyName("sub_success")]
        public bool SubSuccess { get; set; }
    }
}
