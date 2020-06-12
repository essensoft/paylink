namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public interface IWeChatPayV3PostRequest<T> where T : WeChatPayV3Response
    {
        /// <summary>
        /// 请求URL
        /// </summary>
        string GetRequestUrl();

        /// <summary>
        /// 获取BizModel
        /// </summary>
        WeChatPayObject GetBizModel();

        /// <summary>
        /// 设置BizModel
        /// </summary>
        /// <param name="bizModel"></param>
        void SetBizModel(WeChatPayObject bizModel);
    }
}
