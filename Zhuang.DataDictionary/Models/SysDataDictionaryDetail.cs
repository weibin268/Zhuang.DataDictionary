using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zhuang.DataDictionary.Models
{
    [Zhuang.Data.Annotations.Table("Sys_DataDictionaryDetail")]
    public class SysDataDictionaryDetail
    {
        [Zhuang.Data.Annotations.Key]
        public string DataDictionaryDetailId { get; set; }

        public string DataDictionaryId { get; set; }

        public string Code { get; set; }

        public string Text { get; set; }

        public int Status { get; set; }

        public int Seq { get; set; }

        public string Description { get; set; }
    }
}
