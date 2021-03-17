using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付(服务商) - APP支付 - 统一下单
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_1.shtml">APP支付 - 统一下单API</a> - 最新更新时间：2020.11.12</para>
    /// </remarks>
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
