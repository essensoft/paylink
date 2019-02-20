using Microsoft.Extensions.Logging;

namespace Essensoft.AspNetCore.Payment.LcswPay
{
    /// <summary>
    /// 利楚商务扫呗支付配置信息
    /// </summary>
    public class LcswPayOption
    {
        /// <summary>
        /// api基准地址
        /// </summary>
        public string ApiBaseUrl { get; set; }
        /// <summary>
        /// 接入的api版本
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// 扫呗商户号
        /// </summary>
        public string MerchantNo { get; set; }
        /// <summary>
        /// 扫呗终端号
        /// </summary>
        public string TerminalId { get; set; }
        /// <summary>
        /// 访问令牌
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// 日志等级
        /// </summary>
        public LogLevel LogLevel { get; set; } = LogLevel.Information;
    }
}
