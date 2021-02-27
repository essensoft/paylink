using Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.V3;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Request
{
    /// <summary>
    ///  微信支付分 - 解除用户授权关系（授权协议号）
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_4.shtml">解除用户授权关系（授权协议号）API</a></para>
    /// </summary>
    public class WeChatPayScorePermissionsTerminateForAuthCodeRequest : IWeChatPayPostRequest<WeChatPayScorePermissionsTerminateForAuthCodeResponse>
    {
        private WeChatPayObject _bodyModel;

        /// <summary>
        /// 预授权成功时的授权协议号。
        /// </summary>
        public string AuthorizationCode { get; set; }

        public WeChatPayObject GetBodyModel()
        {
            return _bodyModel;
        }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/payscore/permissions/authorization-code/{AuthorizationCode}/terminate";
        }

        public void SetBodyModel(WeChatPayObject bodyModel)
        {
            _bodyModel = bodyModel;
        }
    }
}
