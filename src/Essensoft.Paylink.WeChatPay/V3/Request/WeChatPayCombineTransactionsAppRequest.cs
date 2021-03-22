using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付、基础支付(服务商) - 合单支付 - 合单APP下单
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_1.shtml">基础支付 - 合单支付 -  合单APP下单API</a> - 最新更新时间：2020.05.21</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_1.shtml">基础支付(服务商) - 合单支付 -  合单APP下单API</a> - 最新更新时间：2020.05.21</para>
    /// </remarks>
    public class WeChatPayCombineTransactionsAppRequest : IWeChatPayPostRequest<WeChatPayCombineTransactionsAppResponse>
    {
        private WeChatPayObject bodyModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/combine-transactions/app";
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
