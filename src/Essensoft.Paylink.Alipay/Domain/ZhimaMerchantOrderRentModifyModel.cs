using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantOrderRentModifyModel Data Structure.
    /// </summary>
    public class ZhimaMerchantOrderRentModifyModel : AlipayObject
    {
        /// <summary>
        /// 芝麻借还订单的开始借用时间，时间格式：yyyy-mm-dd hh:MM:ss。 注意： * borrow_time 与 expiry_time 须至少传入一个，可同时传入。 * 若同时传入 expiry_time（应归还时间），则传入的 borrow_time（开始借用时间）不能晚于 expiry_time； * 若未传入 expiry_time（应归还时间），则传入的 borrow_time（开始借用时间）不能晚于原有应归还时间。
        /// </summary>
        [JsonPropertyName("borrow_time")]
        public string BorrowTime { get; set; }

        /// <summary>
        /// 芝麻借还订单的应归还时间(到期时间)，时间格式：yyyy-mm-dd hh:MM:ss。 注意： * borrow_time 与 expiry_time 须至少传入一个，可同时传入。 * 传入的 expiry_time（应归还时间）不能早于原有应归还时间。
        /// </summary>
        [JsonPropertyName("expiry_time")]
        public string ExpiryTime { get; set; }

        /// <summary>
        /// 信用借还订单号，通过<a href="https://opendocs.alipay.com/apis/api_8/zhima.merchant.order.rent.create">zhima.merchant.order.rent.create</a>(信用借还订单创建(页面))接口创建信用借还订单后获取。
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 信用借还产品码，固定为：w1010100000000002858。
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }
    }
}
