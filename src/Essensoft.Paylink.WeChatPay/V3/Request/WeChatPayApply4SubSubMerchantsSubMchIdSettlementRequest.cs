using System;
using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 特约商户进件 - 提交申请单
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter11_1_1.shtml">特约商户进件 - 提交申请单API</a> - 最新更新时间：2019.04.10</para>
    /// </remarks>
    public class WeChatPayApply4SubSubMerchantsSubMchIdSettlementRequest : IWeChatPayGetRequest<WeChatPayApply4SubSubMerchantsSubMchIdSettlementResponse>
    {
        /// <summary>
        /// 特约商户号
        /// </summary>
        /// <remarks>
        /// 请输入本服务商进件、已签约的特约商户号。
        /// <para>示例值：1900006491</para>
        /// </remarks>
        public string SubMchId { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/apply4sub/sub_merchants/{SubMchId}/settlement";
        }

        public WeChatPayObject GetQueryModel()
        {
            throw new NotImplementedException();
        }

        public void SetQueryModel(WeChatPayObject queryModel)
        {
            throw new NotImplementedException();
        }

        public bool GetNeedQueryModel()
        {
            return false;
        }
    }
}
