using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappBrandSubmitModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniMiniappBrandSubmitModel : AlipayObject
    {
        /// <summary>
        /// 申请的资质类型 SELF_BRAND_APPLY 自有品牌申请(当需要一个新的品牌时选择此项) AUTHORIZE_BRAND_APPLY 授权品牌申请(当需要授权一个已有的品牌给商户时选择此项) EXIST_BRAND_BIND 品牌绑定，适用于品牌已申请成功的情况(当需要将已有品牌绑定到无品牌小程序时选择此项)
        /// </summary>
        [JsonPropertyName("apply_type")]
        public string ApplyType { get; set; }

        /// <summary>
        /// 授权资质相关信息(只有申请的资质类型为AUTHORIZE_BRAND_APPLY时需要填写)
        /// </summary>
        [JsonPropertyName("authorize_info")]
        public AuthorizeInfo AuthorizeInfo { get; set; }

        /// <summary>
        /// 商户已有品牌Id(只有申请的资质类型为EXIST_BRAND_BIND 时需要填写)
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 品牌相关信息(只有申请的资质类型为AUTHORIZE_BRAND_APPLY或SELF_BRAND_APPLY时需要填写)
        /// </summary>
        [JsonPropertyName("brand_registration_info")]
        public BrandRegistrationInfo BrandRegistrationInfo { get; set; }

        /// <summary>
        /// 申请人身份证明材料(当前只支持图片类型，请调用alipay.open.mini.miniapp.brand.upload接口上传图片，可以上传多个身份证明材料)
        /// </summary>
        [JsonPropertyName("id_materials")]
        public List<string> IdMaterials { get; set; }
    }
}
