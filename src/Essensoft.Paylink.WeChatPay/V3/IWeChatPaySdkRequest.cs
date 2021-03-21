using System.Collections.Generic;

namespace Essensoft.Paylink.WeChatPay.V3
{
    /// <summary>
    /// WeChatPay V3 Sdk请求接口
    /// </summary>
    public interface IWeChatPaySdkRequest
    {
        /// <summary>
        /// 获取文本请求参数字典
        /// </summary>
        IDictionary<string, string> GetParameters();

        /// <summary>
        /// 参数处理器
        /// </summary>
        /// <param name="sortedTxtParams">排序文本参数</param>
        /// <param name="options">配置选项</param>
        void PrimaryHandler(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options);
    }
}
