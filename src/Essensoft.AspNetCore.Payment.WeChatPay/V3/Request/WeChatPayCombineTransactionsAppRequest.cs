using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付 - 合单支付 - 合单APP支付API（电商平台、服务商、直连商户）
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_1.shtml">合单APP支付API</a></para>
    /// 最新更新时间：2020.05.21
    /// </summary>
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
