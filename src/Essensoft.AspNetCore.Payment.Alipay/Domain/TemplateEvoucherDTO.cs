using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateEvoucherDTO Data Structure.
    /// </summary>
    public class TemplateEvoucherDTO : AlipayObject
    {
        /// <summary>
        /// 卡券特性，不同类型pass对应的特定属性
        /// </summary>
        [JsonPropertyName("einfo")]
        public TemplateEInfoDTO Einfo { get; set; }

        /// <summary>
        /// 卡券失效时间（可与生效时间相同），以：YYYY-MM-dd HH:mm:ss 格式表示。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 卡券操作信息，支持文本、二维码、跳转链接等核销内容展示
        /// </summary>
        [JsonPropertyName("operations")]
        public List<TemplateOperationDTO> Operations { get; set; }

        /// <summary>
        /// 卡券的子类型，子类型有：cycle_coupon（周期券）；commodity_coupon（商品券）；discount_coupon（折扣券）；random_reduction_coupon（随机立减券）；reduced_to_coupon（减至券）；voucher（代金券/满减券）；exchange_coupon（兑换券）。
        /// </summary>
        [JsonPropertyName("pass_sub_type")]
        public string PassSubType { get; set; }

        /// <summary>
        /// 卡券的产品类型，目前支持：free（优惠券）、market（营销优惠券）、price（兑换券）。
        /// </summary>
        [JsonPropertyName("product")]
        public string Product { get; set; }

        /// <summary>
        /// 卡券利益点
        /// </summary>
        [JsonPropertyName("profit")]
        public TemplateProfitDTO Profit { get; set; }

        /// <summary>
        /// 提醒信息，用于在卡券生效或截止前提示用户
        /// </summary>
        [JsonPropertyName("remind_info")]
        public TemplateRemindDTO RemindInfo { get; set; }

        /// <summary>
        /// 卡券辅助核销区信息
        /// </summary>
        [JsonPropertyName("secondary_operation")]
        public TemplateSecondaryOperationDTO SecondaryOperation { get; set; }

        /// <summary>
        /// 卡券生效时间，以：YYYY-MM-dd HH:mm:ss 格式表示。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 卡券的名称，支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 卡券的类型，目前只支持：marketVoucher（优惠券）类型。可不填，不填将通过子类型自动匹配。
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
