using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateEInfoDTO Data Structure.
    /// </summary>
    public class TemplateEInfoDTO : AlipayObject
    {
        /// <summary>
        /// 卡券辅助区域块
        /// </summary>
        [JsonPropertyName("auxiliary_fields")]
        public List<TemplateEInfoUnitDTO> AuxiliaryFields { get; set; }

        /// <summary>
        /// 卡券适用商品ID列表，对于使用支付宝底层商品系统、小程序服务的卡券可直接显示对应商品信息，快速跳转转化。支持自定义动态参数传值，但动态参数需定义为：[$_r_available_item_id$]，即在数组里存放单个元素：$_r_available_item_id$。
        /// </summary>
        [JsonPropertyName("available_item_ids")]
        public List<string> AvailableItemIds { get; set; }

        /// <summary>
        /// 卡券适用商品来源，对于使用支付宝底层商品系统、小程序服务的卡券可直接显示对应商品信息，快速跳转转化。支持自定义动态参数传值，但动态参数需定义为：$_r_available_item_source$。
        /// </summary>
        [JsonPropertyName("available_item_source")]
        public string AvailableItemSource { get; set; }

        /// <summary>
        /// 卡券背面（更多使用详情）区域块
        /// </summary>
        [JsonPropertyName("back_fields")]
        public List<TemplateEInfoUnitDTO> BackFields { get; set; }

        /// <summary>
        /// 卡券底部横幅信息
        /// </summary>
        [JsonPropertyName("banner")]
        public TemplateBannerDTO Banner { get; set; }

        /// <summary>
        /// 卡券自定义辅助区域块
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public List<TemplateEInfoUnitDTO> CustomFields { get; set; }

        /// <summary>
        /// 卡券主标题，建议不超过12个字。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("logo_text")]
        public string LogoText { get; set; }

        /// <summary>
        /// 卡券商品原价，包括金额，用于对比显示卡券优惠力度。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("origin_price")]
        public string OriginPrice { get; set; }

        /// <summary>
        /// 卡券商品图片ID，通过接口（alipay.offline.material.image.upload）上传图片获得图片ID。图片需在1M以内，支持bmp、png、jpeg、jpg、gif格式，尺寸不小于670*335px。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("pass_img")]
        public string PassImg { get; set; }

        /// <summary>
        /// 卡券商品图片显示比例，保留小数点2位，默认2.79。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("pass_img_ratio")]
        public string PassImgRatio { get; set; }

        /// <summary>
        /// 卡券辅助标题，建议不超过50个字。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("second_logo_text")]
        public string SecondLogoText { get; set; }

        /// <summary>
        /// 卡券使用门槛。建议根据类型设置文案，代金券：金额门槛（满N元可用）；折扣券：时间门槛（每周N次/N元，首月专享）；商品券：地域门槛（N门店可用）；兑换券：支付门槛（支付方式限制），资格凭证：渠道门槛（小程序专用）。支持自定义动态参数传值，但动态参数需定义为：$_r_use_condition$。
        /// </summary>
        [JsonPropertyName("use_condition")]
        public string UseCondition { get; set; }

        /// <summary>
        /// 适用城市，国标（行政区划代码）前6位编码，支持省份、城市，不支持城市下级区县，如：330100（浙江省）、330100（杭州市），不支持：330106（西湖区）。用于优先推荐参考因素，暂不对用户展示。不限城市：ALL，省份编码，城市编码。允许多个省份与城市同时出现，多个省份或城市使用英文（半角）逗号进行分隔，城市与城市所属省份不能同时出现。支持自定义动态参数传值，但动态参数需定义为：$_r_use_limit_city$。
        /// </summary>
        [JsonPropertyName("use_limit_city")]
        public string UseLimitCity { get; set; }

        /// <summary>
        /// 卡券适用范围/限制，如全场可用、全品类可用、X店铺可用、X商品可用、X服务可用等，建议12字以内。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("use_limit_desc")]
        public string UseLimitDesc { get; set; }

        /// <summary>
        /// 使用场景，用于优先推荐参考因素，暂不对用户展示。线上：ONLINE；线下：OFFLINE；ALL：不限场景。支持自定义动态参数传值，但动态参数需定义为：$_r_use_limit_scene$。
        /// </summary>
        [JsonPropertyName("use_limit_scene")]
        public string UseLimitScene { get; set; }
    }
}
