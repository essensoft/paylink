using System.Collections.Generic;
using Essensoft.Paylink.Security;
using Essensoft.Paylink.WeChatPay;
using Essensoft.Paylink.WeChatPay.V3;

namespace BankAggregationApi.Bank.BankProviders.Weixin;

/// <summary>
/// 基础支付(服务商) - JSAPI支付 - JSAPI调起支付
/// <remarks>
/// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_4.shtml">JSAPI支付 - JSAPI调起支付</a>最新更新时间：2022.06.07</para>
/// </remarks>
/// </summary>
public class WeChatPayPartnerJsApiSdkRequest : IWeChatPaySdkRequest
{
    /// <summary>
    /// 订单详情扩展字符串
    /// </summary>
    /// <remarks>
    /// 统一下单接口返回的prepay_id参数值，提交格式如：prepay_id=***
    /// <para>示例值：prepay_id=wx201410272009395522657a690389285100</para>
    /// </remarks>
    public string Package { get; set; }

    /// <summary>
    /// 子商户应用号
    /// </summary>
    public string SubAppId { get; set; }


    /// <summary>获取文本请求参数字典</summary>
    public IDictionary<string, string> GetParameters()
    {
        var parameters = new WeChatPayDictionary
        {
            { "package", Package }
        };
        return parameters;
    }

    /// <summary>参数处理器</summary>
    /// <param name="sortedTxtParams">排序文本参数</param>
    /// <param name="options">配置选项</param>
    public void PrimaryHandler(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
    {
        if (!string.IsNullOrEmpty(SubAppId))
        {
            sortedTxtParams.Add(WeChatPayConsts.appId, SubAppId);
        }
        else
        {
            sortedTxtParams.Add(WeChatPayConsts.appId, options.AppId);
        }

        sortedTxtParams.Add(WeChatPayConsts.timeStamp, WeChatPayUtility.GetTimeStamp());
        sortedTxtParams.Add(WeChatPayConsts.nonceStr, WeChatPayUtility.GenerateNonceStr());
        sortedTxtParams.Add(WeChatPayConsts.signType, WeChatPayConsts.RSA);

        var signatureSourceData = BuildSignatureSourceData(sortedTxtParams);
        sortedTxtParams.Add(WeChatPayConsts.paySign, SHA256WithRSA.Sign(options.RSAPrivateKey, signatureSourceData));
    }

    private static string BuildSignatureSourceData(WeChatPayDictionary sortedTxtParams)
    {
        return $"{sortedTxtParams.GetValue(WeChatPayConsts.appId)}\n{sortedTxtParams.GetValue(WeChatPayConsts.timeStamp)}\n{sortedTxtParams.GetValue(WeChatPayConsts.nonceStr)}\n{sortedTxtParams.GetValue(WeChatPayConsts.package)}\n";
    }
}