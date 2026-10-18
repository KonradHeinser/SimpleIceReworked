using Verse;

namespace SimpleIceReworked;

public class PlaceWorker_Ice : PlaceWorker
{
    public override AcceptanceReport AllowsPlacing(BuildableDef checkingDef, IntVec3 loc, Rot4 rot, Map map, Thing thingToIgnore = null, Thing thing = null)
    {
        return loc.GetTerrain(map).defName != "Ice" ? 
            new AcceptanceReport("OPOI_NeedIce".Translate()) : 
            base.AllowsPlacing(checkingDef, loc, rot, map, thingToIgnore, thing);
    }
}