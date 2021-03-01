using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付 - 合单支付 - JSAPI下单API、小程序下单
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_3.shtml">合单支付 - 合单JSAPI下单API</a> - 最新更新时间：2020.05.21</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_4.shtml">合单支付 - 合单小程序下单API</a> - 最新更新时间：2020.05.21</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/combine/chapter3_2.shtml">合单下单 - JSAPI支付/小程序支付API</a> - 最新更新时间：2020.05.21</para>
    /// </remarks>
    public class WeChatPayCombineTransactionsJsApiRequest : IWeChatPayPostRequest<WeChatPayCombineTransactionsJsApiResponse>
    {
        private WeChatPayObject bodyModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/combine-transactions/jsapi";
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
