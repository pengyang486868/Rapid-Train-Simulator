using System;

namespace RapidTrainSimulator.Graphics
{
    public abstract class GraphicEntityBase
    {
        public Guid UniqueId { get; set; }
        public int Id { get; set; }

        public int Top { get; set; }
        public int Left { get; set; }
        public string Info { get; set; }

        public abstract object RelatedObject { get; set; }
    }
}
