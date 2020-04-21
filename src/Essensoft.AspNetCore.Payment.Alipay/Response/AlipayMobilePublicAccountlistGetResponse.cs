using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicAccountlistGetResponse.
    /// </summary>
    public class AlipayMobilePublicAccountlistGetResponse : AlipayResponse
    {
        /// <summary>
        /// 服务窗列表
        /// </summary>
        [JsonPropertyName("account_list")]
        public string AccountList { get; set; }

        /// <summary>
        /// 响应码
        /// </summary>
        [JsonPropertyName("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 服务窗列表总数
        /// </summary>
        [JsonPropertyName("count")]
        public long Count { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [JsonPropertyName("msg")]
        public override string Msg { get; set; }
    }
}
