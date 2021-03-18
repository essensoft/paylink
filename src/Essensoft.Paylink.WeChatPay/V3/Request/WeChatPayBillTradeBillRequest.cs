using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付、基础支付(服务商) - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 申请交易账单 - 请求URL参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_6.shtml">基础支付 - JSAPI支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_6.shtml">基础支付 - APP支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_6.shtml">基础支付 - H5支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_6.shtml">基础支付 - Native支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_6.shtml">基础支付 - 小程序支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_6.shtml">基础支付(服务商) - JSAPI支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_6.shtml">基础支付(服务商) - APP支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_3_6.shtml">基础支付(服务商) - H5支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_4_6.shtml">基础支付(服务商) - Native支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_5_6.shtml">基础支付(服务商) - 小程序支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// </remarks>
    public class WeChatPayBillTradeBillRequest : IWeChatPayGetRequest<WeChatPayBillTradeBillResponse>
    {
        private WeChatPayObject queryModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/bill/tradebill";
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
