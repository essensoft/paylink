namespace Essensoft.AspNetCore.Payment.WeChatPay.V2
{
    /// <summary>
    /// 用户状态
    /// </summary>
    public static class WeChatPayUserState
    {
        /// <summary>
        /// 正常用户，已开通车主服务，且已授权访问
        /// </summary>
        public const string Normal = "NORMAL";

        /// <summary>
        /// 已暂停车主服务
        /// </summary>
        public const string Paused = "PAUSED";

        /// <summary>
        /// 用户已开通车主服务，但欠费状态。提示用户还款，请跳转到车主服务
        /// </summary>
        public const string Overdue = "OVERDUE";

        /// <summary>
        /// 用户未授权使用当前业务，或未开通车主服务。请跳转到授权接口
        /// </summary>
        public const string Unauthorized = "UNAUTHORIZED";
    }
}
