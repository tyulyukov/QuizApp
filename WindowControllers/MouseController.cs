using System;
using System.Drawing;

namespace WindowControllers
{
    public class MouseController
    {
        public Point Distance { get; private set; }
        public bool IsPushed { get; private set; }

        public MouseController()
        {
            IsPushed = false;
            AnnulDistance();
        }

        public void Push()
        {
            if (!IsPushed)
                AnnulDistance();

            IsPushed = !IsPushed;
        }

        public void SetDistance(Point distance)
        {
            if (distance == null || distance.IsEmpty)
                throw new ArgumentNullException();

            Distance = distance;
        }

        public void AnnulDistance()
        {
            Distance = Point.Empty;
        }
    }
}
