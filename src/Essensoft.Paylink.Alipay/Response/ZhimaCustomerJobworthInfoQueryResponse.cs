using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCustomerJobworthInfoQueryResponse.
    /// </summary>
    public class ZhimaCustomerJobworthInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用于授权校验,授权之前需要通过token校验
        /// </summary>
        [JsonPropertyName("auth_token")]
        public string AuthToken { get; set; }

        /// <summary>
        /// 职得工作证图片url,可以直接用于展示
        /// </summary>
        [JsonPropertyName("picture_url")]
        public string PictureUrl { get; set; }

        /// <summary>
        /// 业务编码
        /// </summary>
        [JsonPropertyName("sub_code")]
        public new string SubCode { get; set; }

        /// <summary>
        /// 业务中文结果信息
        /// </summary>
        [JsonPropertyName("sub_msg")]
        public new string SubMsg { get; set; }

        /// <summary>
        /// 工作证图片更新的url,需要跳转到工作证小程序中进行更新
        /// </summary>
        [JsonPropertyName("update_url")]
        public string UpdateUrl { get; set; }

        /// <summary>
        /// 职得工作证跳转小程序链接
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
