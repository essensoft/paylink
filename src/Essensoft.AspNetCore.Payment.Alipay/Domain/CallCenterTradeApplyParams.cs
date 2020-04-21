using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CallCenterTradeApplyParams Data Structure.
    /// </summary>
    public class CallCenterTradeApplyParams : AlipayObject
    {
        /// <summary>
        /// 系统商编号，该参数作为系统商返佣数据提取的依据，请填写系统商签约协议的PID
        /// </summary>
        [JsonPropertyName("broker_id")]
        public string BrokerId { get; set; }

        /// <summary>
        /// 买家姓名
        /// </summary>
        [JsonPropertyName("buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 货币符号
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 设置未付款支付宝订单的超时时间，一旦超时，该笔订单就会自动失效。当商户调用接口时开始计时。取值精确至秒，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonPropertyName("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 第三方唯一序列号， 64个字符以内、可包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 优惠参数,用于传递营销信息。传递参数时，请所在行业的业务人员确认。
        /// </summary>
        [JsonPropertyName("promo_params")]
        public string PromoParams { get; set; }

        /// <summary>
        /// 交易标题/订单标题
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }
    }
}
