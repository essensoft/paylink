using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Notify
{
    /// <summary>
    /// 资金授权撤销
    /// 更新时间：2019-08-28
    /// https://docs.open.alipay.com/20180417160701241302/axpg8p/
    /// 参考其他通知额外补充了 公共参数
    /// </summary>
    public class AlipayFundAuthOperationCancelNotify : AlipayNotify
    {
        // 公共参数

        /// <summary>
        /// 通知时间
        /// </summary>
        [JsonProperty("notify_time")]
        public string NotifyTime { get; set; }

        /// <summary>
        /// 通知类型
        /// </summary>
        [JsonProperty("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 通知校验ID
        /// </summary>
        [JsonProperty("notify_id")]
        public string NotifyId { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 授权方的app_id
        /// </summary>
        [JsonProperty("auth_app_id")]
        public string AuthAppId { get; set; }

        // 业务参数

        /// <summary>
        /// 支付宝资金授权订单号
        /// </summary>
        [JsonProperty("auth_no")]
        public string AuthNo { get; set; }

        /// <summary>
        /// 商户的资金授权订单号
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付宝的资金操作流水号
        /// </summary>
        [JsonProperty("operation_id")]
        public string OperationId { get; set; }

        /// <summary>
        /// 商户资金操作流水号
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 本次撤销触发的资金动作close：关闭冻结明细，无资金解冻unfreeze：产生了资金解冻
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }
    }
}
