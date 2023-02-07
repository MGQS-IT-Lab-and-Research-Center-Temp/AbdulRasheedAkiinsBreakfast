using AkiinsBreakfast.Entities;

namespace AkiinsBreakfast.DTO
{
    public class BreakFastsResponseModels : BaseResponseModel
    {
        public List<Breakfast> Data { get; set; }
    }
}
