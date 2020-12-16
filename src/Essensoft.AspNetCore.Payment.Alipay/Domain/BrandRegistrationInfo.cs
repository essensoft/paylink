using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BrandRegistrationInfo Data Structure.
    /// </summary>
    public class BrandRegistrationInfo : AlipayObject
    {
        /// <summary>
        /// 商标有效期(结束日期)
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 商标注册证书信息(当前只支持图片类型，请调用alipay.open.mini.miniapp.brand.upload接口上传图片,可以上传多个商标注册证书信息)
        /// </summary>
        [JsonPropertyName("reg_materials")]
        public List<string> RegMaterials { get; set; }

        /// <summary>
        /// 商标注册号
        /// </summary>
        [JsonPropertyName("reg_number")]
        public string RegNumber { get; set; }

        /// <summary>
        /// 商标注册人
        /// </summary>
        [JsonPropertyName("registrant")]
        public string Registrant { get; set; }

        /// <summary>
        /// 商标有效期(开始日期)
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
