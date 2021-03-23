using System.Collections.Generic;

namespace Essensoft.Paylink.WeChatPay.V2
{
    /// <summary>
    /// WeChatPay V2 证书请求接口
    /// </summary>
    /// <typeparam name="T">请求响应对象</typeparam>
    public interface IWeChatPayCertRequest<T> where T : WeChatPayResponse
    {
        /// <summary>
        /// 获取请求接口地址
        /// </summary>
        /// <returns>接口地址</returns>
        string GetRequestUrl();

        /// <summary>
        /// 设置请求接口地址
        /// </summary>
        /// <param name="url">接口地址</param>
        void SetRequestUrl(string url);

        /// <summary>
        /// 获取文本参数字典
        /// </summary>
        /// <returns>文本参数字典</returns>
        IDictionary<string, string> GetParameters();

        /// <summary>
        /// 获取签名类型
        /// </summary>
        /// <returns>签名类型</returns>
        WeChatPaySignType GetSignType();

        /// <summary>
        /// 设置签名类型
        /// </summary>
        /// <param name="signType">签名类型</param>
        void SetSignType(WeChatPaySignType signType);

        /// <summary>
        /// 参数处理器
        /// </summary>
        /// <param name="sortedTxtParams">排序文本参数</param>
        /// <param name="options">配置选项</param>
        void PrimaryHandler(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options);

        /// <summary>
        /// 获取是否需要验签
        /// </summary>
        /// <returns>是否需要验签</returns>
        bool GetNeedCheckSign()
        {
            return true;
        }
    }
}
