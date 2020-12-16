using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PreCreateWaybillIstd Data Structure.
    /// </summary>
    public class PreCreateWaybillIstd : AlipayObject
    {
        /// <summary>
        /// 优惠券费用
        /// </summary>
        [JsonPropertyName("coupon_fee")]
        public string CouponFee { get; set; }

        /// <summary>
        /// 运费
        /// </summary>
        [JsonPropertyName("deliver_fee")]
        public string DeliverFee { get; set; }

        /// <summary>
        /// 预计骑手还剩多久接单（单位：秒）
        /// </summary>
        [JsonPropertyName("dispatch_duration")]
        public long DispatchDuration { get; set; }

        /// <summary>
        /// 配送距离(单位：米)
        /// </summary>
        [JsonPropertyName("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// 实际运费
        /// </summary>
        [JsonPropertyName("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 保价费用
        /// </summary>
        [JsonPropertyName("insurance_fee")]
        public string InsuranceFee { get; set; }

        /// <summary>
        /// 即时配送公司编码
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 配送公司可以返回此字段，当商家下单时候带上这个字段，保证在一段时间内运费不变
        /// </summary>
        [JsonPropertyName("logistics_token")]
        public string LogisticsToken { get; set; }

        /// <summary>
        /// 支付金额，实际扣减的费用以此字段为准
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 即时配送公司服务代码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 即时配送公司返回的响应码。10000表示业务处理成功，40004表示业务处理失败。
        /// </summary>
        [JsonPropertyName("third_code")]
        public string ThirdCode { get; set; }

        /// <summary>
        /// 即时配送公司返回的错误码
        /// </summary>
        [JsonPropertyName("third_sub_code")]
        public string ThirdSubCode { get; set; }

        /// <summary>
        /// 即时配送公司返回的错误描述
        /// </summary>
        [JsonPropertyName("third_sub_msg")]
        public string ThirdSubMsg { get; set; }
    }
}
