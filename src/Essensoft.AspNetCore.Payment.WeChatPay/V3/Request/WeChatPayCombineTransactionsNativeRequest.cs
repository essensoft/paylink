using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付 - 合单支付 - 合单Native支付API（电商平台、服务商、直连商户）
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_5.shtml">合单Native支付API</a></para>
    /// 最新更新时间：2020.05.14
    /// </summary>
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
