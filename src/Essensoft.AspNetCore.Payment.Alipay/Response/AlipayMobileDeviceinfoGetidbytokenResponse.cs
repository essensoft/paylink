using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobileDeviceinfoGetidbytokenResponse.
    /// </summary>
    public class AlipayMobileDeviceinfoGetidbytokenResponse : AlipayResponse
    {
        /// <summary>
        /// 蚂蚁金服集团生成的设备id
        /// </summary>
        [JsonPropertyName("apdid")]
        public string Apdid { get; set; }

        /// <summary>
        /// 操作是否成功
        /// </summary>
        [JsonPropertyName("operateresult")]
        public bool Operateresult { get; set; }

        /// <summary>
        /// 阿里巴巴集团安全生产的设备id
        /// </summary>
        [JsonPropertyName("umid")]
        public string Umid { get; set; }
    }
}
