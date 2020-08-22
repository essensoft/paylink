using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2
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
        string GetRequestUrl();

        /// <summary>
        /// 设置请求接口地址
        /// </summary>
        void SetRequestUrl(string url);

        /// <summary>
        /// 获取文本请求参数字典
        /// </summary>
        IDictionary<string, string> GetParameters();

        /// <summary>
        /// 获取签名类型
        /// </summary>
        WeChatPaySignType GetSignType()
        {
            return WeChatPaySignType.MD5;
        }

        /// <summary>
        /// 基本参数处理器
        /// </summary>
        /// <param name="options">配置选项</param>
        /// <param name="signType">签名类型</param>
        /// <param name="sortedTxtParams">排序文本参数</param>
        void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams);

        /// <summary>
        /// 是否需要检查响应内容签名
        /// </summary>
        bool GetNeedCheckSign()
        {
            return true;
        }
    }
}
