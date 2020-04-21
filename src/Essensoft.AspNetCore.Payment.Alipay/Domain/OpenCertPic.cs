using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenCertPic Data Structure.
    /// </summary>
    public class OpenCertPic : AlipayObject
    {
        /// <summary>
        /// 图片的base64字符串，不需要base64头(data:image/jpeg;base64,)
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// DRIVING_LICENSE_HOME_PAGE:主页;  DRIVING_LICENSE_SUB_PAGE:副页;
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
