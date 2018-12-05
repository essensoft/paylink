using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    /// <summary>
    /// WeChatPay 请求。
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
    }
}
