using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// ZolozAuthenticationCustomerFaceverifyMatchModel Data Structure.
    /// </summary>
    public class ZolozAuthenticationCustomerFaceverifyMatchModel : AlipayObject
    {
        /// <summary>
        /// 活体照片的二进制内容，然后做base64编码
        /// </summary>
        [JsonProperty("auth_img")]
        public string AuthImg { get; set; }

        /// <summary>
        /// C0：手机端采集的人脸图片  C1：机具端采集的人脸图片
        /// </summary>
        [JsonProperty("auth_img_channel")]
        public string AuthImgChannel { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，该标识作为对账的关键信息，商户要保证其唯一性
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务方使用的账户唯一标示
        /// </summary>
        [JsonProperty("merchant_uid")]
        public string MerchantUid { get; set; }

        /// <summary>
        /// 比对源照片的二进制内容，然后做base64编码
        /// </summary>
        [JsonProperty("ref_img")]
        public string RefImg { get; set; }
    }
}
