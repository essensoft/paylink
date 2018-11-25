using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Notify
{
    /// <summary>
    /// 签约类异步通知
    /// </summary>
    public class LianLianPayCardBindNotifyResponse : LianLianPayNotifyResponse
    {
        /// <summary>
        /// 商户编号是商户在连连支付支付平台上开设的商户号码，为18位数字，如：201304121000001004。
        /// </summary>
        [JsonProperty("oid_partner")]
        public string OidPartner { get; set; }

        /// <summary>
        /// 签名方式
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 商户订单时间。格式为 YYYYMMddHHmmss，HH以24小时为准，如 20180130161010。
        /// </summary>
        [JsonProperty("dt_order")]
        public string DtOrder { get; set; }

        /// <summary>
        /// 商户订单号。
        /// 为商户系统内对订单的唯一编号，保证唯一。
        /// 连连会根据NoOrder 创建连连订单号 OidPaybill，如NoOrder已有对应连连订单号 OidPaybill，则将请求视为重复订单请求。
        /// 重复发起订单请求时，请求中的参数信息需与原创单时一致。
        /// </summary>
        [JsonProperty("no_order")]
        public string NoOrder { get; set; }

        /// <summary>
        /// 签约结果，结果以此字段为准。
        /// 商户依此字段进行后续业务逻辑处理。
        /// SUCCESS，成功。
        /// </summary>
        [JsonProperty("result_sign")]
        public string ResultSign { get; set; }

        /// <summary>
        /// 签约协议编号，消费者使用银行卡支付后会生成。
        /// 签约规则及详情见签约说明。
        /// </summary>
        [JsonProperty("no_agree")]
        public string NoAgree { get; set; }

        /// <summary>
        /// 消费者在原支付请求中使用的卡号，卡号除前6后4以外的其他位数均为掩码形式，如621463******1234。
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }
    }
}
