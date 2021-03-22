using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 电商收付通(下载账单) - 申请二级商户资金账单 - 请求URL参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_9_5.shtml">电商收付通(下载账单) - 申请二级商户资金账单API</a> - 最新更新时间：2020.08.10</para>
    /// </remarks>
    public class WeChatPayEcommerceBillFundflowBillRequest : IWeChatPayGetRequest<WeChatPayEcommerceBillFundflowBillResponse>
    {
        private WeChatPayObject queryModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/ecommerce/bill/fundflowbill";
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
