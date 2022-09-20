namespace Essensoft.Paylink.WeChatPay.V3.Request;

public class WechatPayEcommerceApplymentsRequest : IWeChatPayPrivacyPostRequest<WeChatPayResponse>
{
    private WeChatPayObject bodyModel;

    public string GetRequestUrl()
    {
        return "https://api.mch.weixin.qq.com/v3/ecommerce/applyments/";
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
