using Verse;

namespace OnlyPlaceOnIce
{
    public class PlaceWorker_Ice : PlaceWorker
    {
        public override AcceptanceReport AllowsPlacing(BuildableDef checkingDef, IntVec3 loc, Rot4 rot, Map map, Thing thingToIgnore = null, Thing thing = null)
        {
            if (loc.GetTerrain(map).defName != "Ice")
                return new AcceptanceReport("OPOI_NeedIce".Translate());

            return base.AllowsPlacing(checkingDef, loc, rot, map, thingToIgnore, thing);
        }
    }
}
