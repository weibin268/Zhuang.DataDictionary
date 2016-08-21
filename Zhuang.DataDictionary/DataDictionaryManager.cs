using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zhuang.DataDictionary.Common;
using Zhuang.DataDictionary.Models;
using Zhuang.DataDictionary.Services;

namespace Zhuang.DataDictionary
{
    public class DataDictionaryManager
    {
        IDataDictionaryService _service;

        public DataDictionaryManager():this(new DefaultDataDictionaryService())
        {
            
        }

        public DataDictionaryManager(IDataDictionaryService service)
        {
            _service = service;
        }

        public IList<DataDictionaryItemModel> GetDataDictionaryItems(string code)
        {
            IList<DataDictionaryItemModel> result = new List<DataDictionaryItemModel>();

            var master = _service.GetByCode(code);

            var details = _service.GetDetailList(master.DataDictionaryId);

            var enabledDetails = details.Where(c => c.Status == (int)StatusType.Enabled);

            result = enabledDetails.Select(c => new DataDictionaryItemModel() { Code = c.Code, Text = c.Text }).ToList();

            return result;
        }
    }
}
