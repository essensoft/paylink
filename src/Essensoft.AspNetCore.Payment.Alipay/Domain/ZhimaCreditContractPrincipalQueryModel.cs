using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditContractPrincipalQueryModel Data Structure.
    /// </summary>
    public class ZhimaCreditContractPrincipalQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户加入合约成功后跳转的小程序地址
        /// </summary>
        [JsonPropertyName("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 外部类目,样例：BOOK：图书。目前仅支持图书，后续会开放更多类型
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 扩展字段，目前留空
        /// </summary>
        [JsonPropertyName("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 0:二维码扫描模式 1：扫码枪模式
        /// </summary>
        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 授权成功后的异步通知页面，一般为http的地址，在收到通知后，商户做自身的业务逻辑处理
        /// </summary>
        [JsonPropertyName("notify_addr")]
        public string NotifyAddr { get; set; }

        /// <summary>
        /// 外部订单号。需要商户确保唯一性。
        /// </summary>
        [JsonPropertyName("out_trans_no")]
        public string OutTransNo { get; set; }

        /// <summary>
        /// 以28开头的二维码字符串，在mode=1(扫码枪模式)下必须传
        /// </summary>
        [JsonPropertyName("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 信用服务id，商户入驻芝麻服务后，得到的服务id，在服务入驻后台可看到。
        /// </summary>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }
    }
}
