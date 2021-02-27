using Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.V3;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Request
{
    /// <summary>
    ///  微信支付分 - 修改订单金额API
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_17.shtml">修改订单金额API</a></para>
    /// </summary>
    public class WeChatPayScoreServiceOrderModifyRequest : IWeChatPayPostRequest<WeChatPayScoreServiceOrderModifyResponse>
    {
        private WeChatPayObject _bodyModel;

        public string OutOrderNo { get; set; }

        public WeChatPayObject GetBodyModel()
        {
            return _bodyModel;
        }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/payscore/serviceorder/{OutOrderNo}/modify";
        }

        public void SetBodyModel(WeChatPayObject bodyModel)
        {
            _bodyModel = bodyModel;
        }
    }
}
