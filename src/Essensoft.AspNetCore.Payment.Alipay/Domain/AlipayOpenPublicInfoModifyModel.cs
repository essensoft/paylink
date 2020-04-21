using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicInfoModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicInfoModifyModel : AlipayObject
    {
        /// <summary>
        /// 生活号名称，2-20个字之间；不得含有违反法律法规和公序良俗的相关信息；不得侵害他人名誉权、知识产权、商业秘密等合法权利；不得以太过广泛的、或产品、行业词组来命名，如：女装、皮革批发；不得以实名认证的媒体资质账号创建服务窗，或媒体相关名称命名服务窗，如：XX电视台、XX杂志等
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 授权运营书图片地址，企业商户若为被经营方授权，需上传加盖公章的扫描件，支持.jpg .jpeg .png格式，小于1M。使用alipay.offline.material.image.upload上传，将得到的image_url回填与此处。
        /// </summary>
        [JsonPropertyName("auth_pic")]
        public string AuthPic { get; set; }

        /// <summary>
        /// 背景图片地址，建议尺寸 1600 x 1000px，支持.jpg .jpeg .png格式，小于1M。使用alipay.offline.material.image.upload上传，将得到的image_url回填与此处
        /// </summary>
        [JsonPropertyName("background_url")]
        public string BackgroundUrl { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        [JsonPropertyName("introduction")]
        public string Introduction { get; set; }

        /// <summary>
        /// 营业执照地址，建议尺寸 320 x 320px，支持.jpg .jpeg .png 格式，小于1M。使用alipay.offline.material.image.upload上传，将得到的image_url回填与此处。
        /// </summary>
        [JsonPropertyName("license_url")]
        public string LicenseUrl { get; set; }

        /// <summary>
        /// 生活号头像地址，建议尺寸 320 x 320px，支持.jpg .jpeg .png 格式，小于1M。使用alipay.offline.material.image.upload上传，将得到的image_url回填与此处
        /// </summary>
        [JsonPropertyName("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 欢迎语
        /// </summary>
        [JsonPropertyName("public_greeting")]
        public string PublicGreeting { get; set; }

        /// <summary>
        /// 门店照片地址，支持.jpg .jpeg .png格式，小于1M。使用alipay.offline.material.image.upload上传，将得到的image_url回填与此处。
        /// </summary>
        [JsonPropertyName("shop_pics")]
        public List<string> ShopPics { get; set; }
    }
}
