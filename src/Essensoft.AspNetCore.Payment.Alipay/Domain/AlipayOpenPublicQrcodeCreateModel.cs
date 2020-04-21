using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicQrcodeCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicQrcodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 服务窗创建带参二维码接口，开发者自定义信息
        /// </summary>
        [JsonPropertyName("code_info")]
        public CodeInfo CodeInfo { get; set; }

        /// <summary>
        /// 二维码类型，目前只支持两种类型：  TEMP：临时的（默认）；  PERM：永久的
        /// </summary>
        [JsonPropertyName("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// 临时码过期时间，以秒为单位，最大不超过1800秒；  永久码置空
        /// </summary>
        [JsonPropertyName("expire_second")]
        public string ExpireSecond { get; set; }

        /// <summary>
        /// 二维码中间是否显示服务窗logo，Y：显示；N：不显示（默认）
        /// </summary>
        [JsonPropertyName("show_logo")]
        public string ShowLogo { get; set; }
    }
}
