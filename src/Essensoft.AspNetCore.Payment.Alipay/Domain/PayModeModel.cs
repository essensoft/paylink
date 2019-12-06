using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PayModeModel Data Structure.
    /// </summary>
    public class PayModeModel : AlipayObject
    {
        /// <summary>
        /// 是否记账（false:否；true:是）
        /// </summary>
        [JsonPropertyName("accounting")]
        public bool Accounting { get; set; }

        /// <summary>
        /// 是否启用（false:关闭；true:开启）
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

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
        /// 支付类型（  CASH:现金;  BANK_CARD:银行卡;  ALIPAY:支付宝;  WX:微信;  HANGING_ACCOUNT:挂账;  FREE_ORDER:免单;  VOUCHER:票券;  TAKEOUT:外卖;  OTHER:其他  ）
        /// </summary>
        [JsonPropertyName("pay_code")]
        public string PayCode { get; set; }

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

        /// <summary>
        /// 支付排序
        /// </summary>
        [JsonPropertyName("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 是否系统（false:否；true:是）
        /// </summary>
        [JsonPropertyName("system")]
        public bool System { get; set; }
    }
}
