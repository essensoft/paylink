using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// ant.merchant.expand.attachment.upload.sync
    /// </summary>
    public class AntMerchantExpandAttachmentUploadSyncRequest : IAlipayUploadRequest<AntMerchantExpandAttachmentUploadSyncResponse>
    {
        /// <summary>
        /// 附件的业务类型
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 附属信息，JSON格式
        /// </summary>
        public string ExtInfo { get; set; }

        /// <summary>
        /// 文件字节流
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 文档静态格式
        /// </summary>
        public string FileFormat { get; set; }

        /// <summary>
        /// 文件链接
        /// </summary>
        public string FileUrl { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 附件单据号
        /// </summary>
        public string OutBizNo { get; set; }

        /// <summary>
        /// 分区
        /// </summary>
        public Nullable<long> PartNo { get; set; }

        /// <summary>
        /// 附件的业务子类型
        /// </summary>
        public string SubBizType { get; set; }

        /// <summary>
        /// 附件子单据号
        /// </summary>
        public string SubOutBizNo { get; set; }

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
            return "ant.merchant.expand.attachment.upload.sync";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "biz_type", BizType },
                { "ext_info", ExtInfo },
                { "file_format", FileFormat },
                { "file_url", FileUrl },
                { "memo", Memo },
                { "out_biz_no", OutBizNo },
                { "part_no", PartNo },
                { "sub_biz_type", SubBizType },
                { "sub_out_biz_no", SubOutBizNo }
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
                { "file_content", FileContent }
            };
            return parameters;
        }

        #endregion
    }
}
