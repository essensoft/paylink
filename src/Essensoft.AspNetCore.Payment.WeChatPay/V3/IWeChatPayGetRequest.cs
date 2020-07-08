namespace Essensoft.AspNetCore.Payment.WeChatPay.V3
{
    public interface IWeChatPayGetRequest<T> where T : WeChatPayResponse
    {
        /// <summary>
        /// 请求URL
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
