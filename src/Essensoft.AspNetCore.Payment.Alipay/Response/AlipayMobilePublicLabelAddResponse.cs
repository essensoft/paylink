using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicLabelAddResponse.
    /// </summary>
    public class AlipayMobilePublicLabelAddResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonProperty("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 标签编码
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [JsonProperty("msg")]
        public override string Msg { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
