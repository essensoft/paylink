namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public interface IWeChatPayV3PostRequest<T> where T : WeChatPayV3Response
    {
        /// <summary>
        /// 请求URL
        /// </summary>
        string GetRequestUrl();

        /// <summary>
        /// 获取BodyModel
        /// </summary>
        WeChatPayObject GetBodyModel();

        /// <summary>
        /// 设置BodyModel
        /// </summary>
        /// <param name="bodyModel"></param>
        void SetBodyModel(WeChatPayObject bodyModel);
    }
}
