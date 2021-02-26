using Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.V3;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Request
{
    /// <summary>
    ///  微信支付分 - 商户预授权
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_2.shtml">商户预授权API</a></para>
    /// </summary>
    public class WeChatPayScorePermissionsRequest : IWeChatPayPostRequest<WeChatPayScorePermissionsResponse>
    {
        private WeChatPayObject _bodyModel;

        public WeChatPayObject GetBodyModel()
        {
            return _bodyModel;
        }

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/payscore/permissions";
        }

        public void SetBodyModel(WeChatPayObject bodyModel)
        {
            _bodyModel = bodyModel;
        }
    }
}
