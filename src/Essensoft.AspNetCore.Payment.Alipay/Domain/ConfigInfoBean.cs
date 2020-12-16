using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ConfigInfoBean Data Structure.
    /// </summary>
    public class ConfigInfoBean : AlipayObject
    {
        /// <summary>
        /// 配置附件收集任务相关信息
        /// </summary>
        [JsonPropertyName("attachment_explain")]
        public AttachmentExplainBean AttachmentExplain { get; set; }

        /// <summary>
        /// 签署完成是否自动归档，默认true，如果false，则归档需要调用签署流程归档接口
        /// </summary>
        [JsonPropertyName("auto_archive")]
        public bool AutoArchive { get; set; }

        /// <summary>
        /// 是否收集附件（需签署人上传身份证或者其他文件的，需设置为true）
        /// </summary>
        [JsonPropertyName("collect_attachement")]
        public bool CollectAttachement { get; set; }

        /// <summary>
        /// 物流公司编号（目前仅支持顺丰"SF"） 注：避免影响生产订单，联调及测试环境请传入SF_TEST。
        /// </summary>
        [JsonPropertyName("company_no")]
        public string CompanyNo { get; set; }

        /// <summary>
        /// 合同过期时间：该参数设置的时间若到期，则会触发流程文件过期通知
        /// </summary>
        [JsonPropertyName("contract_validity")]
        public long ContractValidity { get; set; }

        /// <summary>
        /// 签署完成后跳转商户小程序的地址（signModel字段值为2时 选填）
        /// </summary>
        [JsonPropertyName("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 商户小程序签署地址（signModel字段值为1时 必填）
        /// </summary>
        [JsonPropertyName("merchant_mini_sign_url")]
        public string MerchantMiniSignUrl { get; set; }

        /// <summary>
        /// https://esign.cn/callback
        /// </summary>
        [JsonPropertyName("notice_developer_url")]
        public string NoticeDeveloperUrl { get; set; }

        /// <summary>
        /// 平台订单号，可将商户订单与电子合同进行关联。用户通过支付宝官方小程序 合同管家 查看合同时，可快速进入商家的小程序及对应的订单详情页，为商家的小程序提供了流量入口，提高用户的活跃度和留存率；
        /// </summary>
        [JsonPropertyName("platform_order_no")]
        public string PlatformOrderNo { get; set; }

        /// <summary>
        /// 12或15位物流单号
        /// </summary>
        [JsonPropertyName("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 快递扫码签收方式： 1-商户小程序：扫码后跳转商户小程序进行签收； 0-e签宝小程序：如商户没有支付宝小程序，可使用e签宝小程序完成签收。
        /// </summary>
        [JsonPropertyName("sign_model")]
        public long SignModel { get; set; }

        /// <summary>
        /// 指定签署人需要上传的附件列表，例如：A、B、C三方签署，A需上传附件1，B需指定附件2，C需上传附件1,2,3
        /// </summary>
        [JsonPropertyName("specify_attachment_infos")]
        public List<SpecifyAttachmentInfo> SpecifyAttachmentInfos { get; set; }
    }
}
