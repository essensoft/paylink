using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeUserCreditFreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeUserCreditFreezeModel : AlipayObject
    {
        /// <summary>
        /// 买家的支付宝用户id
        /// </summary>
        [JsonProperty("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 商户侧类目码，需要商户在芝麻平台进行配置
        /// </summary>
        [JsonProperty("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 芝麻信用场景，由芝麻信用侧分配，如：天猫信用购，淘宝租赁等
        /// </summary>
        [JsonProperty("credit_scene")]
        public string CreditScene { get; set; }

        /// <summary>
        /// 订单基本信息，json格式字符串，可传入订单扩展信息
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 接入商家的订单号
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 风险环境参数信息，json格式字符串，目前已知key如下：umid，设备指纹；imei，设备号；lbs，经纬度；ip，设备网络IP地址；wireless_mac，设备无线wifi mac；mac，设备网卡地址
        /// </summary>
        [JsonProperty("risk_info")]
        public string RiskInfo { get; set; }

        /// <summary>
        /// 卖家的支付宝id
        /// </summary>
        [JsonProperty("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 子订单模型，至少包含一个子订单信息
        /// </summary>
        [JsonProperty("sub_order_info")]
        public List<CreditFreezeSubOrder> SubOrderInfo { get; set; }

        /// <summary>
        /// 信用额度待冻结额度，单位为元，取值范围[0.01,100000000]，精确到小数点后2位
        /// </summary>
        [JsonProperty("total_credit_amount")]
        public string TotalCreditAmount { get; set; }
    }
}
