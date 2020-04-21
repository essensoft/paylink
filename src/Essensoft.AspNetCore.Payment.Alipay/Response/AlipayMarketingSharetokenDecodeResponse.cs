using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingSharetokenDecodeResponse.
    /// </summary>
    public class AlipayMarketingSharetokenDecodeResponse : AlipayResponse
    {
        /// <summary>
        /// 第一个按钮名称
        /// </summary>
        [JsonPropertyName("btn_one_name")]
        public string BtnOneName { get; set; }

        /// <summary>
        /// 第一个按钮链接
        /// </summary>
        [JsonPropertyName("btn_one_schema")]
        public string BtnOneSchema { get; set; }

        /// <summary>
        /// 第二个按钮名称
        /// </summary>
        [JsonPropertyName("btn_two_name")]
        public string BtnTwoName { get; set; }

        /// <summary>
        /// 第二个按钮链接
        /// </summary>
        [JsonPropertyName("btn_two_schema")]
        public string BtnTwoSchema { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// icon地址
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
