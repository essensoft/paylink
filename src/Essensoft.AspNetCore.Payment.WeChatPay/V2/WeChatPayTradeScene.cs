namespace Essensoft.AspNetCore.Payment.WeChatPay.V2
{
    /// <summary>
    /// 交易场景
    /// </summary>
    public static class WeChatPayTradeScene
    {
        /// <summary>
        /// 车场停车场景
        /// </summary>
        public const string Parking = "PARKING";

        /// <summary>
        /// 车位停车场景
        /// </summary>
        public const string Parking_Space = "PARKING SPACE";

        /// <summary>
        /// 加油场景
        /// </summary>
        public const string Gas = "GAS";

        /// <summary>
        /// 高速场景
        /// </summary>
        public const string HighWay = "HIGHWAY";

        /// <summary>
        /// 路桥场景
        /// </summary>
        public const string Bridge = "BRIDGE";

        /// <summary>
        /// 地铁场景
        /// </summary>
        public const string Metro = "METRO";

        /// <summary>
        /// 公交场景
        /// </summary>
        public const string Bus = "BUS";
    }
}
