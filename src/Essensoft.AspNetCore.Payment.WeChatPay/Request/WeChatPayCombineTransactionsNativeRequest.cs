using Essensoft.AspNetCore.Payment.WeChatPay.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 合单下单-Native支付API（电商平台、服务商、直连商户）
    /// 最新更新时间：2020.05.14
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/combine/chapter3_10.shtml
    /// </summary>
    public class WeChatPayCombineTransactionsNativeRequest : IWeChatPayV3PostRequest<WeChatPayCombineTransactionsNativeResponse>
    {
        private WeChatPayObject queryModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/combine-transactions/native";
        }

        public WeChatPayObject GetQueryModel()
        {
            return queryModel;
        }

        public void SetQueryModel(WeChatPayObject queryModel)
        {
            this.queryModel = queryModel;
        }
    }
}
