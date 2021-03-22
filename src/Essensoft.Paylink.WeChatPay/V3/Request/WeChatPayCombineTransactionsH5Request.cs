using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付、基础支付(服务商) - 合单支付 - 合单H5支付
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_2.shtml">基础支付 - 合单支付 -  合单H5下单API</a> - 最新更新时间：2020.06.09</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_2.shtml">基础支付(服务商) - 合单支付 -  合单H5下单API</a> - 最新更新时间：2020.06.09</para>
    /// </remarks>
    public class WeChatPayCombineTransactionsH5Request : IWeChatPayPostRequest<WeChatPayCombineTransactionsH5Response>
    {
        private WeChatPayObject bodyModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/combine-transactions/h5";
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
