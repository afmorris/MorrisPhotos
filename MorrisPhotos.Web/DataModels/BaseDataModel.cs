using ServiceStack.DataAnnotations;

namespace MorrisPhotos.Web.DataModels
{
    public abstract class BaseDataModel : IDataModel
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
    }
}