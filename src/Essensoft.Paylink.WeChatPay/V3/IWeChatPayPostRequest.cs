namespace Essensoft.Paylink.WeChatPay.V3
{
    /// <summary>
    /// WeChatPay V3 Post请求接口
    /// </summary>
    /// <typeparam name="T">请求响应对象</typeparam>
    public interface IWeChatPayPostRequest<T> where T : WeChatPayResponse
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
        void SetBodyModel(WeChatPayObject bodyModel);
    }
}
