using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoEduCampusJobdeliverModifyResponse.
    /// </summary>
    public class AlipayEcoEduCampusJobdeliverModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 返回code编码;成功返回SUCCESS
        /// </summary>
        [JsonPropertyName("isv_code")]
        public string IsvCode { get; set; }
    }
}
