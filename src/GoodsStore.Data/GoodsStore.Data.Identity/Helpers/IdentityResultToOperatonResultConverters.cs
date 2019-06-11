using System;
using System.Linq;
using GoodsStore.Core.Domain.Helpers;
using Microsoft.AspNetCore.Identity;

namespace GoodsStore.Data.Identity.Helpers
{
    public class IdentityResultToOperatonResultConverters
    {
        public OperationResult Convert(IdentityResult entity)
        {
            if (entity == null) throw new ArgumentNullException();

            return entity.Succeeded
                ? OperationResult.SucceedResult
                : new OperationResult(entity.Errors.Select( e => e.Description));
        }

        public OperationResult<T> Convert<T>(T entity)
        {
            if (entity == null)
            {
                return new OperationResult<T>("Entity not found");
            }
            return new OperationResult<T>(entity, true);
        }

        public OperationResult<T> Convert<T>(T entity, OperationResult result)
        {
            if (entity == null)
            {
                return new OperationResult<T>("Entity not found");
            }

            if (!result.IsSucceed)
            {
                return new OperationResult<T>(entity, false, result.ErrorList);
            }
            return new OperationResult<T>(entity, true);
        }
    }
}