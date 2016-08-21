using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zhuang.Data;
using Zhuang.DataDictionary.Models;

namespace Zhuang.DataDictionary.Services
{
    public class DefaultDataDictionaryService : IDataDictionaryService
    {
        private DbAccessor _dba = DbAccessor.Get();

        public SysDataDictionary Get(string id)
        {
            return _dba.Select<SysDataDictionary>(id);
        }

        public SysDataDictionary GetByCode(string code)
        {
            return _dba.SelectList<SysDataDictionary>(new { Code = code }).FirstOrDefault();
        }

        public IList<SysDataDictionaryDetail> GetDetailList(string dataDictionaryId)
        {
            return _dba.SelectList<SysDataDictionaryDetail>(new {
                DataDictionaryId =dataDictionaryId,
            });
        }
    }
}
