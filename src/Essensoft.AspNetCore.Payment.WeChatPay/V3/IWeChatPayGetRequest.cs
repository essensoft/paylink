namespace Essensoft.AspNetCore.Payment.WeChatPay.V3
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
        string GetRequestUrl();

        /// <summary>
        /// 是否需要检查响应内容签名
        /// </summary>
        bool GetNeedCheckSign()
        {
            return true;
        }
    }
}
