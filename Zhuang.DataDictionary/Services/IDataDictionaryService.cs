using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zhuang.DataDictionary.Models;

namespace Zhuang.DataDictionary.Services
{
    public interface IDataDictionaryService
    {
        SysDataDictionary Get(string id);

        SysDataDictionary GetByCode(string code);

        IList<SysDataDictionaryDetail> GetDetailList(string DataDictionaryId);
    }
}
