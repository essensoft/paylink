using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain;

/// <summary>
/// 转账明细
/// </summary>
public class TransferDetail : WeChatPayObject
{
    /// <summary>
    /// 商家明细单号
    /// </summary>
    /// <remarks>
    /// 商户系统内部区分转账批次单下不同转账明细单的唯一标识，要求此参数只能由数字、大小写字母组成
    /// <para>示例值：x23zy545Bd5436</para>
    /// </remarks>
    [JsonPropertyName("out_detail_no")]
    public string OutDetailNo { get; set; }

    /// <summary>
    /// 转账金额
    /// </summary>
    /// <remarks>
    /// 转账金额单位为分
    /// <para>示例值：200000</para>
    /// </remarks>
    [JsonPropertyName("transfer_amount")]
    public int TransferAmount { get; set; }

    /// <summary>
    /// 转账备注
    /// </summary>
    /// <remarks>
    /// 单条转账备注（微信用户会收到该备注），UTF8编码，最多允许32个字符
    /// <para>示例值：2020年4月报销</para>
    /// </remarks>
    [JsonPropertyName("transfer_remark")]
    public string TransferRemark { get; set; }

    /// <summary>
    /// 用户在直连商户应用下的用户标示
    /// </summary>
    /// <remarks>
    /// openid是微信用户在公众号appid下的唯一用户标识（appid不同，则获取到的openid就不同），可用于永久标记一个用户
    /// <a href="https://pay.weixin.qq.com/wiki/doc/apiv3/terms_definition/chapter1_1_3.shtml">获取openid</a>
    /// <para>示例值：o-MYE42l80oelYMDE34nYD456Xoy</para>
    /// </remarks>
    [JsonPropertyName("openid")]
    public string OpenId { get; set; }

    /// <summary>
    /// 收款用户姓名
    /// </summary>
    /// <remarks>
    /// 1、明细转账金额 >= 2,000，收款用户姓名必填；
    /// 2、同一批次转账明细中，收款用户姓名字段需全部填写、或全部不填写；
    /// 3、 若传入收款用户姓名，微信支付会校验用户openID与姓名是否一致，并提供电子回单；
    /// 4、收款方姓名。采用标准RSA算法，公钥由微信侧提供
    /// 5、该字段需进行加密处理，加密方法详见敏感信息加密说明。(提醒：必须在HTTP头中上送Wechatpay-Serial)
    /// <para>示例值：757b340b45ebef5467rter35gf464344v3542sdf4t6re4tb4f54ty45t4yyry45</para>
    /// </remarks>
    [WeChatPayPrivacyProperty]
    [JsonPropertyName("user_name")]
    public string UserName { get; set; }
}
