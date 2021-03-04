using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 微信支付分 - 解除用户授权关系（授权协议号）
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_4.shtml">微信支付分 - 解除用户授权关系（授权协议号）API</a> - 最新更新时间：2020.07.20</para>
    /// </remarks>
    public class WeChatPayScorePermissionsTerminateForAuthCodeRequest : IWeChatPayPostRequest<WeChatPayScorePermissionsTerminateForAuthCodeResponse>
    {
        private WeChatPayObject bodyModel;

        /// <summary>
        /// 授权协议号
        /// </summary>
        /// <remarks>
        /// 预授权成功时的授权协议号
        /// <para>示例值：1234323JKHDFE1243252</para>
        /// </remarks>
        public string AuthorizationCode { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/payscore/permissions/authorization-code/{AuthorizationCode}/terminate";
        }

        public WeChatPayObject GetBodyModel()
        {
            return bodyModel;
        }

        public void SetBodyModel(WeChatPayObject bodyModel)
        {
            this.bodyModel = bodyModel;
        }
    }
}
