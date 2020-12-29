using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.marketing.tool.task.receive
    /// </summary>
    public class AlipayMarketingToolTaskReceiveRequest : IAlipayRequest<AlipayMarketingToolTaskReceiveResponse>
    {
        /// <summary>
        /// 当完成任务（send）或者主动领奖（receive）且奖品决策方式为指定奖品决策时，需要传入的奖品ID。
        /// </summary>
        public string SpecificPrizeId { get; set; }

        /// <summary>
        /// 阶段码，signup任务报名，send任务完成，receive主动领取。stagecode需要根据具体任务的不同类型（是否需要主动报名/用户触发还是事件触发）来传参。
        /// </summary>
        public string StageCode { get; set; }

        /// <summary>
        /// 任务ID。
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        public string UserId { get; set; }

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

        public string GetApiName()
        {
            return "alipay.marketing.tool.task.receive";
        }

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "specific_prize_id", SpecificPrizeId },
                { "stage_code", StageCode },
                { "task_id", TaskId },
                { "user_id", UserId }
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
    }
}
