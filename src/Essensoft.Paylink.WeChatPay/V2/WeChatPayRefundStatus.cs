namespace Essensoft.Paylink.WeChatPay.V2
{
    /// <summary>
    /// 退款状态
    /// </summary>
    public static class WeChatPayRefundStatus
    {
        /// <summary>
        /// 退款成功
        /// </summary>
        public const string Success = "SUCCESS";

        /// <summary>
        /// 退款异常
        /// </summary>
        public const string Change = "CHANGE";

        /// <summary>
        /// 退款关闭
        /// </summary>
        public const string RefundClose = "REFUNDCLOSE";
    }
}
