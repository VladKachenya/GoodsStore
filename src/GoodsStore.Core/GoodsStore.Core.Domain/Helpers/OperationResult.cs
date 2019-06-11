using System.Collections.Generic;
using System.Linq;

namespace GoodsStore.Core.Domain.Helpers
{
    public class OperationResult
    {
        protected readonly List<string> _errorList = new List<string>();
        public static OperationResult SucceedResult => new OperationResult();

        public OperationResult()
        {
            IsSucceed = true;
        }
        public OperationResult(string error)
        {
            IsSucceed = false;
            _errorList.Add(error);
        }

        public OperationResult(IEnumerable<string> errors)
        {
            IsSucceed = false;
            _errorList.AddRange(errors);
        }

        public IEnumerable<string> ErrorList => _errorList;

        public string GetFirstError()
        {
            return ErrorList.FirstOrDefault();
        }
        public bool IsSucceed { get; protected set; }
    }



    public class OperationResult<T> : OperationResult
    {
        public T Item { get; set; }

        public OperationResult(T resultItem, bool isSucceed, IEnumerable<string> errors = null)
        {
            IsSucceed = isSucceed;
            Item = resultItem;
            if(errors != null && errors.Any()) _errorList.AddRange(errors);
        }
        public OperationResult(string error) : base(error)
        {
        }
    }
}