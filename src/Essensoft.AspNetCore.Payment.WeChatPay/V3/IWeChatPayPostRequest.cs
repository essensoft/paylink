namespace Essensoft.AspNetCore.Payment.WeChatPay.V3
{
    public interface IWeChatPayPostRequest<T> where T : WeChatPayResponse
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
