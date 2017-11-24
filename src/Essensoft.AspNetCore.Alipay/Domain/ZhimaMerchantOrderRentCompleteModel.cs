using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantOrderRentCompleteModel Data Structure.
    /// </summary>
    public class ZhimaMerchantOrderRentCompleteModel : AlipayObject
    {
        /// <summary>
        /// 信用借还订单号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [JsonProperty("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 金额类型：  RENT:租金  DAMAGE:赔偿金
        /// </summary>
        [JsonProperty("pay_amount_type")]
        public string PayAmountType { get; set; }

        /// <summary>
        /// 信用借还的产品码:w1010100000000002858
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 物品归还门店名称
        /// </summary>
        [JsonProperty("restore_shop_name")]
        public string RestoreShopName { get; set; }

        /// <summary>
        /// 物品归还时间
        /// </summary>
        [JsonProperty("restore_time")]
        public string RestoreTime { get; set; }
    }
}
