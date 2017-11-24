using System.Collections.Generic;

namespace Essensoft.AspNetCore.WeChatPay
{
    public interface IWeChatPayCertificateRequest<T> where T : WeChatPayResponse
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
        /// 是否企业付款到零钱接口
        /// </summary>
        /// <returns></returns>
        bool GetIsTransfers();

        /// <summary>
        /// 是否企业付款到银行卡相关接口
        /// </summary>
        /// <returns></returns>
        bool GetIsBank();

        /// <summary>
        /// 是否企业付款到银行卡接口
        /// </summary>
        /// <returns></returns>
        bool GetIsPayBank();
    }
}
