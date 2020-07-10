namespace Essensoft.AspNetCore.Payment.WeChatPay.V2
{
    /// <summary>
    /// 交易类型
    /// </summary>
    public static class WeChatPayTradeType
    {
        /// <summary>
        /// 公众号支付/小程序支付
        /// </summary>
        public const string JsApi = "JSAPI";

        /// <summary>
        /// 扫码支付
        /// </summary>
        public const string Native = "NATIVE";

        /// <summary>
        /// App支付
        /// </summary>
        public const string App = "APP";

        /// <summary>
        /// H5支付
        /// </summary>
        public const string H5 = "MWEB";
    }
}
