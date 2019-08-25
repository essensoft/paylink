using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringOrderPayDisburseModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderPayDisburseModel : AlipayObject
    {
        /// <summary>
        /// 支付授权码，25~30开头的长度为16~24位的数字，实际字符串长度以开发者获取的付款码长度为准
        /// </summary>
        [JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 是否享受会员价。如果为true，菜明细里面会按照会员价（没有改价情况下）作为单品价格咨询单品券优惠
        /// </summary>
        [JsonProperty("member_flag")]
        public bool MemberFlag { get; set; }

        /// <summary>
        /// 外部支付订单号，唯一标识本次支付的requestID
        /// </summary>
        [JsonProperty("out_pay_no")]
        public string OutPayNo { get; set; }

        /// <summary>
        /// pos业务订单外部主键信息
        /// </summary>
        [JsonProperty("pos_order_key")]
        public PosOrderKey PosOrderKey { get; set; }

        /// <summary>
        /// 交易超时时间  选填，默认3分钟.透传给交易，设置可支持如下格式：d:天，h:小时,m:分钟。 示例：5d,1h,3m
        /// </summary>
        [JsonProperty("timeout")]
        public string Timeout { get; set; }

        /// <summary>
        /// 订单付款金额，以元为单位，精确到分
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 是否整单不可打折
        /// </summary>
        [JsonProperty("undiscountable")]
        public bool Undiscountable { get; set; }
    }
}
