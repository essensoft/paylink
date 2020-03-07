using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.ins.scene.claim.attachment.upload
    /// </summary>
    public class AlipayInsSceneClaimAttachmentUploadRequest : IAlipayUploadRequest<AlipayInsSceneClaimAttachmentUploadResponse>
    {
        /// <summary>
        /// 案件材料名称
        /// </summary>
        public string AttachmentName { get; set; }

        /// <summary>
        /// 附件材料类型  现场照片：SCENE_PHOTO  身份证影印件： ID_COPY  发票： INVOICE  医疗凭证： MEDICAL_CERTIFICATE
        /// </summary>
        public string AttachmentType { get; set; }

        /// <summary>
        /// 理赔申请报案号，通过理赔申请【alipay.ins.scene.claim.apply】接口的返回字段claim_report_no获取
        /// </summary>
        public string ClaimReportNo { get; set; }

        /// <summary>
        /// 报案材料描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 报案材料内容
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 案件材料文件类型  例如一下值   .jpg .png .csv .docx
        /// </summary>
        public string FileType { get; set; }

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
            return "alipay.ins.scene.claim.attachment.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "attachment_name", AttachmentName },
                { "attachment_type", AttachmentType },
                { "claim_report_no", ClaimReportNo },
                { "description", Description },
                { "file_type", FileType }
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
