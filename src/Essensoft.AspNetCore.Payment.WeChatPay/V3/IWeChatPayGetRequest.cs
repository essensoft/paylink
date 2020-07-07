namespace Essensoft.AspNetCore.Payment.WeChatPay.V3
{
    public interface IWeChatPayGetRequest<T> where T : WeChatPayResponse
    {
        /// <summary>
        /// 请求URL
        /// </summary>
        string GetRequestUrl();
    }
}
