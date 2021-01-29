using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付 - 申请资金账单API（电商平台、服务商、直连商户）
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_7.shtml">JSAPI支付 - 申请资金账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_7.shtml">APP支付 - 申请资金账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_7.shtml">H5支付 - 申请资金账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_7.shtml">Native支付 - 申请资金账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_7.shtml">小程序支付 - 申请资金账单API</a></para>
    /// 最新更新时间：2019.09.16
    /// </summary>
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
