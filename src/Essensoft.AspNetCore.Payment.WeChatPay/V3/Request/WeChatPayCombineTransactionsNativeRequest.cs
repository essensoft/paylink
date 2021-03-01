using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付 - 合单支付 - 合单Native下单
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_5.shtml">合单支付 - 合单Native下单API</a> - 最新更新时间：2020.05.14</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/combine/chapter3_10.shtml">合单下单 - Native支付API</a> - 最新更新时间：2020.05.14</para>
    /// </remarks>
    public class WeChatPayCombineTransactionsNativeRequest : IWeChatPayPostRequest<WeChatPayCombineTransactionsNativeResponse>
    {
        private WeChatPayObject bodyModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/combine-transactions/native";
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
