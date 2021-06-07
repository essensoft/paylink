using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 资金应用 - 分账 - 解冻剩余资金
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter8_1_5.shtml">分账 - 解冻剩余资金API</a> - 最新更新时间：2021.05.11</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_1_5.shtml">分账(服务商) - 解冻剩余资金API</a> - 最新更新时间：2021.05.11</para>
    /// </remarks>
    public class WeChatPayProfitSharingOrdersUnfreezeRequest : IWeChatPayPostRequest<WeChatPayProfitSharingOrdersUnfreezeResponse>
    {
        private WeChatPayObject bodyModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/profitsharing/orders/unfreeze";
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
