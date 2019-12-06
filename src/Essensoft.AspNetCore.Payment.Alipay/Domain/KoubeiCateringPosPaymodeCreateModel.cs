using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosPaymodeCreateModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosPaymodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 固定面额
        /// </summary>
        [JsonPropertyName("fixed_amount")]
        public string FixedAmount { get; set; }

        /// <summary>
        /// 是否固定面额（false:否；true:是）
        /// </summary>
        [JsonPropertyName("fixed_switch")]
        public bool FixedSwitch { get; set; }

        /// <summary>
        /// 计入实收比例
        /// </summary>
        [JsonPropertyName("income_ratio")]
        public string IncomeRatio { get; set; }

        /// <summary>
        /// 支付方式名称
        /// </summary>
        [JsonPropertyName("pay_name")]
        public string PayName { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
