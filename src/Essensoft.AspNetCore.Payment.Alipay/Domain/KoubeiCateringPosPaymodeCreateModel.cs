using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosPaymodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosPaymodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 固定面额
        /// </summary>
        [JsonProperty("fixed_amount")]
        public string FixedAmount { get; set; }

        /// <summary>
        /// 是否固定面额（false:否；true:是）
        /// </summary>
        [JsonProperty("fixed_switch")]
        public bool FixedSwitch { get; set; }

        /// <summary>
        /// 计入实收比例
        /// </summary>
        [JsonProperty("income_ratio")]
        public string IncomeRatio { get; set; }

        /// <summary>
        /// 支付方式名称
        /// </summary>
        [JsonProperty("pay_name")]
        public string PayName { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
