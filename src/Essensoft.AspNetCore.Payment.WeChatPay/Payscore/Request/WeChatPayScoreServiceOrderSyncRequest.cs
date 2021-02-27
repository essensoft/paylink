using System;
using System.Collections.Generic;
using System.Text;
using Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.V3;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Request
{
    /// <summary>
    ///  微信支付分 - 同步服务订单信息
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_20.shtml">同步服务订单信息API</a></para>
    /// </summary>
    public class WeChatPayScoreServiceOrderSyncRequest : IWeChatPayPostRequest<WeChatPayScoreServiceOrderSyncResponse>
    {
        private WeChatPayObject _bodyModel;

        public string OutOrderNo { get; set; }

        public WeChatPayObject GetBodyModel()
        {
            return _bodyModel;
        }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/payscore/serviceorder/{OutOrderNo}/sync";
        }

        public void SetBodyModel(WeChatPayObject bodyModel)
        {
            _bodyModel = bodyModel;
        }
    }
}
