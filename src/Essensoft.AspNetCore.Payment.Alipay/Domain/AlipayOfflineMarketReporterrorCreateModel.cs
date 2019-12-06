using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineMarketReporterrorCreateModel Data Structure.
    /// </summary>
    public class AlipayOfflineMarketReporterrorCreateModel : AlipayObject
    {
        /// <summary>
        /// 发生错误的时候，当前系统的毫秒数，系统会把当前时间构建成Date对象保存为错误发生时间
        /// </summary>
        [JsonPropertyName("err_time")]
        public long ErrTime { get; set; }

        /// <summary>
        /// 如果：type是tableNum  请设置table_num字段作为桌码
        /// </summary>
        [JsonPropertyName("feature")]
        public ReportErrorFeature Feature { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 上传类型，通过类型来区分不同错误： value=tableNum 代表扫码点菜
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 用户的ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
