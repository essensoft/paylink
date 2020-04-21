namespace Essensoft.AspNetCore.Payment.Alipay
{
    public static class AlipayTradeStatus
    {
        /// <summary>
        /// 交易创建，等待买家付款
        /// </summary>
        public const string Wait = "WAIT_BUYER_PAY";

        /// <summary>
        /// 未付款交易超时关闭，或支付完成后全额退款
        /// </summary>
        public const string Closed = "TRADE_CLOSED";

        /// <summary>
        /// 交易支付成功
        /// </summary>
        public const string Success = "TRADE_SUCCESS";

        /// <summary>
        /// 交易结束，不可退款
        /// </summary>
        public const string Finished = "TRADE_FINISHED";
    }
}
