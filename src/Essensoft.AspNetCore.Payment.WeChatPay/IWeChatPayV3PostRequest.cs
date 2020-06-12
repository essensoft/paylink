namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public interface IWeChatPayV3PostRequest<T> where T : WeChatPayV3Response
    {
        /// <summary>
        /// 请求URL
        /// </summary>
        string GetRequestUrl();

        /// <summary>
        /// 获取QueryModel
        /// </summary>
        WeChatPayObject GetQueryModel();

        /// <summary>
        /// 设置QueryModel
        /// </summary>
        /// <param name="queryModel"></param>
        void SetQueryModel(WeChatPayObject queryModel);
    }
}
