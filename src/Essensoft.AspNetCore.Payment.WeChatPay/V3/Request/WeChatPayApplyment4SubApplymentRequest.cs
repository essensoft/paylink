using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 商户进件（普通服务商）- 提交申请单API
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/tool/applyment4sub/chapter3_1.shtml">提交申请单API</a></para>
    /// 最新更新时间：2019.04.10
    /// </summary>
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
