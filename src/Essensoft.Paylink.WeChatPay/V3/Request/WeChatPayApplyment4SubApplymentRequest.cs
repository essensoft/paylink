using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 特约商户进件 - 提交申请单
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter11_1_1.shtml">特约商户进件 - 提交申请单API</a> - 最新更新时间：2019.04.10</para>
    /// </remarks>
    public class WeChatPayApplyment4SubApplymentRequest : IWeChatPayPrivacyPostRequest<WeChatPayApplyment4SubApplymentResponse>
    {
        private WeChatPayObject bodyModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/applyment4sub/applyment/";
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
