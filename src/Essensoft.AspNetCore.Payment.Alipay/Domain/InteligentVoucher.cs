using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InteligentVoucher Data Structure.
    /// </summary>
    public class InteligentVoucher : AlipayObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 券详细说明  最多包含500个字符
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 券是否可转赠，默认为可转赠
        /// </summary>
        [JsonPropertyName("donate_flag")]
        public string DonateFlag { get; set; }

        /// <summary>
        /// 券生效的方式，目前支持以下方式  立即生效：IMMEDIATELY  延迟生效：DELAY  仅在券有效期类型为相对有效期时生效
        /// </summary>
        [JsonPropertyName("effect_type")]
        public string EffectType { get; set; }

        /// <summary>
        /// 券有效期的结束时间  仅在券有效期类型为绝对有效期时生效  必须晚于活动结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 券的扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 券的说明条款
        /// </summary>
        [JsonPropertyName("inteligent_clause_terms")]
        public List<InteligentClauseTerm> InteligentClauseTerms { get; set; }

        /// <summary>
        /// 延迟生效信息
        /// </summary>
        [JsonPropertyName("inteligent_delay_info")]
        public InteligentDelayInfo InteligentDelayInfo { get; set; }

        /// <summary>
        /// 券使用说明描述列表
        /// </summary>
        [JsonPropertyName("inteligent_desc_detail_list")]
        public List<InteligentVoucherDescDetail> InteligentDescDetailList { get; set; }

        /// <summary>
        /// 券的展示信息
        /// </summary>
        [JsonPropertyName("inteligent_display_config")]
        public InteligentDisplayConfig InteligentDisplayConfig { get; set; }

        /// <summary>
        /// 单品信息  兑换券不允许设置单品信息  减至券必须设置单品信息  其他类型券可按需设置
        /// </summary>
        [JsonPropertyName("inteligent_item_info")]
        public InteligentItemInfo InteligentItemInfo { get; set; }

        /// <summary>
        /// 券的使用规则信息
        /// </summary>
        [JsonPropertyName("inteligent_use_rule")]
        public InteligentUseRule InteligentUseRule { get; set; }

        /// <summary>
        /// 券LOGO文件ID，调用图片上传接口alipay.offline.material.image.upload获得
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 最高优惠金额，单位元  指用券最高可以优惠的金额  必须为合法金额类型字符串仅当券类型为折扣券（RATE），每满减券（PER_FULL_CUT）有效
        /// </summary>
        [JsonPropertyName("max_amount")]
        public string MaxAmount { get; set; }

        /// <summary>
        /// 券叠加的属性，  仅全场券可设置该选项；  NO_MULTI:不可与其他全场券和单品券叠加;  MULTI_USE_WITH_SINGLE:  该全场优惠和单品优惠的叠加  ；MULTI_USE_WITH_OTHE  RS:该全场优惠和其他所有优惠都可以叠加
        /// </summary>
        [JsonPropertyName("multi_use_mode")]
        public string MultiUseMode { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 折扣率  仅当券类型为折扣券时有效  有效折扣率取值范围0.11-0.99  仅允许保留小数点后两位
        /// </summary>
        [JsonPropertyName("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 券相对有效期，单位天  仅在券有效期类型为相对有效期时生效  如，设5表示领券领取后5日内有效
        /// </summary>
        [JsonPropertyName("relative_time")]
        public string RelativeTime { get; set; }

        /// <summary>
        /// 券核销时，抹零方式，目前支持：  NOT_AUTO_ROUNDING:不自动抹零  AUTO_ROUNDING_YUAN:自动抹零到元  AUTO_ROUNDING_JIAO:自动抹零到角  ROUNDING_UP_YUAN:四舍五入到元  ROUNDING_UP_JIAO:四舍五入到角
        /// </summary>
        [JsonPropertyName("rounding_rule")]
        public string RoundingRule { get; set; }

        /// <summary>
        /// 券有效期的开始时间  仅在券有效期类型为绝对有效期时生效
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 券类型，目前支持以下类型：  MONEY：代金券；  PER_FULL_CUT：每满减券
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 券的使用说明  使用须知最多6条，且每条最多100字
        /// </summary>
        [JsonPropertyName("use_instructions")]
        public List<string> UseInstructions { get; set; }

        /// <summary>
        /// 券有效期类型，目前支持以下类型：  RELATIVE：相对有效期  FIXED：绝对有效期
        /// </summary>
        [JsonPropertyName("validate_type")]
        public string ValidateType { get; set; }

        /// <summary>
        /// 该字段仅在兑换券条件下(即券类型为EXCHANGE)，用于设置兑换券的核销方式  USER_CLICK:用户自己点击券上的按钮核销  MERCHANT_SCAN：商户通过APP扫码核销  其他情况下此字段为空
        /// </summary>
        [JsonPropertyName("verify_mode")]
        public string VerifyMode { get; set; }

        /// <summary>
        /// 券图片文件ID,调用上传图片接口alipay.offline.material.image.upload获得
        /// </summary>
        [JsonPropertyName("voucher_img")]
        public string VoucherImg { get; set; }

        /// <summary>
        /// 券的备注    用于收银系统识别指定券使用；如备注中传入“123”，券发出后核销时将在当面付接口将该值传回，供收银系统识别
        /// </summary>
        [JsonPropertyName("voucher_note")]
        public string VoucherNote { get; set; }

        /// <summary>
        /// 券面额，单位元必须为合法金额类型字符串券类型为代金券（MONEY）、减至券（REDUCETO）、每满减券（PER_FULL_CUT）时必填  如：  代金券：10元代金券中的10为券面额；  每满减券：毎满100减10元，其中的10为券面额；  减至券：单品原价100，现价10元，其中10为券面额，单品减至券的券面额必须低于单品原价
        /// </summary>
        [JsonPropertyName("worth_value")]
        public string WorthValue { get; set; }
    }
}
