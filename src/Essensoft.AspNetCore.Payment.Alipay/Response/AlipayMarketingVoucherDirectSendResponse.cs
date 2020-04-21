using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingVoucherDirectSendResponse.
    /// </summary>
    public class AlipayMarketingVoucherDirectSendResponse : AlipayResponse
    {
        /// <summary>
        /// 资产编码
        /// </summary>
        [JsonPropertyName("assets_code")]
        public string AssetsCode { get; set; }

        /// <summary>
        /// 可用金额（单位：分）。
        /// </summary>
        [JsonPropertyName("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 总现金价值（单位：分）
        /// </summary>
        [JsonPropertyName("available_cash")]
        public string AvailableCash { get; set; }

        /// <summary>
        /// 扩展信息，json格式。  1.activityUrl：活动链接地址  2.activityId：活动ID  3.extends：其它扩展信息
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 模板扩展信息
        /// </summary>
        [JsonPropertyName("extend_template_info")]
        public string ExtendTemplateInfo { get; set; }

        /// <summary>
        /// 券生效时间，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonPropertyName("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 券创建时间，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 券失效时间，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonPropertyName("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 展期，格式为yyyy-MM-dd HH:mm:ss。  如果退款时间超过失效时间，但是未到展期，将失效时间改成展期实际时间。
        /// </summary>
        [JsonPropertyName("gmt_extend")]
        public string GmtExtend { get; set; }

        /// <summary>
        /// 券修改时间，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 券状态。  1.ENABLED：可用  2.DISABLED：不可用
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 总金额（面额）（单位：分）。
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 总现金价值（单位：分）。
        /// </summary>
        [JsonPropertyName("total_cash")]
        public string TotalCash { get; set; }

        /// <summary>
        /// 用户的支付宝账号对应的支付宝唯一用户号。  以2088开头的16位纯数字组成。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 券描述信息，json格式。  description：券描述信息。
        /// </summary>
        [JsonPropertyName("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 劵ID
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
