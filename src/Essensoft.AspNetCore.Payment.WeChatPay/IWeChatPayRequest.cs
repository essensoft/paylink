using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    /// <summary>
    /// WeChatPay 请求接口。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IWeChatPayRequest<T> where T : WeChatPayResponse
    {
        /// <summary>
        /// API接口地址
        /// </summary>
        /// <returns></returns>
        string GetRequestUrl();

        /// <summary>
        /// 获取所有的Key-Value形式的文本请求参数字典。其中：
        /// Key: 请求参数名
        /// Value: 请求参数文本值
        /// </summary>
        /// <returns>文本请求参数字典</returns>
        IDictionary<string, string> GetParameters();

        /// <summary>
        /// 是否验证响应内容签名
        /// </summary>
        /// <returns>是否验证</returns>
        bool IsCheckResponseSign();
        /// <summary>
        /// 是否支持Md5签名方式，有些请求是不支持此方式的。
        /// client在执行请求时，将根据此参数来决定使用哪种签名方式
        /// </summary>
        /// <returns>true:支持md5签名方式，false:不支持，只支持HMAC-SHA256方式</returns>
        bool IsSupportSignTypeMd5();
    }
}
