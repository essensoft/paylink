using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public interface IWeChatPaySdkRequest
    {
        /// <summary>
        /// 获取所有的Key-Value形式的文本请求参数字典。其中：
        /// Key: 请求参数名
        /// Value: 请求参数文本值
        /// </summary>
        /// <returns>文本请求参数字典</returns>
        IDictionary<string, string> GetParameters();

        /// <summary>
        /// 请求参数处理器
        /// </summary>
        /// <param name="options"></param>
        /// <param name="sortedTxtParams"></param>
        void PrimaryHandler(WeChatPayOptions options, WeChatPayDictionary sortedTxtParams);
    }
}
