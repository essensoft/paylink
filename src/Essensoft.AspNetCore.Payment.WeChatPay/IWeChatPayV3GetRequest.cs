namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public interface IWeChatPayV3GetRequest<T> where T : WeChatPayV3Response
    {
        /// <summary>
        /// 请求URL
        /// </summary>
        string GetRequestUrl();
    }
}
