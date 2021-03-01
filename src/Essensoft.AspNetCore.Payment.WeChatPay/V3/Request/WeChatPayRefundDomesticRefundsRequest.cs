using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付 - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 申请退款
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_9.shtml">JSAPI支付 - 申请退款API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_9.shtml">APP支付 - 申请退款API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_9.shtml">H5支付 - 申请退款API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_9.shtml">Native支付 - 申请退款API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_9.shtml">小程序支付 - 申请退款API</a> - 最新更新时间：2021.01.15</para>
    /// </remarks>
    public class WeChatPayRefundDomesticRefundsRequest : IWeChatPayPostRequest<WeChatPayRefundDomesticRefundsResponse>
    {
        private WeChatPayObject bodyModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/refund/domestic/refunds";
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
