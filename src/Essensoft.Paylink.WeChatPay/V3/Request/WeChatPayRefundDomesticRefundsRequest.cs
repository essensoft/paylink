using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付、基础支付(服务商) - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 申请退款
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_9.shtml">基础支付 - JSAPI支付 - 申请退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_9.shtml">基础支付 - APP支付 - 申请退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_9.shtml">基础支付 - H5支付 - 申请退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_9.shtml">基础支付 - Native支付 - 申请退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_9.shtml">基础支付 - 小程序支付 - 申请退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_9.shtml">基础支付(服务商) - JSAPI支付 - 申请退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_9.shtml">基础支付(服务商) - APP支付 - 申请退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_3_9.shtml">基础支付(服务商) - H5支付 - 申请退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_4_9.shtml">基础支付(服务商) - Native支付 - 申请退款API</a> - 最新更新时间：2021.05.28</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_5_9.shtml">基础支付(服务商) - 小程序支付 - 申请退款API</a> - 最新更新时间：2021.05.28</para>
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
