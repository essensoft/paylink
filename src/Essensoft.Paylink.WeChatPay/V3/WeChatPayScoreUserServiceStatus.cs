namespace Essensoft.Paylink.WeChatPay.V3
{
    /// <summary>
    /// 用户授权状态
    /// </summary>
    public static class WeChatPayScoreUserServiceStatus
    {
        /// <summary>
        /// 授权成功
        /// </summary>
        public const string Opened = "USER_OPEN_SERVICE";

        /// <summary>
        /// 解除授权成功
        /// </summary>
        public const string Closed = "USER_CLOSE_SERVICE";
    }
}
