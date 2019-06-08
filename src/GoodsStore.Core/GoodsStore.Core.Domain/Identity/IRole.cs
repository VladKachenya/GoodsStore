namespace GoodsStore.Core.Domain.Identity
{
    public interface IRole
    {
        /// <summary>
        ///     Normalized role name
        /// </summary>
        string NormalizedName { get; set; }

        /// <summary>
        ///     Concurrency stamp 
        /// </summary>
        string ConcurrencyStamp { get; set; }
    }
}