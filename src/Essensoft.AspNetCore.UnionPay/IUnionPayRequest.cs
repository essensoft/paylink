using System.Collections.Generic;

namespace Essensoft.AspNetCore.UnionPay
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
        /// 获取交易类型
        /// </summary>
        /// <returns></returns>
        string GetTxnType();

        /// <summary>
        /// 设置交易类型
        /// </summary>
        /// <param name="type"></param>
        void SetTxnType(string txnType);

        /// <summary>
        /// 获取交易子类
        /// </summary>
        /// <returns></returns>
        string GetTxnSubType();

        /// <summary>
        /// 设置交易子类
        /// </summary>
        /// <param name="type"></param>
        void SetTxnSubType(string txnSubType);

        /// <summary>
        /// 获取产品类型
        /// </summary>
        /// <returns></returns>
        string GetBizType();

        /// <summary>
        /// 设置产品类型
        /// </summary>
        /// <param name="type"></param>
        void SetBizType(string bizType);

        /// <summary>
        /// 获取渠道类型
        /// </summary>
        /// <returns></returns>
        string GetChannelType();

        /// <summary>
        /// 设置渠道类型
        /// </summary>
        /// <param name="type"></param>
        void SetChannelType(string channelType);

        /// <summary>
        /// 获取所有的Key-Value形式的文本请求参数字典。其中：
        /// Key: 请求参数名
        /// Value: 请求参数文本值
        /// </summary>
        /// <returns>文本请求参数字典</returns>
        IDictionary<string, string> GetParameters();
    }
}
