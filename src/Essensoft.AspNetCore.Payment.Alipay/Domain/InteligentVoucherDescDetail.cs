using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InteligentVoucherDescDetail Data Structure.
    /// </summary>
    public class InteligentVoucherDescDetail : AlipayObject
    {
        /// <summary>
        /// 具体描述信息列表
        /// </summary>
        [JsonPropertyName("details")]
        public string Details { get; set; }

        /// <summary>
        /// 图片描述信息
        /// </summary>
        [JsonPropertyName("images")]
        public string Images { get; set; }

        /// <summary>
        /// 券说明的标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 券外部详情描述
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
