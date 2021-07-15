using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCustomerLiferecordSendResponse.
    /// </summary>
    public class ZhimaCustomerLiferecordSendResponse : AlipayResponse
    {
        /// <summary>
        /// 数据回流是否成功
        /// </summary>
        [JsonPropertyName("feed_back_success")]
        public bool FeedBackSuccess { get; set; }

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
