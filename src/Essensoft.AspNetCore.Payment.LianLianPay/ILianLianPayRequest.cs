using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    public interface ILianLianPayRequest<T> where T : LianLianPayResponse
    {
        /// <summary>
        /// API接口地址
        /// </summary>
        /// <returns></returns>
        string GetRequestUrl();

        /// <summary>
        /// 获取API版本
        /// </summary>
        /// <returns></returns>
        string GetApiVersion();

        /// <summary>
        /// 设置API版本
        /// </summary>
        /// <param name="apiVersion"></param>
        void SetApiVersion(string apiVersion);

        /// <summary>
        /// 获取所有的Key-Value形式的文本请求参数字典。其中：
        /// Key: 请求参数名
        /// Value: 请求参数文本值
        /// </summary>
        /// <returns>文本请求参数字典</returns>
        IDictionary<string, string> GetParameters();
    }
}
