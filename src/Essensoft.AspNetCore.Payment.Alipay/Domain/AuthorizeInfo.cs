using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AuthorizeInfo Data Structure.
    /// </summary>
    public class AuthorizeInfo : AlipayObject
    {
        /// <summary>
        /// 授权方身份证明(当前只支持图片类型，请调用alipay.open.mini.miniapp.brand.upload接口上传图片,可以上传多个授权方身份证明)
        /// </summary>
        [JsonPropertyName("auth_ids")]
        public List<string> AuthIds { get; set; }

        /// <summary>
        /// 授权有效资质(当前只支持图片类型，请调用alipay.open.mini.miniapp.brand.upload接口上传图片，可以上传多个授权有效资质)
        /// </summary>
        [JsonPropertyName("auth_materials")]
        public List<string> AuthMaterials { get; set; }

        /// <summary>
        /// 被授权人名称
        /// </summary>
        [JsonPropertyName("auth_name")]
        public string AuthName { get; set; }

        /// <summary>
        /// 授权有效期(结束日期)
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 授权有效期(开始日期)
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
