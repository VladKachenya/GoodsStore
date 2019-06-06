using System;
using System.Linq;
using GoodsStore.App.Infrastructure.Helpers;
using Microsoft.AspNetCore.Identity;

namespace GoodsStore.Core.Logic.Helpers
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
    }
}