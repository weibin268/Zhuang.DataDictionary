using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zhuang.DataDictionary.Models
{
    [Zhuang.Data.Annotations.Table("Sys_DataDictionary")]
    public class SysDataDictionary
    {
        [Zhuang.Data.Annotations.Key]
        public string DataDictionaryId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
