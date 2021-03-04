namespace Essensoft.Paylink.WeChatPay.V3
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
        /// 退款关闭
        /// </summary>
        public const string Close = "CLOSE";

        /// <summary>
        /// 退款异常，退款到银行发现用户的卡作废或者冻结了，导致原路退款银行卡失败，可前往【服务商平台—>交易中心】，手动处理此笔退款
        /// </summary>
        public const string Abnormal = "ABNORMAL";
    }
}
