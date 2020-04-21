using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpCodecCreateResponse.
    /// </summary>
    public class ZhimaCreditEpCodecCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 二维码地址
        /// </summary>
        [JsonPropertyName("codec_img_url")]
        public string CodecImgUrl { get; set; }

        /// <summary>
        /// 二维码生码订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 二维码码值
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
