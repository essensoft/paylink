using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 微信支付分 - 创单结单合并
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_1.shtml">微信支付分 - 创单结单合并API</a> - 最新更新时间：2020.04.23</para>
    /// </remarks>
    public class WeChatPayScoreServiceOrderDirectCompleteRequest : IWeChatPayPostRequest<WeChatPayScoreServiceOrderDirectCompleteResponse>
    {
        private WeChatPayObject bodyModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/payscore/serviceorder/direct-complete";
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
