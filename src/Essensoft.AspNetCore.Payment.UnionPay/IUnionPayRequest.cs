using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.UnionPay
{
    public interface IUnionPayRequest<T> where T : UnionPayResponse
    {
        /// <summary>
        /// API接口地址
        /// </summary>
        /// <returns></returns>
        string GetRequestUrl(bool isTest);

        /// <summary>
        /// 获取API版本
        /// </summary>
        /// <returns></returns>
        string GetApiVersion();

        /// <summary>
        /// 设置API版本
        /// </summary>
        /// <param name="version"></param>
        void SetApiVersion(string version);

        /// <summary>
        /// 是否有加密证书ID参数
        /// </summary>
        /// <returns></returns>
        bool HasEncryptCertId();

        /// <summary>
        /// 获取所有的Key-Value形式的文本请求参数字典。其中：
        /// Key: 请求参数名
        /// Value: 请求参数文本值
        /// </summary>
        /// <returns>文本请求参数字典</returns>
        IDictionary<string, string> GetParameters();
    }
}
