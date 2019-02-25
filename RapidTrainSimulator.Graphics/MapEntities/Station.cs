namespace RapidTrainSimulator.Graphics.MapEntities
{
    public class Station : GraphicEntityBase
    {
        public string Name { get; set; }
        public int Size { get; set; }

        // game dynamic
        public int CurrentPeople { get; set; }
        public int Capacity { get; set; }

        public override object RelatedObject { get; set; }
    }
}
