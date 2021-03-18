using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付、基础支付(服务商) - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 申请资金账单
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_7.shtml">基础支付 - JSAPI支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_7.shtml">基础支付 - APP支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_7.shtml">基础支付 - H5支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_7.shtml">基础支付 - Native支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_7.shtml">基础支付 - 小程序支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_7.shtml">基础支付(服务商) - JSAPI支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_7.shtml">基础支付(服务商) - APP支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_3_7.shtml">基础支付(服务商) - H5支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_4_7.shtml">基础支付(服务商) - Native支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_5_7.shtml">基础支付(服务商) - 小程序支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// </remarks>
    public class WeChatPayBillFundflowBillRequest : IWeChatPayGetRequest<WeChatPayBillFundflowBillResponse>
    {
        private WeChatPayObject queryModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/bill/fundflowbill";
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
