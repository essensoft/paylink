using System;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 下载账单API（电商平台、服务商、直连商户）
    /// 最新更新时间：2019.09.16
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_8.shtml
    /// </summary>
    public class WeChatPayBillDownloadRequest : IWeChatPayGetRequest<WeChatPayBillDownloadResponse>
    {
        private WeChatPayObject queryModel;

        public string GetRequestUrl()
        {
            throw new NotImplementedException();
        }

        public WeChatPayObject GetQueryModel()
        {
            return queryModel;
        }

        public void SetQueryModel(WeChatPayObject queryModel)
        {
            this.queryModel = queryModel;
        }

        public bool GetNeedCheckSign()
        {
            return false;
        }
    }
}
