using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceGasInfoGroupcouponQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceGasInfoGroupcouponQueryModel : AlipayObject
    {
        /// <summary>
        /// 劵创建结束时间:格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("create_end_time")]
        public string CreateEndTime { get; set; }

        /// <summary>
        /// 劵创建开始时间:格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("create_start_time")]
        public string CreateStartTime { get; set; }

        /// <summary>
        /// 当前页码,不填写默认第一页
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页显示数,不填写默认10条
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// shop_id和partner_id不能同时为空
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// ENABLED:可用,多个状态逗号分开,DISABLED:不可用, 多个逗号分隔，例如:ENABLED,DISABLED
        /// </summary>
        [JsonPropertyName("voucher_status")]
        public string VoucherStatus { get; set; }
    }
}
