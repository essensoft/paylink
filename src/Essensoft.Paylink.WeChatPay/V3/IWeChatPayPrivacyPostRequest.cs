namespace Essensoft.Paylink.WeChatPay.V3
{
    /// <summary>
    /// WeChatPay V3 Post敏感信息请求接口
    /// </summary>
    /// <typeparam name="T">请求响应对象</typeparam>
    public interface IWeChatPayPrivacyPostRequest<T> where T : WeChatPayResponse
    {
        /// <summary>
        /// 获取请求接口地址
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
