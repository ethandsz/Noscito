using Noscito.Api.Models;

namespace Noscito.ComputationalLayer;

public interface IHoldLevelFinder
{ 
    List<CandleStick> IdentifyWickRanges(List<CandleStick> wicks);
}