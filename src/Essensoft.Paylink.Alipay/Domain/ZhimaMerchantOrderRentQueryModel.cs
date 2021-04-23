using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantOrderRentQueryModel Data Structure.
    /// </summary>
    public class ZhimaMerchantOrderRentQueryModel : AlipayObject
    {
        /// <summary>
        /// 外部订单号，需要唯一，由商户传入，芝麻内部会做幂等控制，格式为：yyyyMMddHHmmss+随机数。通过 <a href="https://opendocs.alipay.com/apis/api_8/zhima.merchant.order.rent.create">zhima.merchant.order.rent.create</a>(信用借还订单创建(页面))接口创建信用借还订单后获取。
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 信用借还的产品码，固定为：w1010100000000002858。
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }
    }
}
