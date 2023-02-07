using AkiinsBreakfast.DTO;

namespace AkiinsBreakfast.Contracts.Services
{
    public interface IBreakfastService
    {
        BreakFastResponseModel CreateBreakFast(BreakFastDTO request);
        BreakFastResponseModel GetBreakFast(int id);
        BreakFastResponseModel DeleteBreakFast(int id);
        BreakFastResponseModel UpdateBreakFast(int id, UpdateBreakFastDTO request);
        BreakFastsResponseModels PrintAllBreakFast();
    }
}