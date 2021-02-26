using Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.V3;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Request
{
    /// <summary>
    ///  微信支付分 - 解除用户授权关系（openid）
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_6.shtml">解除用户授权关系（openid）API</a></para>
    /// </summary>
    public class WeChatPayScorePermissionsTerminateForOpenIdRequest : IWeChatPayPostRequest<WeChatPayScorePermissionsTerminateForOpenIdResponse>
    {
        private WeChatPayObject _bodyModel;

        /// <summary>
        /// 用户标识。
        /// </summary>
        public string OpenId { get; set; }

        public WeChatPayObject GetBodyModel()
        {
            return _bodyModel;
        }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/payscore/permissions/openid/{OpenId}/terminate";
        }

        public void SetBodyModel(WeChatPayObject bodyModel)
        {
            _bodyModel = bodyModel;
        }
    }
}
