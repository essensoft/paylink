using System;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付 - 下载账单API（电商平台、服务商、直连商户）
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_8.shtml">JSAPI支付 - 下载账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_8.shtml">APP支付 - 下载账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_8.shtml">H5支付 - 下载账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_8.shtml">Native支付 - 下载账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_8.shtml">小程序支付 - 下载账单API</a></para>
    /// 最新更新时间：2019.09.16
    /// </summary>
    public class WeChatPayBillDownloadRequest : IWeChatPayGetRequest<WeChatPayBillDownloadResponse>
    {
        private string requestUrl;

        public string GetRequestUrl()
        {
            return requestUrl;
        }

        public void SetDownloadUrl(string url)
        {
            requestUrl = url;
        }

        public WeChatPayObject GetQueryModel()
        {
            throw new NotImplementedException();
        }

        public void SetQueryModel(WeChatPayObject queryModel)
        {
            throw new NotImplementedException();
        }

        public bool GetNeedCheckSign()
        {
            return false;
        }

        public bool GetNeedQueryModel()
        {
            return false;
        }
    }
}
