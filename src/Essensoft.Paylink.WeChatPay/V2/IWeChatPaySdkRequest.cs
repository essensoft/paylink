using System.Collections.Generic;

namespace Essensoft.Paylink.WeChatPay.V2
{
    /// <summary>
    /// WeChatPay V2 Sdk请求接口
    /// </summary>
    public interface IWeChatPaySdkRequest
    {
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
    }
}
