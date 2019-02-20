using Essensoft.AspNetCore.Payment.LcswPay.Utility;

namespace Essensoft.AspNetCore.Payment.LcswPay
{
    /// <summary>
    /// 利楚商务扫呗支付请求接口
    /// </summary>
    public interface ILcswPayResquest<T> where T:LcswPayResponse
    {

        /// <summary>
        /// 版本号，当前版本100
        /// </summary>
        string PayVersion { get; set; }
        /// <summary>
        /// 扫呗商户号
        /// </summary>
        string MerchantNo { get; set; }
        /// <summary>
        /// 扫呗终端号
        /// </summary>
        string TerminalId { get; set; }
        /// <summary>
        /// API接口地址,真实调用前，还需要在此地址的前面加上基准地址，构成完成的地址后进行请求
        /// </summary>
        /// <returns>API接口地址</returns>
        string GetRequestUrl();

        /// <summary>
        /// 获取请求相关的签名信息
        /// 包含签名参数信息和签名计算方式
        /// </summary>
        /// <returns>签名信息</returns>
        LcswPaySignInfo GetSignInfo();

        /// <summary>
        /// 是否验证响应内容签名
        /// </summary>
        /// <returns>是否验证</returns>
        bool IsCheckResponseSign();
    }
}
