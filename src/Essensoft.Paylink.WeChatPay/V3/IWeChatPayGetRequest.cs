namespace Essensoft.Paylink.WeChatPay.V3
{
    /// <summary>
    /// WeChatPay V3 Get请求接口
    /// </summary>
    /// <typeparam name="T">请求响应对象</typeparam>
    public interface IWeChatPayGetRequest<T> where T : WeChatPayResponse
    {
        /// <summary>
        /// 获取请求接口地址
        /// </summary>
        /// <returns>接口地址</returns>
        string GetRequestUrl();

        /// <summary>
        /// 获取URL参数模型
        /// </summary>
        /// <returns>URL参数模型</returns>
        WeChatPayObject GetQueryModel();

        /// <summary>
        /// 设置URL参数模型
        /// </summary>
        /// <param name="queryModel">URL参数模型</param>
        void SetQueryModel(WeChatPayObject queryModel);

        /// <summary>
        /// 获取是否需要验签
        /// </summary>
        /// <returns>是否需要验签</returns>
        bool GetNeedCheckSign()
        {
            return true;
        }

        /// <summary>
        /// 获取是否需要URL参数
        /// </summary>
        /// <returns>是否需要URL参数</returns>
        bool GetNeedQueryModel()
        {
            return true;
        }
    }
}
