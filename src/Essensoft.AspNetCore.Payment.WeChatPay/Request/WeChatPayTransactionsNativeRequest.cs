using Essensoft.AspNetCore.Payment.WeChatPay.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// Native下单API
    /// 最新更新时间：2020.05.26
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter3_3.shtml
    /// </summary>
    public class WeChatPayTransactionsNativeRequest : IWeChatPayV3PostRequest<WeChatPayTransactionsNativeResponse>
    {
        private WeChatPayObject bizModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/pay/transactions/native";
        }

        public WeChatPayObject GetBizModel()
        {
            return bizModel;
        }

        public void SetBizModel(WeChatPayObject bizModel)
        {
            this.bizModel = bizModel;
        }
    }
}
