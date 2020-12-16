using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateMerchantDTO Data Structure.
    /// </summary>
    public class TemplateMerchantDTO : AlipayObject
    {
        /// <summary>
        /// 卡券所属品牌ID，支持支付宝品牌库与淘宝品牌库录入的品牌，当从对应品牌库录入卡券品牌信息后可获得品牌ID。支持自定义动态参数传值，但动态参数需定义为：$_r_brand_id$。
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 品牌ID来源，当brand_id有值时本字段必填。TAOBAO：代表来自淘宝品牌库，ALIPAY：代表来自支付宝品牌库。支持自定义动态参数传值，但动态参数需定义为：$_r_brand_id_source$。
        /// </summary>
        [JsonPropertyName("brand_id_source")]
        public string BrandIdSource { get; set; }

        /// <summary>
        /// 卡券品牌名称，建议9个字符以内。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 卡券所属商户生活号，可用于卡券详情页下方快速跳转商户生活号。生活号创建见生活号API服务（alipay.open.public.life.agent.create）。支持自定义动态参数传值，但动态参数需定义为：$_r_life_code$。
        /// </summary>
        [JsonPropertyName("life_code")]
        public string LifeCode { get; set; }

        /// <summary>
        /// 卡券所属商户名称。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商户的服务电话。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("merchant_tel")]
        public string MerchantTel { get; set; }
    }
}
