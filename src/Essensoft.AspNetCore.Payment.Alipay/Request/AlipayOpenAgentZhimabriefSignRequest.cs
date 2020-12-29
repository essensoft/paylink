using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.open.agent.zhimabrief.sign
    /// </summary>
    public class AlipayOpenAgentZhimabriefSignRequest : IAlipayUploadRequest<AlipayOpenAgentZhimabriefSignResponse>
    {
        /// <summary>
        /// 支付宝生活号(原服务窗)名称（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）
        /// </summary>
        public string AlipayLifeName { get; set; }

        /// <summary>
        /// APP demo，格式为.apk；或者应用说明文档, 格式为.doc .docx .pdf格式（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）
        /// </summary>
        public FileItem AppDemo { get; set; }

        /// <summary>
        /// 商户的APP应用名称（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 代商户操作事务编号，通过alipay.open.isv.agent.create接口进行创建。
        /// </summary>
        public string BatchNo { get; set; }

        /// <summary>
        /// 营业执照授权函图片，个体工商户如果使用总公司或其他公司的营业执照认证需上传该授权函图片，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem BusinessLicenseAuthPic { get; set; }

        /// <summary>
        /// 营业执照号码。
        /// </summary>
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 营业执照图片，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem BusinessLicensePic { get; set; }

        /// <summary>
        /// 自定义使用场景描述，usage_scene选项中无符合描述，填写自定义使用场景描述(usage_scene不填写，则custom_usage_scene必填)
        /// </summary>
        public string CustomUsageScene { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        public string DateLimitation { get; set; }

        /// <summary>
        /// 数据反馈接口人
        /// </summary>
        public ContactModel DrContact { get; set; }

        /// <summary>
        /// 例如：浙江飞猪网络技术有限公司，企业别称请填写【飞猪】。
        /// </summary>
        public string EnterpriseAlias { get; set; }

        /// <summary>
        /// 企业LOGO-图片，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem EnterpriseLogo { get; set; }

        /// <summary>
        /// 营业期限是否长期有效
        /// </summary>
        public Nullable<bool> LongTerm { get; set; }

        /// <summary>
        /// 所属MCCCode，详情可参考  <a href="https://doc.open.alipay.com/doc2/detail.htm?spm=a219a.7629140.0.0.59bgD2&treeId=222&articleId=105364&docType=1#s1  ">商家经营类目</a> 中的“经营类目编码”
        /// </summary>
        public string MccCode { get; set; }

        /// <summary>
        /// 异议处理接口人
        /// </summary>
        public ContactModel OhContact { get; set; }

        /// <summary>
        /// 用户服务联动机制接口人
        /// </summary>
        public ContactModel PrContact { get; set; }

        /// <summary>
        /// 企业特殊资质图片，可参考  <a href="https://doc.open.alipay.com/doc2/detail.htm?spm=a219a.7629140.0.0.59bgD2&treeId=222&articleId=105364&docType=1#s1  ">商家经营类目</a> 中的“需要的特殊资质证书”，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem SpecialLicensePic { get; set; }

        /// <summary>
        /// 使用场景描述，签约芝麻信用产品的用途，可选值："现金放贷","其他", "消费分期（例如买房、装修等）", "融资租赁", "发放信用卡", "极速返利", "押金减免", "先用后付", "社交场景信用互查", "会员分层信用参考"
        /// </summary>
        public List<string> UsageScene { get; set; }

        /// <summary>
        /// 接入网址信息（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）
        /// </summary>
        public List<string> WebSites { get; set; }

        /// <summary>
        /// 微信公众号名称（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）
        /// </summary>
        public string WechatOfficialAccountName { get; set; }

        #region IAlipayRequest Members
        private bool needEncrypt = false;
        private string apiVersion = "1.0";
        private string terminalType;
        private string terminalInfo;
        private string prodCode;
        private string notifyUrl;
        private string returnUrl;
        private AlipayObject bizModel;

        public void SetNeedEncrypt(bool needEncrypt)
        {
            this.needEncrypt = needEncrypt;
        }

        public bool GetNeedEncrypt()
        {
            return needEncrypt;
        }

        public void SetNotifyUrl(string notifyUrl)
        {
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl()
        {
            return notifyUrl;
        }

        public void SetReturnUrl(string returnUrl)
        {
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl()
        {
            return returnUrl;
        }

        public void SetTerminalType(string terminalType)
        {
            this.terminalType = terminalType;
        }

        public string GetTerminalType()
        {
            return terminalType;
        }

        public void SetTerminalInfo(string terminalInfo)
        {
            this.terminalInfo = terminalInfo;
        }

        public string GetTerminalInfo()
        {
            return terminalInfo;
        }

        public void SetProdCode(string prodCode)
        {
            this.prodCode = prodCode;
        }

        public string GetProdCode()
        {
            return prodCode;
        }

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.open.agent.zhimabrief.sign";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "alipay_life_name", AlipayLifeName },
                { "app_name", AppName },
                { "batch_no", BatchNo },
                { "business_license_no", BusinessLicenseNo },
                { "custom_usage_scene", CustomUsageScene },
                { "date_limitation", DateLimitation },
                { "dr_contact", DrContact },
                { "enterprise_alias", EnterpriseAlias },
                { "long_term", LongTerm },
                { "mcc_code", MccCode },
                { "oh_contact", OhContact },
                { "pr_contact", PrContact },
                { "usage_scene", UsageScene },
                { "web_sites", WebSites },
                { "wechat_official_account_name", WechatOfficialAccountName }
            };
            return parameters;
        }

        public AlipayObject GetBizModel()
        {
            return bizModel;
        }

        public void SetBizModel(AlipayObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion

        #region IAlipayUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>
            {
                { "app_demo", AppDemo },
                { "business_license_auth_pic", BusinessLicenseAuthPic },
                { "business_license_pic", BusinessLicensePic },
                { "enterprise_logo", EnterpriseLogo },
                { "special_license_pic", SpecialLicensePic }
            };
            return parameters;
        }

        #endregion
    }
}
