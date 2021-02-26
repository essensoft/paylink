using Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.V3;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Request
{
    /// <summary>
    ///  微信支付分 - 查询支付分订单API
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_15.shtml">查询支付分订单API</a></para>
    /// </summary>
    public class WeChatPayScoreServiceOrderQueryRequest : IWeChatPayGetRequest<WeChatPayScoreServiceOrderQueryResponse>
    {
        private WeChatPayObject _queryModel;

        public WeChatPayObject GetQueryModel()
        {
            return _queryModel;
        }

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/payscore/serviceorder";
        }

        public void SetQueryModel(WeChatPayObject queryModel)
        {
            _queryModel = queryModel;
        }
    }
}
