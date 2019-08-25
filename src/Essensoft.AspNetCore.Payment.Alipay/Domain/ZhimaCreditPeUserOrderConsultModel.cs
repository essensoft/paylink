using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeUserOrderConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeUserOrderConsultModel : AlipayObject
    {
        /// <summary>
        /// 申请免押金额，取值范围[0.01,100000000]，精确到小数点后2位
        /// </summary>
        [JsonProperty("apply_amount")]
        public string ApplyAmount { get; set; }

        /// <summary>
        /// 买家的蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 芝麻信用类目码，由芝麻信用侧分配
        /// </summary>
        [JsonProperty("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 芝麻信用场景，由芝麻信用侧分配，如：天猫信用购，淘宝租赁等
        /// </summary>
        [JsonProperty("credit_scene")]
        public string CreditScene { get; set; }

        /// <summary>
        /// 业务扩展参数，json格式字符串，如果有需要，请提前联系开发人员沟通确定参数
        /// </summary>
        [JsonProperty("ext_params")]
        public string ExtParams { get; set; }

        /// <summary>
        /// 接入商家的订单号
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 风险环境参数信息，json格式字符串，目前已知key如下：umid，设备指纹；imei，设备号；lbs，经纬度；ip，设备网络IP地址；wireless_mac，设备无线wifi mac；mac，设备网卡地址
        /// </summary>
        [JsonProperty("risk_info")]
        public string RiskInfo { get; set; }

        /// <summary>
        /// 卖家（商家）支付宝id
        /// </summary>
        [JsonProperty("seller_id")]
        public string SellerId { get; set; }
    }
}
