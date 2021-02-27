using Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.V3;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Request
{
    /// <summary>
    ///  微信支付分 - 创单结单合并
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_1.shtml">创单结单合并API</a></para>
    /// </summary>
    public class WeChatPayScoreServiceOrderDirectCompleteRequest : IWeChatPayPostRequest<WeChatPayScoreServiceOrderDirectCompleteResponse>
    {
        private WeChatPayObject _bodyModel;

        public WeChatPayObject GetBodyModel()
        {
            return _bodyModel;
        }

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/payscore/serviceorder/direct-complete";
        }

        public void SetBodyModel(WeChatPayObject bodyModel)
        {
            _bodyModel = bodyModel;
        }
    }
}
