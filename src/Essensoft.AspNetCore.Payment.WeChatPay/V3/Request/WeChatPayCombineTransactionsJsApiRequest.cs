using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 合单JSAPI支付API、合单小程序下单API（电商平台、服务商、直连商户）
    /// 最新更新时间：2020.05.21
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_3.shtml
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_4.shtml
    /// </summary>
    public class WeChatPayCombineTransactionsJsApiRequest : IWeChatPayPostRequest<WeChatPayCombineTransactionsJsApiResponse>
    {
        private WeChatPayObject queryModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/combine-transactions/jsapi";
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
