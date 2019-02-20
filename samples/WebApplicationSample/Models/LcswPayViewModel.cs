using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationSample.Models
{
    public class LcswPaySignViewModel
    {
        /// <summary>
        /// 终端流水号，填写商户系统的订单号
        /// </summary>
        [Display(Name ="终端流水号")]
        [Required(ErrorMessage ="请输入终端流水号")]
        public string TerminalTrace { get; set; }
        /// <summary>
        /// 终端注册时间，yyyyMMddHHmmss，全局统一时间格式
        /// </summary>
        [Display(Name ="终端注册时间")]
        [Required(ErrorMessage = "请输入终端注册时间")]
        public string TerminalTime { get; set; }
    }
}
