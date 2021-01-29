using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付（服务商）- APP下单API
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter5_1.shtml">APP下单API</a></para>
    /// 最新更新时间：2020.11.12
    /// </summary>
    public class WeChatPayPartnerTransactionsAppRequest : IWeChatPayPostRequest<WeChatPayPartnerTransactionsAppResponse>
    {
        private WeChatPayObject bodyModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/pay/partner/transactions/app";
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
