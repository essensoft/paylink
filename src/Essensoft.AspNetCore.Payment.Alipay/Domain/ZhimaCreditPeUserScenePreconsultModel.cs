using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeUserScenePreconsultModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeUserScenePreconsultModel : AlipayObject
    {
        /// <summary>
        /// 申请免押金额，取值范围[0.01,100000000]，精确到小数点后2位
        /// </summary>
        [JsonPropertyName("apply_amount")]
        public string ApplyAmount { get; set; }

        /// <summary>
        /// 买家的蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 芝麻信用类目码，由芝麻信用侧分配
        /// </summary>
        [JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 芝麻信用场景，由芝麻信用侧分配，如：极速退等
        /// </summary>
        [JsonPropertyName("credit_scene")]
        public string CreditScene { get; set; }

        /// <summary>
        /// 业务扩展参数，json格式字符串，如果有需要，请提前联系开发人员沟通确定参数
        /// </summary>
        [JsonPropertyName("ext_params")]
        public string ExtParams { get; set; }

        /// <summary>
        /// 接入商家的订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 风险环境参数信息，json格式字符串，目前已知key如下：umid，设备指纹；imei，设备号；lbs，经纬度；ip，设备网络IP地址；wireless_mac，设备无线wifi mac；mac，设备网卡地址
        /// </summary>
        [JsonPropertyName("risk_info")]
        public string RiskInfo { get; set; }

        /// <summary>
        /// 卖家（商家）支付宝id
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }
    }
}
