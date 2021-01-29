using System;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 商户进件（普通服务商）- 查询结算账户API
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/tool/applyment4sub/chapter3_4.shtml">查询结算账户API</a></para>
    /// 最新更新时间：2019.09.09
    /// </summary>
    public class WeChatPayApply4SubSubMerchantsSubMchIdSettlementRequest : IWeChatPayGetRequest<WeChatPayApply4SubSubMerchantsSubMchIdSettlementResponse>
    {
        /// <summary>
        /// 特约商户号	
        /// 请输入本服务商进件、已签约的特约商户号。
        /// 示例值：1900006491
        /// </summary>
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
    }
}
