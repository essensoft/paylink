using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public interface IWeChatPayCertRequest<T> where T : WeChatPayResponse
    {
        /// <summary>
        /// 获取API接口链接
        /// </summary>
        string GetRequestUrl();

        /// <summary>
        /// 获取所有的Key-Value形式的文本请求参数字典。其中：
        /// Key: 请求参数名
        /// Value: 请求参数文本值
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
